
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStarService
    {
        IResult Add(Star star);
    }
}