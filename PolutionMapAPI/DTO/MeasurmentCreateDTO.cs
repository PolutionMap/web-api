using System.Collections.Generic;
using PolutionMapAPI.Models;

namespace PolutionMapAPI.DTO
{
    public record MeasurementsCreateDTO (string Type, List<Feature> Features);
    public record Feature (string Type, MeasurementProperties Properties, Geometry Geometry);
    public record Geometry (string Type, List<double> Coorginates);
}