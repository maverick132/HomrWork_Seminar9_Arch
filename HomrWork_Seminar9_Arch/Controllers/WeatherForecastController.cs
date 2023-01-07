using HomrWork_Seminar9_Arch.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomrWork_Seminar9_Arch.Controllers
{
    [Route("weather")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {

        private WeatherForecastModel _weatherForecastModel;

        public WeatherForecastController(WeatherForecastModel weatherForecastModel)
        {
            _weatherForecastModel = weatherForecastModel;
        }
        /// <summary>
        /// Добавление информации по погоде
        /// </summary>
        /// <returns></returns>
        [HttpPost("add")]  
        public IActionResult Add(DateTime date, int temparatureC)
        {
            _weatherForecastModel.Add(date, temparatureC);
            return Ok();
        
        }



        /// <summary>
        /// Удаление информации по погоде
        /// </summary>
        /// <returns></returns>
        [HttpDelete("delete")]
        public IActionResult Delete(DateTime date)
        {
            _weatherForecastModel.Delete(date);
            return Ok();
        }

        /// <summary>
        /// Удаление информации по погоде за указанный период
        /// </summary>
        /// <returns></returns>
        [HttpDelete("deletePeriod")]
        public IActionResult DeletePeriod(DateTime dateStart, DateTime dateEnd)
        {
            _weatherForecastModel.DeletePeriod(dateStart, dateEnd);
            return Ok();
        }

        /// <summary>
        /// Обновление информации по погоде
        /// </summary>
        /// <returns></returns>

        [HttpPut("update")]
        public IActionResult Update(DateTime date, int temparatureC)
        {
            _weatherForecastModel.Update(date, temparatureC);
            return Ok();
        }


        /// <summary>
        /// Получение информации по погоде за период
        /// </summary>
        /// <returns></returns>
        [HttpGet("get")]
        public IActionResult Get(DateTime dateStart, DateTime dateEnd)
        {
            return Ok(_weatherForecastModel.Get(dateStart, dateEnd));
        }


    }
}
