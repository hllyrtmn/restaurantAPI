using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User business);
        IResult Delete(User business);
        IResult Update(User business);
        IDataResult<User> GetById(int id);
        IDataResult<List<UserForRegisterDto>> GetUserForRegister();
        IDataResult<User> GetByMail(string email);
        List<OperationClaim> GetClaims(User user);
    }
}