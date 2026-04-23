using lab_3.Modele;
using lab_3.Widok.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Prezenter
{
    public class WeatherPresenter
    {
        private readonly IWeatherView _view;
        private readonly WeatherService _model;

        public WeatherPresenter(IWeatherView view, WeatherService model)
        {
            _view = view;
            _model = model;

            _view.SearchClicked += OnSearchClicked;
        }

        private async void OnSearchClicked(object sender, EventArgs e)
        {
            string city = _view.CityName;

            if (string.IsNullOrWhiteSpace(city))
            {
                _view.Description = "Wpisz nazwę miasta!";
                return;
            }

            var weatherData = await _model.GetWeatherAsync(city);

            if (weatherData != null)
            {
                _view.Temperature = $"{weatherData.Main.Temperature} °C";
                _view.Pressure = $"{weatherData.Main.Pressure} hPa";
                _view.Humidity = $"{weatherData.Main.Humidity} %";

                if (weatherData.Weather != null && weatherData.Weather.Length > 0)
                {
                    _view.Description = weatherData.Weather[0].Description;
                    string iconUrl = $"http://openweathermap.org/img/wn/{weatherData.Weather[0].IconCode}@2x.png";
                    _view.WeatherIcon = iconUrl;
                }
            }
            else
            {
                _view.Description = "Błąd: Nie znaleziono miasta lub brak połączenia.";
                _view.Temperature = "--";
                _view.Pressure = "--";
                _view.Humidity = "--";
                _view.WeatherIcon = "";
            }
        }
    }
}
