using AutoMapper;
using PolutionMapAPI.DTO;
using PolutionMapAPI.Models;
using System.Collections.Generic;

namespace PolutionMapAPI.Profiles
{
    public class MeasurementProfile : Profile
    {
        public MeasurementProfile()
        {
            CreateMap<Measurement, MeasurementsReadDTO>()
                .ForPath(
                    dest => dest.Feature.Noise,
                    opt => opt.MapFrom(src => src.Properties.Noise))
                .ForPath(
                    dest => dest.Feature.Polution,
                    opt => opt.MapFrom(src => src.Properties.Polution))
                .ForPath(
                    dest => dest.Feature.Timestamp,
                    opt => opt.MapFrom(src => src.Timestamp))
                .ForPath(
                    dest => dest.Feature.Geometry,
                    opt => opt.MapFrom(src => new Geometry(new List<double> { src.Latitude, src.Longitude })));
        }
    }
}
