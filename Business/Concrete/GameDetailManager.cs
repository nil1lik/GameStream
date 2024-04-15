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
    public class GameDetailManager : IGameDetailService
    {
        public void Create(GameDetail entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(GameDetail entity)
        {
            throw new NotImplementedException();
        }

        public List<GameDetail> GetAll(Expression<Func<GameDetail, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public GameDetail GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(GameDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
