using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    interface IModel
    {
        Task<OpenWeather> GetWeatherByCityNameAsync(string ciudad);

        List<OpenWeather> GetCityNames();

        OpenWeather GetWeatherByCity(OpenWeather openweather);
    }
}
