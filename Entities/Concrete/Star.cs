using Core.Entities;

namespace Entities.Concrete
{
    public class Star : IEntity
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int StarDegree { get; set; }
        
    }
}