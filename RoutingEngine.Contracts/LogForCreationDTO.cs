namespace RoutingEngine.Contracts
{
    public class LogForCreationDTO
    {

        public string Origin { get; set; }

        public string Destination { get; set; }

        public decimal Distance { get; set; }

        public decimal Price { get; set; }

        public decimal TravelTime { get; set; }

    }
}