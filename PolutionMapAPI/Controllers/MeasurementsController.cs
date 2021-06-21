using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PolutionMapAPI.Data;
using PolutionMapAPI.DTO;
using PolutionMapAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace PolutionMapAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementsController : ControllerBase
    {
        private readonly IMeasurementsRepo repository;
        private readonly IMapper mapper;

        public MeasurementsController(IMeasurementsRepo repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllMeasurement()
        {
            var recs = repository.GetAllMeasurements();
            if(recs != null)
            {
                return Ok(mapper.Map<List<Measurement>, List<MeasurementsReadDTO>>(recs.ToList()));
            }
            return new NotFoundResult();
        }

        [HttpPost]
        public IActionResult CreateNewMeasurement(MeasurementsCreateDTO newMeasure)
        {
            var measurementModel = mapper.Map<Measurement>(newMeasure);
            if(measurementModel != null)
            {
                return Ok(measurementModel);
            }
            return new BadRequestResult();
        }
    }
}
