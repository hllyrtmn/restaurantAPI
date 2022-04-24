using System.Collections.Generic;
using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RestaurantManager : IRestaurantService
    {
        private IRestaurantDal _restaurantDal;

        public RestaurantManager(IRestaurantDal restaurantDal)
        {
            _restaurantDal = restaurantDal;
        }

        public IResult Add(Restaurant restaurant)
        {
            if (_restaurantDal.Get(r=>r.Name==restaurant.Name)==null)
            {
                _restaurantDal.Add(restaurant);
                return new SuccessResult(Messages.RestaurantAdded);
            }

            return new ErrorResult(restaurant.Name+" "+Messages.RestaurantNotAdded);

        }

        public IResult Delete(Restaurant restaurant)
        {
            _restaurantDal.Delete(restaurant);
            return new SuccessResult(Messages.RestaurantDeleted);
        }

        public IResult Update(Restaurant restaurant)
        {
            _restaurantDal.Update(restaurant);
            return new SuccessResult(Messages.RestaurantUpdated);
        }
        public IDataResult<List<Restaurant>> GetAll()
        {
            return new SuccessDataResult<List<Restaurant>>(_restaurantDal.GetAll());
        }

        public IDataResult<Restaurant> GetById(int id)
        {
            return new SuccessDataResult<Restaurant>(_restaurantDal.Get(r => r.Id == id));
        }

        public IDataResult<List<Restaurant>> GetByType(string type)
        {
            return new SuccessDataResult<List<Restaurant>>(_restaurantDal.GetAll(r => r.Type == type));
        }


    }
}