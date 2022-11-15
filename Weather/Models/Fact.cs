using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Weather
{
    /// <summary>
    /// Объект содержит информацию о погоде на данный момент.

    /// </summary>
    internal class Fact
    {

       [Newtonsoft.Json.JsonProperty("temp")]
        public float temp { get; set; }

        [Newtonsoft.Json.JsonProperty("feels_like")]
        public float feels_like { get; set; }

        //[Newtonsoft.Json.JsonProperty("temp_water")]
        //public float temp_water { get; set; }

        [Newtonsoft.Json.JsonProperty("icon")]
        public string icon { get; set; }

        [Newtonsoft.Json.JsonProperty("condition")]
        public string condition { get; set; }

        [Newtonsoft.Json.JsonProperty("wind_speed")]
        public float wind_speed { get; set; }

        //[Newtonsoft.Json.JsonProperty("wind_qust")]
        //public float wind_qust { get; set; }
        [Newtonsoft.Json.JsonProperty("wind_dir")]
        public string wind_dir { get; set; }

        [Newtonsoft.Json.JsonProperty("pressure_mm")]
        public float pressure_mm { get; set; }

        [Newtonsoft.Json.JsonProperty("pressure_pa")]
        public float pressure_pa { get; set; }

        [Newtonsoft.Json.JsonProperty("humidity")]
        public float humidity { get; set; }
        [Newtonsoft.Json.JsonProperty("daytime")]
        public string daytime { get; set; }

        [Newtonsoft.Json.JsonProperty("polar")]
        public bool polar { get; set; }

        [Newtonsoft.Json.JsonProperty("season")]
        public string season { get; set; }

        [Newtonsoft.Json.JsonProperty("obs_time")]
        public float obs_time { get; set; }

        //[Newtonsoft.Json.JsonProperty("accum_prec")]
        //public float accum_prec { get; set; }
    }
}
