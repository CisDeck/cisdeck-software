using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Streamdeck
{
    public partial class HotkeyLogic : Form
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int HOTKEY_ID = 1;

        public event EventHandler HotkeyPressed;

        public void triggerHotkey(string hotkey)
        {
            string[] parts = hotkey.Split('+');
            uint modifier = 0;
            uint key = 0;

            foreach (string part in parts)
            {
                string trimmedPart = part.Trim().ToUpper();

                switch (trimmedPart)
                {
                    case "CTRL":
                        modifier |= 0x0002;
                        break;
                    case "ALT":
                        modifier |= 0x0001;
                        break;
                    case "SHIFT":
                        modifier |= 0x0004;
                        break;
                    case "WIN":
                        modifier |= 0x0008;
                        break;
                    default:
                        try
                        {
                            key = (uint)(Keys)Enum.Parse(typeof(Keys), trimmedPart);
                        }
                        catch
                        {
                            MessageBox.Show($"Ungültige Taste: {trimmedPart}");
                            return;
                        }
                        break;
                }
            }

            UnregisterHotKey(this.Handle, HOTKEY_ID); // Vorherige Hotkey abmelden
            if (key != 0)
            {
                RegisterHotKey(this.Handle, HOTKEY_ID, modifier, key); // Hotkey registrieren
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                HotkeyPressed?.Invoke(this, EventArgs.Empty);
            }
            base.WndProc(ref m);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            base.OnFormClosing(e);
        }
    }
}