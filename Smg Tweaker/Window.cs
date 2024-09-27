using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smg_Tweaker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ugethelp_Click(object sender, EventArgs e)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("powershell",
                "Get-AppxPackage *Microsoft.GetHelp* | Remove-AppxPackage");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
                else
                {
                    MessageBox.Show("Get Help Removed");
                }
            }
        }

        private void utips_Click(object sender, EventArgs e)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("powershell",
                "Get-AppxPackage *Microsoft.Getstarted* | Remove-AppxPackage");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
                else
                {
                    MessageBox.Show("Tips Removed");
                }
            }
        }

        private void u3d_Click(object sender, EventArgs e)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("powershell",
                "Get-AppxPackage *Microsoft.Microsoft3DViewer* | Remove-AppxPackage");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.Verb = "runas"; 

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
                else
                {
                    MessageBox.Show("3D Viewer Removed");
                }
            }
        }

        private void umaps_Click(object sender, EventArgs e)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("powershell",
                "Get-AppxPackage *Microsoft.WindowsMaps* | Remove-AppxPackage");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.Verb = "runas"; 

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
                else
                {
                    MessageBox.Show("Maps Removed");
                }
            }
        }

        private void ufeedback_Click(object sender, EventArgs e)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("powershell",
                "Get-AppxPackage *Microsoft.WindowsFeedbackHub* | Remove-AppxPackage");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.Verb = "runas"; 

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
                else
                {
                    MessageBox.Show("FeedBack Hub Removed");
                }
            }
        }

        private void uphone_Click(object sender, EventArgs e)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("powershell",
                "Get-AppxPackage *Microsoft.YourPhone* | Remove-AppxPackage");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.Verb = "runas"; 

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
                else
                {
                    MessageBox.Show("Phone Link Removed");
                }
            }
        }

        private void uonedrive_Click(object sender, EventArgs e)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("powershell",
                "Get-AppxPackage *Microsoft.OneDrive* | Remove-AppxPackage");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.Verb = "runas"; 

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
                else
                {
                    MessageBox.Show("OneDrive Removed");
                }
            }
        }

        private void ucompanion_Click(object sender, EventArgs e)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("powershell",
                "Get-AppxPackage *Microsoft.XboxApp* | Remove-AppxPackage");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.Verb = "runas"; 

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
                else
                {
                    MessageBox.Show("Xbox Companion Removed");
                }
            }
        }

        private void umixreal_Click(object sender, EventArgs e)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("powershell",
                "Get-AppxPackage *Microsoft.MixedReality* | Remove-AppxPackage");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.Verb = "runas"; 

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error " + error);
                }
                else
                {
                    MessageBox.Show("Mixed Reality Removed");
                }
            }
        }

        private void up3d_Click(object sender, EventArgs e)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("powershell",
                "Get-AppxPackage *Microsoft.Paint3D* | Remove-AppxPackage");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.Verb = "runas"; 

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
                else
                {
                    MessageBox.Show("Paint3D Removed");
                }
            }
        }

        private void uonenote_Click(object sender, EventArgs e)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("powershell",
                "Get-AppxPackage *Microsoft.Office.Onenote* | Remove-AppxPackage");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.Verb = "runas"; 

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
                else
                {
                    MessageBox.Show("OneNote Removed");
                }
            }
        }

        private void uweather_Click(object sender, EventArgs e)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("powershell",
                "Get-AppxPackage *Microsoft.BingWeather* | Remove-AppxPackage");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.Verb = "runas"; 

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
                else
                {
                    MessageBox.Show("Weather Removed");
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);

                if (key != null)
                {
                    key.SetValue("TaskbarSmallIcons", 1, RegistryValueKind.DWord);
                    key.Close();

                    RestartExplorer();
                    MessageBox.Show("Small taskbar buttons are enabled");
                }
                else
                {
                    MessageBox.Show("Failed to open regedit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void RestartExplorer()
        {
            foreach (var process in Process.GetProcessesByName("explorer"))
            {
                process.Kill();
            }

            Process.Start("explorer.exe");
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void combine1_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);

                if (key != null)
                {
                    key.SetValue("TaskbarGlomLevel", 0, RegistryValueKind.DWord); 
                    key.Close();

                    RestartExplorer();
                    MessageBox.Show("Combine 1 Enabled");
                }
                else
                {
                    MessageBox.Show("Failed to open regedit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void combine2_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);

                if (key != null)
                {
                    key.SetValue("TaskbarGlomLevel", 1, RegistryValueKind.DWord); 
                    key.Close();

                    RestartExplorer();
                    MessageBox.Show("Combine 2 Enabled");
                }
                else
                {
                    MessageBox.Show("Failed to open regedit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void combine3_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);

                if (key != null)
                {
                    key.SetValue("TaskbarGlomLevel", 2, RegistryValueKind.DWord); 

                    key.Close();

                    RestartExplorer();
                    MessageBox.Show("Combine 3 Enabled");
                }
                else
                {
                    MessageBox.Show("Failed to open regedit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Smg Tweaker 10 , Version:1.0 , By:weapon_smg1",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}
