using PolutionMapAPI.Models;
using System.Collections.Generic;

namespace PolutionMapAPI.Data
{
    public interface IMeasurementsRepo
    {
        IEnumerable<Measurement> GetAllMeasurements();
        void CreateNewMeasurement(Measurement newMeasure);
    }
}