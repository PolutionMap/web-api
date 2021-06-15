using System.Collections.Generic;

namespace PolutionMapAPI.DTO
{
    public record MeasurementsReadDTO(string Type, List<Feature> Features);
}
