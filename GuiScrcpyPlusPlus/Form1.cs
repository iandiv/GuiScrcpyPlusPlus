using Salaros.Configuration;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinBlur.UI;

namespace GuiScrcpyPlusPlus
{
    public partial class Form1 : Form
    {
        private bool isfound = false;
        private bool isScrcpyRunning = false;
        private string additional = "";
        private string configPath = Application.StartupPath + @"\config.ini";
        public ConfigParser cfg;
        private Timer deviceCheckTimer, scrcpyStatusTimer;
        public Form1()
        {

            InitializeComponent();
            cfg = new ConfigParser(configPath);




        }

        public void InitializeDeviceCheckTimer()
        {
            deviceCheckTimer = new Timer();
            deviceCheckTimer.Interval = 1000; // Set the interval in milliseconds (adjust as needed)
            deviceCheckTimer.Tick += async (sender, e) => await CheckForConnectedDevice();
            deviceCheckTimer.Start();
        }

        public void InitializeScrcpyStatusTimer()
        {
            scrcpyStatusTimer = new Timer();
            scrcpyStatusTimer.Interval = 1000; // Set the interval in milliseconds (adjust as needed)
            scrcpyStatusTimer.Tick += (sender, e) => CheckScrcpyStatus();
            scrcpyStatusTimer.Start();
        }

        private void DisposeDeviceCheckTimer()
        {

            deviceCheckTimer.Stop();
            deviceCheckTimer.Dispose();



        }
        private void DisposeScrcpyStatusTimer()
        {



            scrcpyStatusTimer.Stop();
            scrcpyStatusTimer.Dispose();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            scrcpyPath.Text = cfg.GetValue("Scrcpy", "Path", "C:\\Users");

            scrcpyVersion.Text = cfg.GetValue("Scrcpy", "Version", "scrcpy not found!");
            SetBlurStyle(cntrl: this, blurType: BlurType.Mica, designMode: Mode.DarkMode);



            InitializeDeviceCheckTimer();
            InitializeScrcpyStatusTimer();

        }

        private async Task CheckForConnectedDevice()
        {
            string command = $"\"{scrcpyPath.Text}adb.exe\" devices -l";
            string output = await RunCommandAsync("cmd.exe", $"/c {command}");

            if (output.Contains("model:"))
            {
                // Extract values
                string productValue = "";
                string modelValue = "";
                string androidVersionValue = "";

                foreach (string part in output.Split(' '))
                {
                    if (part.StartsWith("product:"))
                    {
                        productValue = part.Substring("product:".Length);
                    }
                    else if (part.StartsWith("model:"))
                    {
                        modelValue = part.Substring("model:".Length);
                    }
                }
                // Get Android version using 'adb shell getprop ro.build.version.release'
                androidVersionValue = await RunCommandAsync("cmd.exe", "/c \"" + scrcpyPath.Text + "adb.exe\" shell getprop ro.build.version.release");

                // Remove leading colons
                productValue = productValue.Replace(":", "");
                modelValue = modelValue.Replace(":", "");

                // Update the label with the extracted values
                UpdateLabel($"Model: {modelValue} ({productValue})\nAndroid Version: {androidVersionValue}");



                isfound = true;

            }
            else
            {
                UpdateLabel("No device found!");

                isfound = false;
            }




        }
        /*  private async Task RunCommandLoop()
          {



              while (true)
              {
                  string command = "\"" + scrcpyPath.Text + "adb.exe\" devices -l";

                  string output = await RunCommandAsync("cmd.exe", "/c " + command);
                  //   MessageBox.Show(output);

                  if (output.Contains("model:"))
                  {
                      // Extract values
                      string productValue = "";
                      string modelValue = "";
                      string androidVersionValue = "";

                      foreach (string part in output.Split(' '))
                      {
                          if (part.StartsWith("product:"))
                          {
                              productValue = part.Substring("product:".Length);
                          }
                          else if (part.StartsWith("model:"))
                          {
                              modelValue = part.Substring("model:".Length);
                          }
                      }
                      // Get Android version using 'adb shell getprop ro.build.version.release'
                      androidVersionValue = await RunCommandAsync("cmd.exe", "/c \"" + scrcpyPath.Text + "adb.exe\" shell getprop ro.build.version.release");

                      // Remove leading colons
                      productValue = productValue.Replace(":", "");
                      modelValue = modelValue.Replace(":", "");

                      // Update the label with the extracted values
                      UpdateLabel($"Model: {modelValue} ({productValue})\nAndroid Version: {androidVersionValue}");



                      isfound = true;
                  }
                  else
                  {
                      UpdateLabel("No device found!");

                      isfound = false;
                  }





                  // Sleep for a short duration before the next iteration
                  await Task.Delay(100);
              }
          }*/

