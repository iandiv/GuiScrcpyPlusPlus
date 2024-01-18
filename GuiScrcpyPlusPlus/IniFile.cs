using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xcrcpy
{

    public class IniFile
    {
        private string filePath;

        public IniFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Path cannot be empty or whitespace.", nameof(path));
            }

            this.filePath = path;
            EnsureFileExists();
        }

        private void EnsureFileExists()
        {
            if (!File.Exists(this.filePath))
            {
                // Create the directory if it doesn't exist
                string directoryPath = Path.GetDirectoryName(this.filePath);

                if (!string.IsNullOrWhiteSpace(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);

                    // Create the INI file with a basic structure
                    File.WriteAllText(this.filePath, "; This is a sample INI file\n[DefaultSection]\nKey1=Value1\n");
                }
            }
        }
        public string ReadValue(string section, string key, string defaultValue)
        {
            var stringBuilder = new System.Text.StringBuilder(255);
            NativeMethods.GetPrivateProfileString(section, key, defaultValue, stringBuilder, 255, this.filePath);
            return stringBuilder.ToString();
        }
        public void WriteValue(string section, string key, string value)
        {
            NativeMethods.WritePrivateProfileString(section, key, value, this.filePath);
        }

        private static class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
            internal static extern int GetPrivateProfileString(string section, string key, string defaultValue, System.Text.StringBuilder result, int size, string filePath);

            [System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
            internal static extern bool WritePrivateProfileString(string section, string key, string value, string filePath);
        }
    }

}
