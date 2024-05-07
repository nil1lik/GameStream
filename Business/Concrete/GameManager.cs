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
    public class GameManager : IGameService
    {
        private readonly IGameDal _gameDal;

        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public void Create(Game entity)
        {
            _gameDal.Create(entity);
        }

        public void Delete(Game entity)
        {
            _gameDal.Delete(entity);
        }

        public List<Game> GetAll(Expression<Func<Game, bool>> filter)
        {
            return _gameDal.GetAll(filter);
        }

        public List<Game> GetAll()
        {
            throw new NotImplementedException();
        }

        public Game GetById(int id)
        {
            return _gameDal.GetById(id);
        }

        public void Update(Game entity)
        {
            _gameDal.Update(entity);
        }
    }
}
