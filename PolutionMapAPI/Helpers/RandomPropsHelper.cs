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
            return measurements.Select((m, i) => new Measurement()
            {
                Id = m.Id,
                Latitude = m.Latitude,
                Longitude = m.Longitude,
                Properties = new (i, rand.Next(0, 40), rand.Next(0, 130), m.Id),
            });
        }
    }
}
