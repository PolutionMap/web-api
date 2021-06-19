using PolutionMapAPI.Models;
using System;
using System.Collections.Generic;

namespace PolutionMapAPI.Data
{
    public class MockRepo : IMeasurementsRepo
    {
        private readonly List<Measurement> measurments = new List<Measurement>
        {
            
        };
        public void CreateNewMeasurement(Measurement newMeasure)
        {
            measurments.Add(newMeasure);
        }

        public IEnumerable<Measurement> GetAllMeasurements()
        {
            return measurments;
        }
    }
}