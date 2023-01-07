namespace HomrWork_Seminar9_Arch.Models
{
    /// <summary>
    /// Данные о погоде
    /// </summary>
    public class WeatherForecast
    {

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF
        {
            get { return 32 + (int)(TemperatureC / 0.5556); }
        }
        public int TemperatureK
        {
            get { return -273 + TemperatureC; }
        }

        public WeatherForecast(DateTime date, int temperatureC)
        {
            Date = date;
            TemperatureC = temperatureC;
        }

    }
}
