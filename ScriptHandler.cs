using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Streamdeck
{
    public class ScriptHandler
    {

        public static void Execute(string code)
        {
            //remove all newlines
            if(code == null)
            {
                return;
            }
            code = code.Replace("\n", "").Replace("\r", "");
            // replace all spaces if they are not inside a string
            bool insideString = false;
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '"')
                {
                    insideString = !insideString;
                }
                if (code[i] == ' ' && !insideString)
                {
                    code = code.Remove(i, 1).Insert(i, "");
                }
            }

            string[] commands = code.Split(';');
            foreach (string command in commands)
            {
                ExecuteCommand(command);
            }
        }

        public static void ExecuteCommand(string command)
        {
            try
            {
                if (command.StartsWith("volume["))
                {
                    AdjustVolume(command);
                }
                else if (command.StartsWith("playSound["))
                {
                    PlaySound(command);
                }
                else if (command.StartsWith("openProgram["))
                {
                    OpenProgram(command);
                }
                else if (command.StartsWith("keystroke["))
                {
                    SendKeystroke(command);
                }
                else if (command.StartsWith("openURL["))
                {
                    OpenURL(command);
                }
                else if (command.StartsWith("wait["))
                {
                    Wait(command);
                }
                else if (command.StartsWith("shutdown["))
                {
                    ShutdownSystem();
                }
                else
                {
                    MessageBox.Show("Unknown command: " + command);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private static void AdjustVolume(string command)
        {
            string volumeValue = command.Substring(7, command.Length - 8);
            float currentVolume = AudioManager.GetMasterVolume();
            float volumeChange = currentVolume + int.Parse(volumeValue);
            AudioManager.SetMasterVolume(volumeChange);
        }

        private static void PlaySound(string command)
        {
            string filePath = command.Substring(10, command.Length - 11);
            try
            {
                if (File.Exists(filePath))
                {
                    using (var audioFile = new AudioFileReader(filePath))
                    using (var outputDevice = new WaveOutEvent())
                    {
                        outputDevice.Init(audioFile);
                        outputDevice.Play();
                        while (outputDevice.PlaybackState == PlaybackState.Playing)
                        {
                            Thread.Sleep(500);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sound file not found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
        }

        private static void OpenProgram(string command)
        {
            string programPath = command.Substring(12, command.Length - 13);
            try
            {
                var app = System.Diagnostics.Process.Start(programPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching Program: " + ex);
            }
        }

        private static void SendKeystroke(string command)
        {
            string keyCombination = command.Substring(10, command.Length - 11);
            SendKeys.Send(keyCombination);
        }

        private static void OpenURL(string command)
        {
            string url = command.Substring(8, command.Length - 9);
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private static void Wait(string command)
        {
            string waitTime = command.Substring(5, command.Length - 6);
            int delay;
            if (int.TryParse(waitTime, out delay))
            {
                delay = delay * 1000;
                Thread.Sleep(delay);
            }
        }

        private static void ShutdownSystem()
        {
            Process.Start("shutdown", "/s /t 0");
        }
    }
}
