using System;
using System.ComponentModel.DataAnnotations;

namespace PolutionMapAPI.Models
{
    public class Measurement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public double Latitude { get; set; }
        public MeasurementProperties Properties { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
    }
}
