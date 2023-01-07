namespace HomrWork_Seminar9_Arch.Models
{
    public class WeatherForecastModel
    {

        private List<WeatherForecast> _list;

        public WeatherForecastModel()
        {
            // Инициализирую коллекцию для хранения показателей температуры
            _list = new List<WeatherForecast>();
        }

        /// <summary>
        /// Добавить температуру
        /// </summary>
        /// <param name="date">Дата снятия показаний</param>
        /// <param name="temperatureC">Значение температуры в указанный день</param>
        public void Add(DateTime date, int temperatureC)
        {
            WeatherForecast weatherForecast = new WeatherForecast(date, temperatureC);
            _list.Add(weatherForecast);
        }

        /// <summary>
        /// Удаление информации по погоде
        /// </summary>
        /// <returns></returns>
        public void Delete(DateTime date)
        {
       

            foreach (WeatherForecast weather in _list)
            {
                if (weather.Date == date)
                {
                    _list.Remove(weather);
                    break;

                }
            }

        }

        /// <summary>
        /// Удаление информации по погоде за период
        /// </summary>
        /// <returns></returns>

        public void DeletePeriod(DateTime dateStart, DateTime dateEnd)
        {
            for (int i = 0; i < _list.Count; i++) {
                if (_list[i].Date >= dateStart && _list[i].Date <= dateEnd)
                {
                    _list.RemoveAt(i);
                    i--;
                }
            }

            

        }

        /// <summary>
        /// Получение информации по погоде за период
        /// </summary>
        /// <returns></returns>
        public List<WeatherForecast> Get(DateTime dateStart, DateTime dateEnd)
        {
            List<WeatherForecast> listByDate = new List<WeatherForecast>();
            foreach (WeatherForecast weather in _list)
            {
                if (weather.Date >= dateStart && weather.Date <= dateEnd)
                {
                    listByDate.Add(weather);
                }
            }
            return listByDate;
        }

        /// <summary>
        /// Обновление информации по погоде
        /// </summary>
        /// <returns></returns>
        public void Update(DateTime date, int temperatureC)
        {
            foreach (WeatherForecast weather in _list)
            {
                if (weather.Date == date)
                {
                    weather.TemperatureC = temperatureC;
                    break;
                }
            }
        }

  

    }
}
