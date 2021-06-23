using PolutionMapAPI.Helpers;
using PolutionMapAPI.Models;
using System.Collections.Generic;

namespace PolutionMapAPI.Data
{
    public class MockRepo : IMeasurementsRepo
    {
        private readonly List<Measurement> measurments = new List<Measurement>
        {
            new Measurement
            {
                Id = 0,
                Latitude = 53.20833206176758,
                Longitude = 56.87201062081965,
            },
            new Measurement
            {
                Id = 1,
                Latitude = 53.222923278808594,
                Longitude = 56.87229206431822,
            },
            new Measurement
            {
                Id = 2,
                Latitude = 53.22094917297363,
                Longitude = 56.86164264246691,
            },
            new Measurement
            {
                Id = 3,
                Latitude = 53.20884704589844,
                Longitude = 56.860844986610765,
            },
            new Measurement
            {
                Id = 4,
                Latitude = 53.226871490478516,
                Longitude = 56.84559241227612,
            },
            new Measurement
            {
                Id = 5,
                Latitude = 53.214640617370605,
                Longitude = 56.84423111117493,
            },
            new Measurement
            {
                Id = 6,
                Latitude = 53.2800006866455,
                Longitude = 56.8491597250992,
            },
            new Measurement
            {
                Id = 7,
                Latitude = 53.25339317321777,
                Longitude = 56.84840874013018,
            },
            new Measurement
            {
                Id = 8,
                Latitude = 53.27519416809082,
                Longitude = 56.869383712673965,
            },
            new Measurement
            {
                Id = 9,
                Latitude = 53.28326225280762,
                Longitude = 56.874918768148945,
            },
            new Measurement
            {
                Id = 10,
                Latitude = 53.25639724731445,
                Longitude = 56.871541543614285,
            },
            new Measurement
            {
                Id = 11,
                Latitude = 53.16181182861328,
                Longitude = 56.832446746576004,
            },
            new Measurement
            {
                Id = 12,
                Latitude = 53.12833786010742,
                Longitude = 56.82962921764389,
            },
            new Measurement
            {
                Id = 13,
                Latitude = 53.17777633666992,
                Longitude = 56.81798118236037,
            },
            new Measurement
            {
                Id = 14,
                Latitude = 53.20816040039062,
                Longitude = 56.817323523973485,
            },
            new Measurement
            {
                Id = 15,
                Latitude = 53.227214813232415,
                Longitude = 56.833949341997815,
            },
            new Measurement
            {
                Id = 16,
                Latitude = 53.19992065429687,
                Longitude = 56.8340432522097,
            },
            new Measurement
            {
                Id = 17,
                Latitude = 53.28369140625,
                Longitude = 56.832822401084115,
            },
            new Measurement
            {
                Id = 18,
                Latitude = 53.3140754699707,
                Longitude = 56.839677433927754,
            },
            new Measurement
            {
                Id = 19,
                Latitude = 53.179664611816406,
                Longitude = 56.87627895296417,
            },
            new Measurement
            {
                Id = 20,
                Latitude = 53.17760467529297,
                Longitude = 56.86126727712404,
            },
        };
        public void CreateNewMeasurement(Measurement newMeasure)
        {
            measurments.Add(newMeasure);
        }

        public IEnumerable<Measurement> GetAllMeasurements()
        {
            return measurments.SetRandProps();
        }
    }
}