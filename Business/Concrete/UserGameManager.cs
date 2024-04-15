using Business.Abstract;
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
        public void Create(UserGame entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserGame entity)
        {
            throw new NotImplementedException();
        }

        public List<UserGame> GetAll(Expression<Func<UserGame, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public UserGame GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserGame entity)
        {
            throw new NotImplementedException();
        }
    }
}
