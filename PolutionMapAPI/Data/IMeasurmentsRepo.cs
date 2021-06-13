using PolutionMapAPI.Models;
using System.Collections.Generic;

namespace PolutionMapAPI.Data
{
    public interface IMeasurmentsRepo
    {
        IEnumerable<Measurement> GetAllMeasurments();
        void CreateNewMeasurments(Measurement newMeasure);
    }
}