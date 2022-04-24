using Core.Entities;

namespace Entities.Concrete
{
    public class RestaurantOpinion : IEntity
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Comment { get; set; }
    }
}