using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public void LoadConfig()
        {
            string json = File.ReadAllText("options.json");
            rootObject = JsonConvert.DeserializeObject<RootObject>(json);

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

        public void PopulatePanel(Panel panel, string key, string function)
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
                            switch (function)
                            {
                                case "playsound":
                                    textBox.Text = keyData.functions.playsound;
                                    break;
                                case "launch":
                                    textBox.Text = keyData.functions.launch;
                                    break;
                                case "openwebsite":
                                    textBox.Text = keyData.functions.openWebsite;
                                    break;
                                case "triggerhotkey":
                                    textBox.Text = keyData.functions.triggerhotkey;
                                    break;
                                case "adjustvolume":
                                    textBox.Text = keyData.functions.adjustvolume;
                                    break;
                            }
                        }
                    }
                }
            }
        }

        public void SaveOptions(Panel panel, string key, string function)
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
                            switch(function)
                            {
                                case "playsound":
                                    keyData.functions.playsound = textBox.Text;
                                    break;
                                case "launch":
                                    keyData.functions.launch = textBox.Text;
                                    break;
                                case "openwebsite":
                                    keyData.functions.openWebsite = textBox.Text;
                                    break;
                                case "triggerhotkey":
                                    keyData.functions.triggerhotkey = textBox.Text;
                                    break;
                                case "adjustvolume":
                                    keyData.functions.adjustvolume = textBox.Text;
                                    break;
                            }
                        }
                    }
                }
                keyData.chosenFunction = function;

                SaveConfig();
            }
        }

        public void SaveConfig()
        {
            string json = JsonConvert.SerializeObject(rootObject, Formatting.Indented);
            File.WriteAllText("options.json", json);
        }

        public string GetValue(string key, string function)
        {
            string value = "";
            if (keyMappings.TryGetValue(key, out var keyData))
            {
                switch(function)
                {
                    case "playsound":
                        value = keyData.functions.playsound;
                        break;
                    case "launch":
                        value = keyData.functions.launch;
                        break;
                    case "openwebsite":
                        value = keyData.functions.openWebsite;
                        break;
                    case "triggerhotkey":
                        value = keyData.functions.triggerhotkey;
                        break;
                    case "adjustvolume":
                        value = keyData.functions.adjustvolume;
                        break;
                }
            }
            return value;
        }

        public string GetFunction(string key)
        {
            string function = "";
            if (keyMappings.TryGetValue(key, out var keyData))
            {
                function = keyData.chosenFunction;
            }
            return function;
        }

    }
}
