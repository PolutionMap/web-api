using Microsoft.EntityFrameworkCore;
using PolutionMapAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolutionMapAPI.Data
{
    public class SqlMeasurementRepo : IMeasurementsRepo
    {
        private readonly MeasurementContext context;
        public SqlMeasurementRepo(MeasurementContext mc)
        {
            context = mc;
        }

        public void CreateNewMeasurement(Measurement newMeasure)
        {
            if (newMeasure == null)
            {
                throw new ArgumentNullException(nameof(newMeasure));
            }

            context.Measurements.Add(newMeasure);
        }

        public IEnumerable<Measurement> GetAllMeasurements()
        {
            return context.Measurements.Include(p => p.Properties).ToList();
        }
    }
}
