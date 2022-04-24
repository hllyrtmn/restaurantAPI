using Core.Entities;

namespace Entities.Concrete
{
    public class Restaurant : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Establishment { get; set; }

    }
}