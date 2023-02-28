using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Journey : Entity
    {
        public int OriginId { get; set; }
        public City Origin { get; set; }
        public int DestinationId { get; set; }
        public City Destination { get; set; }
        public DateTime JourneyDate { get; set; }
        public int NumberOfPerson { get; set; }
    }
}
