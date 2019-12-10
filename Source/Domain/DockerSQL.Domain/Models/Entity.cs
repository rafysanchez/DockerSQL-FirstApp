

namespace DockerSQL.Domain.Models
{
    public abstract class Entity
    {
       
        public int Id { get; protected set; }
        public abstract Entity WithId(int id);
    }
}
