using Microsoft.AspNetCore.Mvc;
using PolutionMapAPI.Data;
using PolutionMapAPI.Models;

namespace PolutionMapAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementsController : ControllerBase
    {
        private readonly IMeasurementsRepo _repository;
        public MeasurementsController(IMeasurementsRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllMeasurement()
        {
            return Ok(_repository.GetAllMeasurements());
        }

        [HttpPost]
        public IActionResult CreateNewMeasurement(Measurement newMeasure)
        {
            _repository.CreateNewMeasurement(newMeasure);
            return Ok();
        }
    }
}
