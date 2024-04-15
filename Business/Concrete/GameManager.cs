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
    public class GameManager : IGameService
    {
        public void Create(Game entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Game entity)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetAll(Expression<Func<Game, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Game GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Game entity)
        {
            throw new NotImplementedException();
        }
    }
}
