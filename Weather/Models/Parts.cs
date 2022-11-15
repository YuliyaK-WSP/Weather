using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class Parts
    {
        public string part_name { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public float temp_avg { get; set; }
        public float feels_like { get; set; }
        public string icon { get; set; }
        public string condition { get; set; }
        public string daytime { get; set; }
        public bool polar { get; set; }
        public float wind_speed { get; set; }
        public float wind_gust { get; set; }
        public string wind_dir { get; set; }
        public float pressure_mm { get; set; }
        public float pressure_pa { get; set; }
        public float humidity { get; set; }
        public float prec_mm { get; set; }
        public float prec_period { get; set; }
        public float prec_prob { get; set; }

    }
}
