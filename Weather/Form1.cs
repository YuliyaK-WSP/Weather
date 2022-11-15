using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Converters;

namespace Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void requestButt_Click(object sender, EventArgs e)
        {
            GetWeather();
        }
        async Task GetWeather()
        {
            HttpClient client = new HttpClient();
            var url = "https://api.weather.yandex.ru/v2/forecast/?lat=55.889742&lon=37.444826";
            const string key = "bacdb292-db72-4551-b1a4-d768f9a22992";
            client.DefaultRequestHeaders.Add("X-Yandex-API-Key", key);
            //try
            //{
            HttpResponseMessage response = await client.GetAsync(url);


            string jsonRespons = await response.Content.ReadAsStringAsync();

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(jsonRespons);

            textInfoRes.Text = weatherResponse.fact.temp.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
