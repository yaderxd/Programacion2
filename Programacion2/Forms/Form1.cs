using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infraestructure;

namespace Programacion2
{
    public partial class Form1 : Form
    {
        public HttpOpenLon httpOpenWeatherClient;
        public OpenWeather openWeather;
        string city = string.Empty;
        public Form1()
        {
            httpOpenWeatherClient = new HttpOpenLon();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a(httpOpenWeatherClient.GetCityNames());
        }
        public async Task Request()
        {
            openWeather = await httpOpenWeatherClient.GetWeatherByCityNameAsync(city);
        }
        private void a(List<OpenWeather> T)
        {
            T = httpOpenWeatherClient.GetCityNames();
            for (int i = 0; i < T.Count; i++)
            {
                cboTiempo.Items.Add(T[i].Name);
            }
        }

        private void Paneles()
        {

            WeatherPanel weatherPanel = new WeatherPanel();

            weatherPanel.lblCity.Text = city;
            weatherPanel.Paneles(openWeather);
            flpContent.Controls.Add(weatherPanel);



        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            city = cboTiempo.Text;

            if (cboTiempo.Text == string.Empty || cboTiempo == null)
            {
                MessageBox.Show("Por favor escoga una ciudad");
                return;
            }
            try
            {
                Task.Run(Request).Wait();
                if (openWeather == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }
                Paneles();
                if (openWeather.Name == null)
                {
                    MessageBox.Show("No se encontro la ciudad o no es válida");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de Sistema", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
