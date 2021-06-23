using AutoMapper;
using PolutionMapAPI.DTO;
using PolutionMapAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace PolutionMapAPI.Profiles
{
    public class MeasurementProfile : Profile
    {
        public MeasurementProfile()
        {
            CreateMap<IEnumerable<Measurement>, MeasurementsReadDTO>()
                .ForPath(
                    dest => dest.Features,
                    opt => opt.MapFrom(src => src.Select(m => new Feature()
                    {
                        Geometry = new Geometry()
                        {
                            Coordinates = new List<double>()
                            {
                                m.Longitude,
                                m.Latitude
                            },
                            Type = "Point"
                        },
                        Properties = m.Properties,
                        Type = "Feature"
                    })))
                .ForPath(
                    dest => dest.Type,
                    opt => opt.MapFrom(src => "FeatureCollection"));
        }
    }
}
