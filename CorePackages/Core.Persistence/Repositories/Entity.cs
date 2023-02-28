namespace Core.Persistence.Repositories;

public class Entity
{
    public int Id { get; set; }
    public DateTime CreatedDate{ get; set; } = DateTime.Now;

    public Entity()
    {
    }

    public Entity(int id) : this()
    {
        Id = id;
    }
}