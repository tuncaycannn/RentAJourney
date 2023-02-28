namespace Domain.Entities
{
    public class CarModel 
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public string CarModelName { get; set; }
    }
}
