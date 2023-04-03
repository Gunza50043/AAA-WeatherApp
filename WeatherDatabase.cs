using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherApp
{
    public class WeatherDatabase
    {
        private Random _random = new Random();
        private int RandomInt
        {
            get => _random.Next(-30, 61);
        }
        internal List<Weather> WeatherList { get; private set; }

        public void Initialize()
        {
            WeatherList = new List<Weather>
            {
                new Weather(RandomInt, MeasureUnits.Celsius, new City("Абакан")),
                new Weather(RandomInt, MeasureUnits.Celsius, new City("Черногорск")),
                new Weather(RandomInt, MeasureUnits.Fahrenheit, new City("Минусинск")),
                new Weather(RandomInt, MeasureUnits.Kelvin, new City("Сорск")),
                new Weather(RandomInt, MeasureUnits.Celsius, new City("Абаза")),
                new Weather(RandomInt, MeasureUnits.Celsius, new City("Аскиз")),
                new Weather(RandomInt, MeasureUnits.Kelvin, new City("Боград")),
                new Weather(RandomInt, MeasureUnits.Celsius, new City("Таштып")),
                new Weather(RandomInt, MeasureUnits.Celsius, new City("Копьёво"))
            };
        }
        internal object searchWeathers (List<Weather> WaetherList, string InputText)
        {
            var weatherList = WeatherList.Where(T => T.CityName == InputText)
                .Select(T => T)
                .ToList();
            return weatherList;

        }
    }
}