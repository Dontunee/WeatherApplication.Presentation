using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeatherApplication.Domain.Entities
{
    public class Weather
    {
        [Required]
        public string Description { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "Max length is reached")]
        public double MinTemperature { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "Max length is reached")]
        public double MaxTemperature { get; set; }

    }
}
