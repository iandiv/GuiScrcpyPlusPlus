using GuiScrcpyPlusPlus.Properties;
using Microsoft.Win32;
using Salaros.Configuration;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace GuiScrcpyPlusPlus
{
    internal static class Program
    {
        [DllImport("uxtheme.dll", EntryPoint = "#135", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern int SetPreferredAppMode(int preferredAppMode);

        [DllImport("uxtheme.dll", EntryPoint = "#136", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern void FlushMenuThemes();
        private static NotifyIcon trayIcon;
        private static Form1 mainForm;
        private static AboutForm aboutForm;

        private static MenuItem showOnStartupMenuItem;
        private static Properties.Settings settings = Properties.Settings.Default;
    

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Retrieve command-line arguments
            string[] args = Environment.GetCommandLineArgs();

            // Check if the "--silent" argument is provided
            bool isSilent = Array.Exists(args, element => element == "--silent");
          
           
            // Create and show the tray icon with the same icon as the form
            Icon formIcon = new Form1().Icon;
            ShowTrayIcon(formIcon);
            aboutForm = new AboutForm();
            if (isSilent)
            {
                Console.WriteLine("Running in silent mode...");

                // Your background logic goes here...

                // Exit the application when the user closes the tray icon
                Application.Run();
            }
            else
            {
                mainForm = new Form1();
                mainForm.FormClosing += MainForm_FormClosing; // Add event handler
                Application.Run(mainForm);
            }
        }

        private static void ShowTrayIcon(Icon icon)
        {
            trayIcon = new NotifyIcon
            {
                Icon = icon,
                Visible = true
            };

            // Add a context menu to the tray icon
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Show GuiScrcpy++", OnShowFormClick));
            showOnStartupMenuItem = new MenuItem("Run on Startup", OnShowOnStartupClick);
            contextMenu.MenuItems.Add(showOnStartupMenuItem);
            contextMenu.MenuItems.Add(new MenuItem("-")); // Separator
            contextMenu.MenuItems.Add(new MenuItem("About", OnShowAboutClick));
            contextMenu.MenuItems.Add(new MenuItem("Exit", OnExitClick));

         
            trayIcon.ContextMenu = contextMenu;

            // Hook up the double-click event to show the form
            trayIcon.DoubleClick += (sender, e) => ShowForm();
            // Set the initial state of "Show on Startup" based on settings
           // showOnStartupMenuItem.Checked = settings.ShowOnStartup;
            showOnStartupMenuItem.Checked = IsStartupSettingEnabled();
            // Enable Dark mode Menu
            SetPreferredAppMode(2);
            FlushMenuThemes();
        }

        private static void OnShowFormClick(object sender, EventArgs e)
        {
            ShowForm();
        }
        private static void OnShowAboutClick(object sender, EventArgs e)
        {
            ShowAbout();
        }
        private static void ShowAbout()
        {
            if (aboutForm == null || aboutForm.IsDisposed)
            {
                aboutForm = new AboutForm();
                aboutForm.FormClosing += MainForm_FormClosing; // Add event handler
            }

            if (aboutForm.WindowState == FormWindowState.Minimized)
            {
                aboutForm.WindowState = FormWindowState.Normal;
            }

            if (!aboutForm.Visible)
            {
                aboutForm.ShowDialog();
            }

            aboutForm.Activate();
        }


        private static void ShowForm()
        {
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new Form1();
                mainForm.FormClosing += MainForm_FormClosing; // Add event handler
            }

            if (mainForm.WindowState == FormWindowState.Minimized)
            {
                mainForm.WindowState = FormWindowState.Normal;
            }

            if (!mainForm.Visible)
            {
                mainForm.Show();
            }

            mainForm.Activate();
            mainForm.InitializeDeviceCheckTimer();
            mainForm.InitializeScrcpyStatusTimer();
        }

       


        private static void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Minimize to system tray instead of closing
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                mainForm.Visible = false;
            }
            else
            {
              
                // Unhook the event handler and then exit the application
                mainForm.FormClosing -= MainForm_FormClosing;
                Application.Exit();
            }
        }

        private static void OnShowOnStartupClick(object sender, EventArgs e)
        {
          
            showOnStartupMenuItem.Checked = !IsStartupSettingEnabled();
          
            ToggleStartupSetting(!IsStartupSettingEnabled());
        }
        private static void ToggleStartupSetting(bool enable)
        {
            // Toggle the "Show on Startup" setting in the registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (enable)
            {
                // Add the registry entry with the silent argument
                key.SetValue("GuiScrcpy++", $"\"{Application.ExecutablePath}\" --silent");
            }
            else
            {
                // Remove the registry entry
                key.DeleteValue("GuiScrcpy++", false);
            }
        }

        private static bool IsStartupSettingEnabled()
        {
            // Check if the "Show on Startup" setting is enabled in the registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");

            return key?.GetValue("GuiScrcpy++") != null;
        }
        private static void OnExitClick(object sender, EventArgs e)
        {
            // Clean up and terminate the application when the user chooses to exit

            // Terminate background tasks or threads here

            // Close all open forms
            mainForm?.Close();

            trayIcon.Visible = false;

            

            Application.Exit();
        }

      
    }
}
