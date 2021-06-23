using PolutionMapAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PolutionMapAPI.Helpers
{
    public static class RandomPropsHelper
    {
        private static Random rand = new Random();
        public static IEnumerable<Measurement> SetRandProps(this IEnumerable<Measurement> measurements)
        {
            return measurements.Select(m => new Measurement()
            {
                Id = m.Id,
                Point = m.Point,
                Properties = new MeasurementProperties()
                {
                    Noise = rand.Next(0, 40),
                    Polution = rand.Next(0, 130)
                }
            })
        }
    }
}
