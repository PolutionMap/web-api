using System;

namespace PolutionMapAPI.Models
{
    public class Measurement
    {
        public int Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public MeasurementProperties Properties { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
