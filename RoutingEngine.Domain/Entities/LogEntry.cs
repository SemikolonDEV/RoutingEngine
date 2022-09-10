namespace RoutingEngine.Domain.Entities
{
    public class LogEntry
    {

        public Guid Id { get; set; }

        public DateTime CreationTime { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public decimal Distance { get; set; }

        public decimal Price { get; set; }

        public decimal TravelTime { get; set; }

    }
}