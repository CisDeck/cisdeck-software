using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamdeck
{
    public class Key
    {
        public string name { get; set; }
        public Functions functions { get; set; }
    }


    public class Functions
    {
        public string playsound { get; set; }
        public string launch { get; set; }
        public string openWebsite { get; set; }
    }


    public class Panels
    {
        [JsonProperty("key0")]
        public Key key0 { get; set; }

        [JsonProperty("key1")]
        public Key key1 { get; set; }

        [JsonProperty("key2")]
        public Key key2 { get; set; }

        [JsonProperty("key3")]
        public Key key3 { get; set; }

        [JsonProperty("key4")]
        public Key key4 { get; set; }

        [JsonProperty("key5")]
        public Key key5 { get; set; }

        [JsonProperty("key6")]
        public Key key6 { get; set; }

        [JsonProperty("key7")]
        public Key key7 { get; set; }

        [JsonProperty("key8")]
        public Key key8 { get; set; }

        [JsonProperty("key9")]
        public Key key9 { get; set; }

        [JsonProperty("keyA")]
        public Key keyA { get; set; }

        [JsonProperty("keyB")]
        public Key keyB { get; set; }

        [JsonProperty("keyC")]
        public Key keyC { get; set; }

        [JsonProperty("keyD")]
        public Key keyD { get; set; }

        [JsonProperty("keystar")]
        public Key keystar { get; set; }

        [JsonProperty("keyhashtag")]
        public Key keyhashtag { get; set; }
    }

    public class RootObject
    {
        public List<Panels> panels { get; set; }
    }
}
