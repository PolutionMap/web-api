using System;
using System.Collections.Generic;
using PolutionMapAPI.Models;

namespace PolutionMapAPI.DTO
{
    public record MeasurementsCreateDTO(List<Feature> Features);
    public record Feature
    {
        public int Noise { get; set; }
        public int Polution { get; set; }
        public DateTime Timestamp { get; set; }
        public Geometry Geometry { get; set; }
    }
    public record Geometry (List<double> Coordinates);
}