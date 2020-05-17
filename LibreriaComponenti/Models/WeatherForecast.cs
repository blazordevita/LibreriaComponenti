using System;
using System.ComponentModel.DataAnnotations;

namespace LibreriaComponenti.Models
{
    public class WeatherForecast
    {
        [DisplayFormat(DataFormatString="{0:d}")]
        public DateTime Date { get; set; }

        [Display(ShortName = "Temp. (C)")]
        public int TemperatureC { get; set; }

        [Display(ShortName = "Temp. (F)")]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string Summary { get; set; }
    }
}
