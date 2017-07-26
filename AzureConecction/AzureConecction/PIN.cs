using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureConecction
{
    public class PIN
    {
        int id;
        string latitud;
        string longitud;
        string label;
        string addres;
        string idstring;
        string url;
        [JsonProperty(PropertyName = "ID")]
        public int ID { get { return id; } set { id = value; } }
        [JsonProperty(PropertyName = "Latitud")]
        public string Latitud { get { return latitud; } set { latitud = value; } }
        [JsonProperty(PropertyName = "Longitud")]
        public string Longitud { get { return longitud; } set { longitud = value; } }
        [JsonProperty(PropertyName = "Label")]
        public string Label { get { return label; } set { label = value; } }
        [JsonProperty(PropertyName = "_Address")]
        public string _Address { get { return addres; } set { addres = value; } }
        [JsonProperty(PropertyName = "IdString")]
        public string IdString { get { return idstring; } set { idstring = value; } }
        [JsonProperty(PropertyName = "Url")]
        public string Url { get { return url; } set { url = value; } }

        [Version]
        public string Version { get; set; }
    }
}
