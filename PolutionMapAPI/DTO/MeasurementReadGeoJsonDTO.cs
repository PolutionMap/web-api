using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolutionMapAPI.DTO
{
    public record MeasurementReadGeoJsonDTO
    {
        public const string Type = "FeatureCollection";
        public List<Feature> features;
    }
}
