using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRestaurantService
    {
        IResult Add(Restaurant restaurant);
        IResult Delete(Restaurant restaurant);
        IResult Update(Restaurant restaurant);
        IDataResult<List<Restaurant>> GetByType(string type);
        IDataResult<List<Restaurant>> GetAll();
        IDataResult<Restaurant> GetById(int id);
    }
}