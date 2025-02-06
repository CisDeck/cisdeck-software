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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Text;
using System.Runtime.InteropServices;
using AudioSwitcher.AudioApi.CoreAudio;

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
        private PictureBox chosenKey;
        private string chosenFunction;
        private PanelManager panelManager = new PanelManager();
        private bool applyButtonActivated = false;
        string functionOfChosenKey = "";
        private HotkeyLogic hotkeyLogic;

        public Form1()
        {
            InitializeComponent();
            ConnectToArduino();
            timeLeftToCheck = 30;
            timer1.Start();
            File.Delete("options.txt");
            if (functionsList.Columns.Count == 0)
            {
                functionsList.Columns.Add(new ColumnHeader());  // Add an empty column
            }
            functionsList.OwnerDraw = true;
            functionsList.Columns[0].Width = 300;
            foreach (ListViewItem item in functionsList.Items)
            {
                item.BackColor = Color.FromArgb(40, 40, 40);
            }
            functionsList.Focus();
            functionsList.FullRowSelect = true;
            chosenFunction = "unknown";
            panelManager.PopulatePanel(reusablePanel, "0", chosenFunction);
            applyButton.BackColor = Color.Silver;
            hotkeyLogic = new HotkeyLogic();
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
            clickNumpad(numpad_0);
        }

        private void ConnectToArduino()
        {
            string port = FindArduinoPort();
            Debug.WriteLine("Port: " + port);

            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close(); // Close the port if it's already open
                    serialPort.Dispose();
                }

                serialPort = new SerialPort(port, 9600);
                serialPort.ReadTimeout = 1800000;
                serialPort.Open();
                connected = true;

                // Stop the previous thread if it's running
                if (serialThread != null && serialThread.IsAlive)
                {
                    connected = false; // Ensure the previous thread exits
                    serialThread.Join(); // Wait for the thread to finish
                }

                // Start a new thread for handling serial communication
                serialThread = new Thread(SerialPortReadLoop);
                serialThread.IsBackground = true;
                serialThread.Start();
                connectedLabel.Text = "Connected";
                connectedLabel.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close();
                    serialPort.Dispose();
                }

                Debug.WriteLine("Error: " + ex.Message);
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
                    Debug.WriteLine("Error: " + ex.Message);
                    connected = false; // Stop the loop if there's an error
                }
            }
        }

        private void ProcessSerialInput(string input)
        {
            input = input.Trim(); // Remove unnecessary whitespace
            Console.WriteLine(input);
            findCommand(input);
        }

        // Software

        private void findCommand(string key)
        {
            string chosenFunction = panelManager.GetFunction(key);
            switch (chosenFunction)
            {
                case "playsound":
                    PlaySound(panelManager.GetValue(key, chosenFunction));
                    break;
                case "launch":
                    LaunchProgram(panelManager.GetValue(key, chosenFunction));
                    break;
                case "openwebsite":
                    openWebsite(panelManager.GetValue(key, chosenFunction));
                    break;
                case "triggerhotkey":
                    triggerHotkey(panelManager.GetValue(key, chosenFunction));
                    break;
                case "adjustvolume":
                    adjustvolume(panelManager.GetValue(key, chosenFunction));
                    break;
            }

        }

        private void LaunchProgram(string programName)
        {
            try
            {
                var app = Process.Start(programName);
            }
            catch (Exception ex)
            {
                new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddText("Error: Program couldn't be launched.")
                    .AddText("Program: " + programName)
                    .Show();
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
                    new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddText("Error: Sound File not found.")
                    .AddText("Path: " + filePath)
                    .Show();
                }
            }
            catch (Exception ex)
            {
                new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddText("Error: Sound couldn't be played.")
                    .Show();
            }
        }

        private void openWebsite(string url)
        {
            try
            {
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = FormatURL(url, true),
                    UseShellExecute = true
                };
                Process.Start(psInfo);
            }
            catch (Exception ex)
            {
                new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddText("Error: Website couldn't be opened.")
                    .AddText("URL: " + url)
                    .Show();
            }
        }

        private void triggerHotkey(string hotkey)
        {
            var modifierMap = new Dictionary<string, string>
            {
                { "SHIFT", "+" },
                { "CTRL", "^" },
                { "ALT", "%" }
            };

            // Split the key combination into parts
            var parts = hotkey.Split(new[] { '+' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(p => p.Trim().ToUpper()).ToList();

            // Build the SendKeys-compatible string
            StringBuilder sendKeysString = new StringBuilder();

            foreach (var part in parts)
            {
                if (modifierMap.ContainsKey(part))
                {
                    // Append the modifier symbol
                    sendKeysString.Append(modifierMap[part]);
                }
                else
                {
                    // Add the actual key, wrap special keys in braces
                    if (part.Length > 1 || char.IsDigit(part[0]))
                    {
                        sendKeysString.Append($"{{{part}}}");
                    }
                    else
                    {
                        sendKeysString.Append(part);
                    }
                }
            }
            String sks = sendKeysString.ToString().ToLower();

            // Send the keystroke
            SendKeys.Send(sks);
            Debug.WriteLine(sks);
        }

        private void adjustvolume(string volumechangestr)
        {
            volumechangestr = volumechangestr.Replace(" ", "");
            double volumechange = Double.Parse(volumechangestr);
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            double currentvolume = defaultPlaybackDevice.Volume;
            defaultPlaybackDevice.Volume = currentvolume + volumechange;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (applyButtonActivated)
            {
                string currentKey = chosenKey.Tag.ToString(); // This would dynamically change based on the clicked key
                panelManager.SaveOptions(reusablePanel, currentKey, chosenFunction);
            }
        }

        private void applyButton_MouseMove(object sender, EventArgs e)
        {
            if (applyButtonActivated)
                Cursor.Current = Cursors.Hand;
            else
                Cursor.Current = Cursors.Default;
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

        private void connectButton_Click(object sender, EventArgs e)
        {
            ConnectToArduino();
        }

        private void textBoxConfig_MouseClick(object sender, EventArgs e)
        {

            if (chosenFunction != "openwebsite" && chosenFunction != "triggerhotkey" && chosenFunction != "adjustvolume")
            {
                TextBox textBox = sender as TextBox;
                OpenFileDialog fdlg = new OpenFileDialog();
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = fdlg.FileName;
                }
            }
            else if (chosenFunction == "triggerhotkey")
            {
                TextBox textBox = sender as TextBox;
                textBox.Clear();

                StringBuilder pressedKeys = new StringBuilder();
                bool keyCheckInProgress = true;

                this.KeyPreview = true;

                this.KeyDown += (s, keyEventArgs) =>
                {
                    string modifiers = "";
                    if (keyEventArgs.Shift && !pressedKeys.ToString().Contains("Shift"))
                    {
                        modifiers += "SHIFT + ";
                    }
                    if (keyEventArgs.Control && !pressedKeys.ToString().Contains("Ctrl"))
                    {
                        modifiers += "CTRL + ";
                    }
                    if (keyEventArgs.Alt && !pressedKeys.ToString().Contains("Alt"))
                    {
                        modifiers += "ALT + ";
                    }

                    if (keyEventArgs.KeyCode != Keys.ShiftKey && keyEventArgs.KeyCode != Keys.ControlKey && keyEventArgs.KeyCode != Keys.Menu)
                    {
                        pressedKeys.Append(modifiers + keyEventArgs.KeyCode.ToString() + " + ");
                    }
                };

                this.KeyUp += (s, keyEventArgs) =>
                {
                    if (keyCheckInProgress)
                    {
                        if (pressedKeys.Length > 0)
                        {
                            pressedKeys.Length -= 3;
                        }

                        textBox.Text = pressedKeys.ToString();
                        pressedKeys.Clear();
                        keyCheckInProgress = false;
                    }

                    this.KeyDown -= null;
                    this.KeyUp -= null;
                };
            }
        }

        private void textBoxConfig_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void textBoxConfig_TextChanged(object sender, EventArgs e)
        {
            if (chosenFunction == "adjustvolume")
            {
                TextBox textBox = sender as TextBox;

                string input = textBox.Text.Trim();
                if (input == "-") return;

                if (int.TryParse(input, out int value))
                {
                    value = Math.Max(-100, Math.Min(100, value));
                    textBox.Tag = value;
                }
                else
                {
                    textBox.Tag = null;
                }
            }
        }

        private void textBoxConfig_Leave(object sender, EventArgs e)
        {
            if (chosenFunction == "adjustvolume")
            {
                TextBox textBox = sender as TextBox;
                if (textBox.Tag != null && textBox.Tag is int value)
                {
                    textBox.Text = (value >= 0 ? "+ " : "- ") + Math.Abs(value).ToString();
                }
                else
                {
                    textBox.Text = "";
                }
            }
        }

        private void functionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionsList.Focus();

            if (functionsList.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in functionsList.Items)
                {
                    item.BackColor = Color.FromArgb(40, 40, 40); // Default color for unselected items
                }

                ListViewItem selectedItem;
                if (functionOfChosenKey != "" && sender == null && e == null)
                {
                    selectedItem = functionsList.Items
                        .Cast<ListViewItem>()
                        .FirstOrDefault(item => item.Tag?.ToString() == functionOfChosenKey);

                    if (selectedItem == null)
                    {
                        return;
                    }
                }
                else
                {
                    selectedItem = functionsList.SelectedItems[0];
                }

                selectedItem.BackColor = Color.FromArgb(23, 100, 186);
                chosenFunction = selectedItem.Text.Replace(" ", "").ToLower();
                functionLabel.Text = selectedItem.Text;
                panelManager.PopulatePanel(reusablePanel, chosenKey.Tag.ToString(), chosenFunction);
                if (!applyButtonActivated && chosenKey != null)
                {
                    applyButton.BackColor = Color.Gray;
                    applyButton.FlatStyle = FlatStyle.Standard;
                    applyButtonActivated = true;
                }
                if (chosenFunction == "triggerhotkey")
                {
                    textBoxConfig.PlaceholderText = "Press a key combination...";
                    label4.Text = "Key:";
                    label4.Location = new Point(132, 109);
                }
                else if (chosenFunction == "adjustvolume")
                {
                    textBoxConfig.PlaceholderText = "+ 5";
                    label4.Text = "Volume:";
                    label4.Location = new Point(123, 109);
                }
                else
                {
                    textBoxConfig.PlaceholderText = "";
                    label4.Text = "Path:";
                    label4.Location = new Point(132, 109);
                }
            }
            else
            {
                // Reset all item backgrounds if no item is selected
                foreach (ListViewItem item in functionsList.Items)
                {
                    item.BackColor = Color.FromArgb(40, 40, 40);
                }
            }
        }

        private void functionsList_MouseMove(object sender, MouseEventArgs e)
        {
            if (functionsList.ClientRectangle.Contains(e.Location))
            {
                Cursor.Current = Cursors.Hand;
            }
            else
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void functionsList_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = functionsList.HitTest(e.Location).Item;
            if (item != null)
            {
                item.Selected = true;
            }
        }

        private async void hoverNumpad(object sender)
        {
            PictureBox picBox = sender as PictureBox;
            if (picBox != null)
            {
                if (chosenKey == picBox)
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
                if (chosenKey == picBox)
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
                if (chosenKey != null)
                    chosenKey.Image = originalImages[chosenKey];
                picBox.Image = drawBorder(picBox);
                chosenKey = picBox;
                selectedKeyImage.Image = originalImages[chosenKey];
                if (!applyButtonActivated && chosenFunction != "unknown")
                {
                    applyButton.BackColor = Color.Gray;
                    applyButton.FlatStyle = FlatStyle.Standard;
                    applyButtonActivated = true;
                }
                if (panelManager.GetFunction(chosenKey.Tag.ToString()) != "")
                {
                    functionOfChosenKey = panelManager.GetFunction(chosenKey.Tag.ToString());
                    functionsList_SelectedIndexChanged(null, null);
                }
                else
                {
                    functionOfChosenKey = "";
                }
            }
            string key = picBox.Tag.ToString();

            // Load the appropriate panel for the clicked key
            panelManager.PopulatePanel(reusablePanel, key, chosenFunction);
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

        public static string FormatURL(string Url, bool IncludeHttp)
        {

            Url = Url.ToLower();

            switch (IncludeHttp)
            {
                case true:
                    if (!(Url.StartsWith("http://") || Url.StartsWith("https://")))
                        Url = "http://" + Url;
                    break;
                case false:
                    if (Url.StartsWith("http://"))
                        Url = Url.Remove(0, "http://".Length);
                    if (Url.StartsWith("https://"))
                        Url = Url.Remove(0, "https://".Length);
                    break;
            }

            return Url;

        }

        private Image AdjustGamma(Image image, float gammaFactor)
        {
            Bitmap temp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(temp))
            {
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetGamma(gammaFactor);

                g.DrawImage(image, new Rectangle(0, 0, temp.Width, temp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return temp;
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        public static void PressKey(Keys key, bool up)
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;
            if (up)
            {
                keybd_event((byte)key, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            }
            else
            {
                keybd_event((byte)key, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            }
        }

        private IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;

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

    }

}
