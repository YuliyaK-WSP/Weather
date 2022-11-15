using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class WeatherResponse
    {
        [Newtonsoft.Json.JsonProperty("now")]
        public float now { get; set; }

        [Newtonsoft.Json.JsonProperty("now_dt")]
        public string now_dt { get; set; }

        [Newtonsoft.Json.JsonProperty("info")]
        public Info info { get; set; }

        [Newtonsoft.Json.JsonProperty("fact")]
        public Fact fact { get; set; }

        //[Newtonsoft.Json.JsonProperty("forecast")]
        //public Forecast forecast { get; set; }

        public WeatherResponse()
        {
            info = new Info();
            fact = new Fact();
            //forecast = new Forecast();
        }
    }
}
