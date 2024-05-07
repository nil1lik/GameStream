using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserGameManager : IUserGameService
    {
        private readonly IUserGameDal _userGameDal;

        public UserGameManager(IUserGameDal userGameDal)
        {
            _userGameDal = userGameDal;
        }

        public void Create(UserGame entity)
        {
            _userGameDal.Create(entity);
        }

        public void Delete(UserGame entity)
        {
            _userGameDal.Delete(entity);
        }

        public List<UserGame> GetAll(Expression<Func<UserGame, bool>> filter)
        {
            return _userGameDal.GetAll(filter);
        }

        public List<UserGame> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserGame GetById(int id)
        {
            return _userGameDal.GetById(id);
        }

        public void Update(UserGame entity)
        {
            _userGameDal.Update(entity);
        }
    }
}
