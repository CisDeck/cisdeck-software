using System;
using System.IO;
using System.IO.Ports;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using NAudio.Wave;  // For audio playback with NAudio
using System.Linq;
using System.Diagnostics;
using System.Management;
using System.Windows;
using System.ComponentModel;
using System.Windows.Forms.VisualStyles;

namespace Streamdeck
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private string[] Programs = new string[4];
        private string[] Sounds = new string[4];
        private string star;
        private bool connected = false;
        private Thread serialThread; // Separate thread for serial communication
        private int timeLeftToCheck;

        public Form1()
        {
            InitializeComponent();
            LoadOptions();
            ConnectToArduino();
            timeLeftToCheck = 30;
            timer1.Start();
        }

        private void LoadOptions()
        {
            // Load options from the file, or create new if not found
            if (File.Exists("options.txt"))
            {
                string[] lines = File.ReadAllLines("options.txt");
                for (int i = 0; i < 4; i++)
                {
                    Programs[i] = lines[i];
                    Sounds[i] = lines[i + 4];
                }
                UpdateUI();
            }
            else
            {
                File.WriteAllLines("options.txt", new string[8]); // Create default file with empty lines
            }
        }

        private void UpdateUI()
        {
            textBoxA.Text = Programs[0];
            textBoxB.Text = Programs[1];
            textBoxC.Text = Programs[2];
            textBoxD.Text = Programs[3];
            textBoxSound1.Text = Sounds[0];
            textBoxSound2.Text = Sounds[1];
            textBoxSound3.Text = Sounds[2];
            textBoxSound4.Text = Sounds[3];
            starScriptBox.Text = star;
        }

        private void SaveOptions()
        {
            Programs[0] = textBoxA.Text;
            Programs[1] = textBoxB.Text;
            Programs[2] = textBoxC.Text;
            Programs[3] = textBoxD.Text;
            Sounds[0] = textBoxSound1.Text;
            Sounds[1] = textBoxSound2.Text;
            Sounds[2] = textBoxSound3.Text;
            Sounds[3] = textBoxSound4.Text;
            star = starScriptBox.Text;

            File.WriteAllLines("options.txt", Programs);
            File.AppendAllLines("options.txt", Sounds);
            File.AppendAllText("options.txt", star);
        }

        private void ConnectToArduino()
        {
            string port = FindArduinoPort();
            Debug.WriteLine("Port: " + port);
            if (textBoxPort != null && textBoxPort.Text != "")
            {
                port = textBoxPort.Text;
            }
            try
            {
                serialPort = new SerialPort(port, 9600);
                serialPort.Open();
                connected = true;

                // Start a new thread for handling serial communication
                serialThread = new Thread(SerialPortReadLoop);
                serialThread.IsBackground = true;
                serialThread.Start();
                connectedLabel.Text = "Connected";
                connectedLabel.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                try
                {
                    serialPort.Close();
                }
                catch
                {
                    Debug.WriteLine(ex);
                }
                connectedLabel.Text = "Unconnected";
                connectedLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void SerialPortReadLoop()
        {
            while (connected)
            {
                try
                {
                    string input = serialPort.ReadLine(); // Read full line from serial port
                    this.Invoke(new MethodInvoker(() =>
                    {
                        ProcessSerialInput(input);
                    }));
                }
                catch (Exception ex)
                {
                    // Handle exceptions like port closure or read errors
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void ProcessSerialInput(string input)
        {

            input = input.Trim(); // Remove unnecessary whitespace
            if (input.Contains("*"))
            {
                ScriptHandler.Execute(star);
            }
            else if (input.Contains("#"))
            {
                Console.WriteLine("#");
            }
            else if (input == "A" || input == "B" || input == "C" || input == "D")
            {
                int index = Array.IndexOf(new string[] { "A", "B", "C", "D" }, input);
                if (index >= 0)
                {
                    LaunchProgram(Programs[index]);
                }
            }
            else if ((int.Parse(input) -1) >= 0 && (int.Parse(input) - 1) < 9)
            {
                int index = int.Parse(input) - 1;
                PlaySound(Sounds[index]);
            }
        }

        private void LaunchProgram(string programName)
        {
            MessageBox.Show(programName);
            try
            {
                var app = System.Diagnostics.Process.Start(programName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching program: " + ex.Message);
            }
        }

        private void PlaySound(string filePath)
        {
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

        private string FindArduinoPort()
        {
            string port = "";
            List<string> ports = SerialPort.GetPortNames().ToList();
            foreach (string p in ports)
            {
                port = p;
            }


            return port;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            SaveOptions();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            connected = false; // Stop serial communication loop
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void browseButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxSound1.Text = fdlg.FileName;
            }
        }

        private void browseButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxSound2.Text = fdlg.FileName;
            }
        }

        private void browseButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxSound3.Text = fdlg.FileName;
            }
        }

        private void browseButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxSound4.Text = fdlg.FileName;
            }
        }

        private void browseButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxSound5.Text = fdlg.FileName;
            }
        }

        private void browseButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxSound6.Text = fdlg.FileName;
            }
        }

        private void browseButton7_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxSound7.Text = fdlg.FileName;
            }
        }

        private void browseButton8_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxSound8.Text = fdlg.FileName;
            }
        }

        private void browseButton9_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxSound9.Text = fdlg.FileName;
            }
        }

        private void browseProgramButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxA.Text = fdlg.FileName;
            }
        }

        private void browseProgramButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxB.Text = fdlg.FileName;
            }
        }

        private void browseProgramButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxC.Text = fdlg.FileName;
            }
        }

        private void browseProgramButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxD.Text = fdlg.FileName;
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ConnectToArduino();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeftToCheck > 0)
            {
                timeLeftToCheck = timeLeftToCheck - 1;
            } else
            {
                if (connectedLabel.Text == "Unconnected")
                {
                    ConnectToArduino();
                }
                else
                {
                    if (!serialPort.IsOpen)
                    {
                        connectedLabel.Text = "Unconnected";
                        connectedLabel.ForeColor = System.Drawing.Color.Red;
                    }
                }
                timeLeftToCheck = 30;
            }
        }
    }

}