        private async Task<string> RunCommandAsync(string fileName, string arguments)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = fileName;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();

                // Asynchronously read the standard output
                string result = await process.StandardOutput.ReadToEndAsync();

                process.WaitForExit();

                return result;
            }
        }


        // Update the label with the command output
        private void UpdateLabel(string output)
        {
            if (info.InvokeRequired)
            {
                info.Invoke(new Action<string>(UpdateLabel), output);
            }
            else
            {
                info.Text = output;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void CheckScrcpyStatus()
        {
            isScrcpyRunning = IsProcessRunning("scrcpy");

            if (isScrcpyRunning)
            {
                label2.Invoke(new Action(() => label2.Text = "Running..."));
                startLabel.Invoke(new Action(() => startLabel.Text = "On"));
                scrcpyPanel.Invoke(new Action(() => scrcpyPanel.Enabled = false));
                toggle.Invoke(new Action(() => toggle.Checked = true));
              
            }
            else
            {
                label2.Invoke(new Action(() => label2.Text = "Not Running"));
                startLabel.Invoke(new Action(() => startLabel.Text = "Off"));
                scrcpyPanel.Invoke(new Action(() => scrcpyPanel.Enabled = true));
                toggle.Invoke(new Action(() => toggle.Checked = false));
               

            }
        }

        
        private bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }

       

        private async void roundButton1_Click(object sender, EventArgs e)
        {

            var dlg = new FolderPicker();
            dlg.InputPath = cfg.GetValue("Scrcpy", "Path", "C:\\Users");
            if (dlg.ShowDialog() == true)
            {
                scrcpyPath.Text = dlg.ResultPath + "\\";


                string version = await RunCommandAsync("cmd.exe", "/c \"" + scrcpyPath.Text + "scrcpy.exe\" --xcrcpy");
                string result = "";

                if (version.Contains("scrcpy"))
                {
                    result = Regex.Replace(version, @"<https://github\.com/Genymobile/scrcpy>", "");

                }
                else
                {
                    result = "Scrcpy not found!";
                }
                scrcpyVersion.Text = result;

                cfg.SetValue("Scrcpy", "Path", scrcpyPath.Text);
                cfg.SetValue("Scrcpy", "Version", scrcpyVersion.Text);
                cfg.Save();



            }


        }

      

        private async void startBtn_Click(object sender, EventArgs e)
        {

            if (isfound)
            {


                if (isScrcpyRunning)
                {
                    await RunCommandAsync("cmd.exe", "/c " + "taskkill /IM scrcpy.exe /F");


                }
                else
                {
                    await RunCommandAsync("cmd.exe", "/c \"" + scrcpyPath.Text + "scrcpy.exe\" --no-power-on " + additional);


                }
            }

        }

       
        private void screenOff_CheckedChanged(object sender, EventArgs e)
        {
            if (screenOff.Checked)
            {
                additional += "--turn-screen-off ";
            }
            else
            {
                additional = additional.Replace("--turn-screen-off ", "");
            }
        }

        private void alwaysTop_CheckedChanged(object sender, EventArgs e)
        {
            if (alwaysTop.Checked)
            {
                additional += "--always-on-top ";
            }
            else
            {
                additional = additional.Replace("--always-on-top ", "");
            }
        }

        private void roundPanel7_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeScrcpyStatusTimer();
            DisposeDeviceCheckTimer();
        }

      
    }
}
