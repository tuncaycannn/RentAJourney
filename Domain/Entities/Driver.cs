using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Domain.Entities
{
    public class Driver : User
    {
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string About { get; set; }
        public CarModel CarModel { get; set; }
        public int CarModelId { get; set; }
    }
}
