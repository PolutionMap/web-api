using System.ComponentModel.DataAnnotations;

namespace PolutionMapAPI.Models
{
    public record MeasurementProperties(int Id, [Required] int Polution, [Required] int Noise, [Required] int MeasurementId);
}