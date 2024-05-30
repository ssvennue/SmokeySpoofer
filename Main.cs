using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmokeySpoofer
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void DeleteDirectory(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    console.AppendText($"\nFound & Deleted -> {path}");
                }
            } catch { }
        }
        private static Random rnd = new Random();
        static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                sb.Append(chars[rnd.Next(chars.Length)]);
            }
            return sb.ToString();
        }
        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Clean Traces
        {
            try
            {
                console.Clear();
                console.AppendText("Scanning Local System.. Please Wait!");
                // Blizzard/Battle.net
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Blizzard Entertainment"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Battle.net"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Battle.net"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Blizzard Entertainment"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache\\data_0.dcache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache\\data_1.dcache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache\\data_2.dcache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache\\data_3.dcache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache\\f_000001.dcache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache\\index.dcache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\Cache\\index"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache\\data_0"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache\\data_1"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache\\data_2"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache\\data_3"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache\\f_000001"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\GPUCache\\index"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\Cache\\index.dcache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\Cache\\data_0.dcache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\Cache\\data_1.dcache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\Cache\\data_2.dcache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\Cache\\data_3.dcache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\Cache\\data_0"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\Cache\\data_1"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\Cache\\data_2"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\BrowserCache\\Cache\\data_3"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\Cache"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\Logs"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\WidevineCdm"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Battle.net\\CachedData"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Blizzard Entertainment"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Roaming\\Battle.net"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Battle.net"));
                DeleteDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Blizzard Entertainment"));
                string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
                using (StreamWriter writer = new StreamWriter(tempFilename))
                {
                    // GTAV/FiveM
                    writer.WriteLine(@"echo off");
                    writer.WriteLine("cls");
                    writer.WriteLine("taskkill /f /im Steam.exe /t");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"set hostspath=%windir%\System32\drivers\etc\hosts");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\HardwareID / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\Store / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
                    writer.WriteLine("cls");
                    // (EAC) EasyAntiCheat
                    writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\EasyAntiCheat / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\EasyAntiCheat_EOS / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\EasyAntiCheat / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\EasyAntiCheat_EOS / f");
                    writer.WriteLine("cls");
                    writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\EasyAntiCheat\Security / f");
                    writer.WriteLine("cls");
                    // Fortnite
                    writer.WriteLine("taskkill /f /im epicgameslauncher.exe");
                    writer.WriteLine("taskkill /f /im EpicWebHelper.exe");
                    writer.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
                    writer.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
                    writer.WriteLine("taskkill /f /im FortniteLauncher.exe");
                    writer.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
                    writer.WriteLine("taskkill /f /im EpicGamesLauncher.exe");
                    writer.WriteLine("taskkill /f /im EasyAntiCheat.exe");
                    writer.WriteLine("taskkill /f /im BEService.exe");
                    writer.WriteLine("taskkill /f /im BEServices.exe");
                    writer.WriteLine("taskkill /f /im BattleEye.exe");
                    writer.WriteLine("taskkill /f /im x64dbg.exe");
                    writer.WriteLine("taskkill /f /im x32dbg.exe");
                    writer.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
                    writer.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
                    writer.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
                    writer.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
                    writer.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
                    writer.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
                    writer.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
                    writer.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
                    writer.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
                    writer.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
                    writer.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
                    writer.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
                    writer.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
                    writer.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
                    writer.WriteLine("reg delete \"HKEY_USERS\\" + WindowsIdentity.GetCurrent().User.Value + "\\Software\\Epic Games\" /f");
                }
                Process process = Process.Start(tempFilename);
                process.WaitForExit();
                File.Delete(tempFilename);
                console.AppendText("\nAll Traces Have Been Deleted If Any Were Found!");
            }
            catch 
            {
                console.Clear();
                console.AppendText("Clean Traces Failed.. Please Try Again and or Run as Admin!");
            }
        }

        private void button3_Click(object sender, EventArgs e) // List HWIDs
        {
            try
            {
                console.Clear();
                console.AppendText("Scanning Local System.. Please Wait!\n");
                // Windows Profile GUID/HWID
                console.AppendText($"\nHWID Found -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001", "HwProfileGuid", null).ToString().Replace("{", "").Replace("}", "")}");
                // Windows PC/Machine GUID/HWID
                console.AppendText($"\nHWID Found -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography", "MachineGuid", null)}");
                // Windows PC/Machine ID/HWID
                console.AppendText($"\nHWID Found -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\SQMClient", "MachineId", null).ToString().Replace("{", "").Replace("}", "")}");
                // Windows Product ID/HWID
                console.AppendText($"\nHWID Found -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductID", null)}");
                // Windows Update GUID/HWID
                console.AppendText($"\nHWID Found -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate", "SusClientId", null).ToString()}");
                // Windows PC/Machine Hardware IDs
                console.AppendText($"\nHWID Found -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\SystemInformation", "ComputerHardwareId", null).ToString().Replace("{", "").Replace("}", "")}");
                string[] HardwareIds = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\SystemInformation", "ComputerHardwareIds", new string[0]) as string[];
                StringBuilder Builder = new StringBuilder();
                foreach (string HardwareId in HardwareIds)
                {
                    string FormattedId = $"HWID Found -> {HardwareId.Trim().Replace("{", "").Replace("}", "")}";
                    Builder.AppendLine(FormattedId);
                }
                console.AppendText("\n" + Builder.ToString());
                // TODO: Add Hard Drive/SSD HWIDs
                console.AppendText("\nAll HWIDs that have been Found have been Listed!");
            }
            catch 
            {
                console.Clear();
                console.AppendText("Listing HWIDs Failed.. Please Try Again and or Run as Admin!");
            }
        }

        private void button4_Click(object sender, EventArgs e) // Spoof HWIDs
        {
            try
            {
                console.Clear();
                console.AppendText("Scanning Local System.. Please Wait!\n");
                // Windows Profile GUID/HWID
                console.AppendText($"\nHWID Found -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001", "HwProfileGuid", null).ToString().Replace("{", "").Replace("}", "")} - Spoofing..");
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001", "HwProfileGuid", "{" + $"{RandomString(8)}-{RandomString(4)}-{RandomString(4)}-{RandomString(4)}-{RandomString(12)}" + "}");
                console.AppendText($"\nNew HWID -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001", "HwProfileGuid", null).ToString().Replace("{", "").Replace("}", "")} - Spoofed!\n");
                // Windows PC/Machine GUID/HWID
                console.AppendText($"\nHWID Found -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography", "MachineGuid", null)} - Spoofing..");
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography", "MachineGuid", $"{RandomString(8)}-{RandomString(4)}-{RandomString(4)}-{RandomString(4)}-{RandomString(12)}");
                console.AppendText($"\nNew HWID -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography", "MachineGuid", null)} - Spoofed!\n");
                // Windows PC/Machine ID/HWID
                console.AppendText($"\nHWID Found -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\SQMClient", "MachineId", null).ToString().Replace("{", "").Replace("}", "")} - Spoofing..");
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\SQMClient", "MachineId", "{" + $"{RandomString(8)}-{RandomString(4)}-{RandomString(4)}-{RandomString(4)}-{RandomString(12)}" + "}");
                console.AppendText($"\nNew HWID -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\SQMClient", "MachineId", null).ToString().Replace("{", "").Replace("}", "")} - Spoofed!\n");
                // Windows Product ID/HWID
                console.AppendText($"\nHWID Found -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductID", null)} - Spoofing..");
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductID", $"{RandomString(5)}-{RandomString(5)}-{RandomString(5)}-{RandomString(5)}");
                console.AppendText($"\nNew HWID -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductID", null)} - Spoofed!\n");
                // Windows Update GUID/HWID
                console.AppendText($"\nHWID Found -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate", "SusClientId", null).ToString()} - Spoofing..");
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate", "SusClientId", $"{RandomString(8)}-{RandomString(4)}-{RandomString(4)}-{RandomString(4)}-{RandomString(12)}");
                console.AppendText($"\nNew HWID -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate", "SusClientId", null).ToString()} - Spoofed!\n");
                // Windows PC/Machine Hardware IDs
                console.AppendText($"\nHWID Found -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\SystemInformation", "ComputerHardwareId", null).ToString().Replace("{", "").Replace("}", "")} - Spoofing..");
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\SystemInformation", "ComputerHardwareId", "{" + $"{RandomString(8)}-{RandomString(4)}-{RandomString(4)}-{RandomString(4)}-{RandomString(12)}" + "}");
                console.AppendText($"\nNew HWID -> {Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\SystemInformation", "ComputerHardwareId", null).ToString().Replace("{", "").Replace("}", "")} - Spoofed!\n");          
                // List all the Hardware IDs/HWIDs
                string[] HardwareIds1 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\SystemInformation", "ComputerHardwareIds", new string[0]) as string[];
                StringBuilder Builder = new StringBuilder();
                foreach (string HardwareId1 in HardwareIds1)
                {
                    string FormattedId = $"HWID Found -> {HardwareId1.Trim().Replace("{", "").Replace("}", "")} - Spoofing..";
                    Builder.AppendLine(FormattedId);
                }
                console.AppendText("\n" + Builder.ToString());
                // Spoof the IDs/HWIDs we Found
                string[] hardwareIds = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\SystemInformation", "ComputerHardwareIds", new string[0]) as string[];
                if (hardwareIds != null)
                {
                    for (int i = 0; i < hardwareIds.Length; i++)
                    {
                        hardwareIds[i] = "{" + $"{RandomString(8)}-{RandomString(4)}-{RandomString(4)}-{RandomString(4)}-{RandomString(12)}" + "}";
                    }
                    Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\SystemInformation", "ComputerHardwareIds", hardwareIds, RegistryValueKind.MultiString);
                }
                // ReList all the Hardware IDs/HWIDs that are now Spoofed!
                string[] HardwareIds2 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\SystemInformation", "ComputerHardwareIds", new string[0]) as string[];
                StringBuilder Builder2 = new StringBuilder();
                foreach (string HardwareId3 in HardwareIds2)
                {
                    string FormattedId = $"New HWID -> {HardwareId3.Trim().Replace("{", "").Replace("}", "")} - Spoofed!";
                    Builder2.AppendLine(FormattedId);
                }
                console.AppendText("\n" + Builder2.ToString());
                console.AppendText("\nAll HWIDs that have been Found have been Spoofed!");
            }
            catch
            {
                console.Clear();
                console.AppendText("Spoof HWIDs Failed.. Please Try Again and or Run as Admin!");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Proxy IP
        {
            try
            {
                console.Clear();
                console.AppendText("Coming Soon!");

            }
            catch
            {
                console.Clear();
                console.AppendText("Proxy IP Failed.. Please Try Again and or Run as Admin!");
            }
        }
    }
}
