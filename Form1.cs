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
using System.Drawing.Imaging;

namespace Streamdeck
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private string[] Programs = new string[4];
        private string[] Sounds = new string[9];
        private string[] Specials = new string[3];
        private bool connected = false;
        private Thread serialThread; // Separate thread for serial communication
        private int timeLeftToCheck;
        private Dictionary<PictureBox, Image> originalImages = new Dictionary<PictureBox, Image>();
        private Dictionary<PictureBox, Image> brightenedImages = new Dictionary<PictureBox, Image>();
        private Dictionary<PictureBox, Image> borderImages = new Dictionary<PictureBox, Image>();
        private Dictionary<PictureBox, Image> borderBrightenedImages = new Dictionary<PictureBox, Image>();
        private PictureBox clickedKey;

        public Form1()
        {
            InitializeComponent();
            LoadOptions();
            ConnectToArduino();
            timeLeftToCheck = 30;
            timer1.Start();
            File.Delete("options.txt");
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
                }
                for (int i = 0; i < 8; i++)
                {
                    Sounds[i] = lines[i + 4];
                }
                for (int i = 0; i < 3; i++)
                {
                    Specials[i] = lines[i + 12];
                }
                UpdateUI();
            }
            else
            {
                File.WriteAllLines("options.txt", new string[15]); // Create default file with empty lines
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
            textBoxSound5.Text = Sounds[4];
            textBoxSound6.Text = Sounds[5];
            textBoxSound7.Text = Sounds[6];
            textBoxSound8.Text = Sounds[7];
            textBoxSound9.Text = Sounds[8];
            starScriptBox.Text = Specials[0];
            hashtagScriptBox.Text = Specials[1];
            zeroScriptBox.Text = Specials[2];
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
            Sounds[4] = textBoxSound5.Text;
            Sounds[5] = textBoxSound6.Text;
            Sounds[6] = textBoxSound7.Text;
            Sounds[7] = textBoxSound8.Text;
            Sounds[8] = textBoxSound9.Text;
            Specials[0] = starScriptBox.Text;
            Specials[1] = hashtagScriptBox.Text;
            Specials[2] = zeroScriptBox.Text;


            File.WriteAllLines("options.txt", Programs);
            File.AppendAllLines("options.txt", Sounds);
            File.AppendAllLines("options.txt", Specials);
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
            if (input.Contains("*") || input.Contains("#") || input.Contains("0"))
            {
                int index = Array.IndexOf(new string[] { "*", "#", "0" }, input);
                if (index >= 0)
                {
                    ScriptHandler.Execute(Specials[index]);
                }
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
            else if ((int.Parse(input) - 1) >= 0 && (int.Parse(input) - 1) < 9)
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
            if (timeLeftToCheck > 0)
            {
                timeLeftToCheck = timeLeftToCheck - 1;
            }
            else
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

        private void numpad_1_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_1_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_1_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_2_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_2_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_2_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_3_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_3_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_3_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_4_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_4_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_4_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_5_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_5_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_5_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_6_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_6_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_6_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_7_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_7_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_7_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_8_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_8_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_8_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_9_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_9_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_9_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_0_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_0_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_0_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_star_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_star_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_star_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_hashtag_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_hashtag_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_hashtag_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_A_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_A_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_A_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_B_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_B_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_B_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_C_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_C_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_C_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private void numpad_D_hover(object sender, EventArgs e)
        {
            hoverNumpad(sender);
        }

        private void numpad_D_leave(object sender, EventArgs e)
        {
            leaveNumpad(sender);
        }

        private void numpad_D_Click(object sender, EventArgs e)
        {
            clickNumpad(sender);
        }

        private async void hoverNumpad(object sender)
        {
            PictureBox picBox = sender as PictureBox;
            if (picBox != null)
            {
                if (clickedKey == picBox)
                    picBox.Image = borderBrightenedImages[picBox];
                else
                    picBox.Image = brightenedImages[picBox];
            }
        }

        private async void leaveNumpad(object sender)
        {
            PictureBox picBox = sender as PictureBox;
            if (picBox != null)
            {
                if (clickedKey == picBox)
                    picBox.Image = borderImages[picBox];
                else
                    picBox.Image = originalImages[picBox];
            }
        }

        private void clickNumpad(object sender)
        {
            PictureBox picBox = sender as PictureBox;
            if (picBox != null)
            {
                picBox.Image = drawBorder(picBox);
                clickedKey = picBox;
            }
        }



        private Image AdjustGamma(Image image, float gammaFactor)
        {
            Bitmap temp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(temp))
            {
                // Create a color matrix and set the gamma
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetGamma(gammaFactor);

                // Draw the original image with the gamma adjustment
                g.DrawImage(image, new Rectangle(0, 0, temp.Width, temp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in GetAllControls(this))
            {
                PictureBox picBox = control as PictureBox;
                if (picBox != null && picBox.Image != null)
                {
                    originalImages[picBox] = picBox.Image;
                    brightenedImages[picBox] = AdjustGamma(picBox.Image, 1.5f);
                    borderImages[picBox] = drawBorder(picBox);
                    borderBrightenedImages[picBox] = AdjustGamma(borderImages[picBox], 1.5f);
                }
            }
        }

        private IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;

                // Recursively search through all child controls
                foreach (Control childControl in GetAllControls(control))
                {
                    yield return childControl;
                }
            }
        }

        private Image drawBorder(PictureBox picBox)
        {
            Bitmap temp = new Bitmap(picBox.Image.Width, picBox.Image.Height);
            using (Graphics g = Graphics.FromImage(temp))
            {
                g.DrawImage(picBox.Image, 0, 0);
                g.DrawRectangle(new Pen(Color.Blue, 4), 0, 0, picBox.Image.Width, picBox.Image.Height);
            }
            return temp;
        }
    }

}
