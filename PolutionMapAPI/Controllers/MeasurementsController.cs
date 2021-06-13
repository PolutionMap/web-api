using Microsoft.AspNetCore.Mvc;
using PolutionMapAPI.Data;
using PolutionMapAPI.Models;

namespace PolutionMapAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementsController : ControllerBase
    {
        private readonly IMeasurmentsRepo _repository;
        public MeasurementsController(IMeasurmentsRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllMeasurement()
        {
            return Ok(_repository.GetAllMeasurments());
        }

        [HttpPost]
        public IActionResult CreacteNewMeasurment(Measurement newMeasure)
        {
            _repository.CreateNewMeasurments(newMeasure);
            return Ok();
        }
    }
}
