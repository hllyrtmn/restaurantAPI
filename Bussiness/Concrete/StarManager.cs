using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StarManager:IStarService
    {
        private IStarDal _starDal;

        public StarManager(IStarDal starDal)
        {
            _starDal = starDal;
        }

        public IResult Add(Star star)
        {
           
                _starDal.Add(star);
                return new SuccessResult();

        }

    }
}