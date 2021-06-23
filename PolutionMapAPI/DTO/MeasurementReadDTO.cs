namespace PolutionMapAPI.DTO
{
    public record MeasurementsReadDTO
    {
        public string Type { get; set; }
        public Feature Features { get; set; }
    }
}
