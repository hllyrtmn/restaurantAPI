using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRestaurantOpinionService
    {
        IResult Add(RestaurantOpinion restaurantOpinion);
        IResult Delete(RestaurantOpinion restaurantOpinion);
        IResult Update(RestaurantOpinion restaurantOpinion);
        IDataResult<RestaurantOpinion> GetById(int id);
        IDataResult<List<RestaurantOpinion>> GetAll(int id);
    }
}