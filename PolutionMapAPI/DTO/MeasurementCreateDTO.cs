using PolutionMapAPI.Models;
using System.Collections.Generic;

namespace PolutionMapAPI.DTO
{
    public record MeasurementsCreateDTO(string Type, List<Feature> Features);
    public record Feature
    {
        public string Type { get; set; }
        public MeasurementProperties Properties { get; set; }
        public Geometry Geometry { get; set; }
    }
    public record Geometry
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
    }
}