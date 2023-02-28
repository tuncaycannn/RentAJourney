using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class District
    {
        public int Id { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public string DistrictName { get; set; }
    }
}
