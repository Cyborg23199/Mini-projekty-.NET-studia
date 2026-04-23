using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Widok.Interfejsy
{
    public interface IWeatherView
    {
        string CityName { get; }

        string Temperature { set; }
        string Pressure { set; }
        string Humidity { set; }
        string Description { set; }
        string WeatherIcon { set; }

        event EventHandler SearchClicked;
    }
}
