using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamdeck
{
    public class PanelManager
    {
        private RootObject rootObject;
        private Dictionary<string, Key> keyMappings;

        public PanelManager()
        {
            LoadConfig();
        }

        // Load the configuration from JSON and map keys to their configurations
        public void LoadConfig()
        {
            string json = File.ReadAllText("options.json");
            rootObject = JsonConvert.DeserializeObject<RootObject>(json);

            // Create a dictionary for fast key access
            keyMappings = new Dictionary<string, Key>
        {
            { "0", rootObject.panels[0].key0 },
            { "1", rootObject.panels[0].key1 },
            { "2", rootObject.panels[0].key2 },
            { "3", rootObject.panels[0].key3 },
            { "4", rootObject.panels[0].key4 },
            { "5", rootObject.panels[0].key5 },
            { "6", rootObject.panels[0].key6 },
            { "7", rootObject.panels[0].key7 },
            { "8", rootObject.panels[0].key8 },
            { "9", rootObject.panels[0].key9 },
            { "A", rootObject.panels[0].keyA },
            { "B", rootObject.panels[0].keyB },
            { "C", rootObject.panels[0].keyC },
            { "D", rootObject.panels[0].keyD },
            { "star", rootObject.panels[0].keystar },
            { "hashtag", rootObject.panels[0].keyhashtag }
            };
        }

        // Populate the panel with the key's data when a button is clicked
        public void PopulatePanel(Panel panel, string key)
        {
            if (keyMappings.TryGetValue(key, out var keyData))
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        if (textBox.Name.Contains("textBoxName"))
                        {
                            textBox.Text = keyData.name;
                        }
                        else if (textBox.Name.Contains("textBoxConfig"))
                        {
                            textBox.Text = keyData.functions.playsound; // Example, adjust for different functions
                        }
                    }
                }
            }
        }

        // Save the options from the panel back into the key's configuration
        public void SaveOptions(Panel panel, string key)
        {
            if (keyMappings.TryGetValue(key, out var keyData))
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        if (textBox.Name.Contains("textBoxName"))
                        {
                            keyData.name = textBox.Text;
                        }
                        else if (textBox.Name.Contains("textBoxConfig"))
                        {
                            keyData.functions.playsound = textBox.Text; // Adjust for different functions
                        }
                    }
                }
                SaveConfig();
            }
        }

        // Save the updated configurations back to the JSON file
        private void SaveConfig()
        {
            string json = JsonConvert.SerializeObject(rootObject, Formatting.Indented);
            File.WriteAllText("options.json", json);
        }
    }
}
