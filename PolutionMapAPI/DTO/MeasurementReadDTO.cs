using System.Collections.Generic;

namespace PolutionMapAPI.DTO
{
    public record MeasurementsReadDTO
    {
        public string Type { get; set; }
        public IEnumerable<Feature> Features { get; set; }
    }
}
