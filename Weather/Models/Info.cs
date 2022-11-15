using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class Info
    {
        /// <summary>
        /// lat	Широта (в градусах).
        /// lon Долгота(в градусах)
        /// url Страница населенного пункта на сайте Яндекс.Погода.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lat")]
        public float lat { get; set;}

        [Newtonsoft.Json.JsonProperty("lon")]
        public float lon { get; set;}

        [Newtonsoft.Json.JsonProperty("url")]
        public string url { get; set;}
    }
}
