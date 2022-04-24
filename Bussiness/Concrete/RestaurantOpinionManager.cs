using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RestaurantOpinionManager :IRestaurantOpinionService
    {
        private IRestaurantOpinionDal _restaurantOpinionDal;

        public RestaurantOpinionManager( IRestaurantOpinionDal restaurantOpinionDal)
        {
            _restaurantOpinionDal = restaurantOpinionDal;
        }

        public IResult Add(RestaurantOpinion restaurantOpinion)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(RestaurantOpinion restaurantOpinion)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(RestaurantOpinion restaurantOpinion)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<RestaurantOpinion> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<RestaurantOpinion>> GetAll(int id)
        {
            return new SuccessDataResult<List<RestaurantOpinion>>(_restaurantOpinionDal.GetAll(r=>r.RestaurantId==id));
        }
    }
}