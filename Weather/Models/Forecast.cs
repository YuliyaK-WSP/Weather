using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class Forecast
    {
        [Newtonsoft.Json.JsonProperty("date")]
        string date { get; set; }

        [Newtonsoft.Json.JsonProperty("date_ts")]
        float date_ts { get; set; }

        [Newtonsoft.Json.JsonProperty("week")]
        float week { get; set; }

        [Newtonsoft.Json.JsonProperty("sunrise")]
        string sunrise { get; set; }

        [Newtonsoft.Json.JsonProperty("sunset")]
        string sunset { get; set; }
        [Newtonsoft.Json.JsonProperty("moon_code")]
        float moon_code { get; set; }
        [Newtonsoft.Json.JsonProperty("moon_text")]
        string moon_text { get; set; }
        //[Newtonsoft.Json.JsonProperty("parts")]
        //Parts parts { get; set; }
        [Newtonsoft.Json.JsonProperty("part_name")]
        string part_name { get; set; }
        [Newtonsoft.Json.JsonProperty("temp_min")]
        float temp_min { get; set; }
        [Newtonsoft.Json.JsonProperty("temp_max")]
        float temp_max { get; set; }
        [Newtonsoft.Json.JsonProperty("temp_avg")]
        float temp_avg { get; set; }
        [Newtonsoft.Json.JsonProperty("feels_like")]
        float feels_like { get; set; }
        [Newtonsoft.Json.JsonProperty("icon")]
        string icon { get; set; }
        [Newtonsoft.Json.JsonProperty("condition")]
        string condition { get; set; }
        [Newtonsoft.Json.JsonProperty("daytime")]
        string daytime { get; set; }
        [Newtonsoft.Json.JsonProperty("polar")]
        bool polar { get; set; }
        [Newtonsoft.Json.JsonProperty("wind_speed")]
        float wind_speed { get; set; }
        [Newtonsoft.Json.JsonProperty("wind_gust")]
        float wind_gust { get; set; }
        [Newtonsoft.Json.JsonProperty("wind_dir")]
        string wind_dir { get; set; }
        [Newtonsoft.Json.JsonProperty("pressure_mm")]
        float pressure_mm { get; set; }
        [Newtonsoft.Json.JsonProperty("pressure_pa")]
        float pressure_pa { get; set; }
        [Newtonsoft.Json.JsonProperty("humidity")]
        float humidity { get; set; }
        [Newtonsoft.Json.JsonProperty("prec_mm")]
        float prec_mm { get; set; }
        [Newtonsoft.Json.JsonProperty("prec_period")]
        float prec_period { get; set; }
        [Newtonsoft.Json.JsonProperty("prec_prob")]
        float prec_prob { get; set; }


    }
}
