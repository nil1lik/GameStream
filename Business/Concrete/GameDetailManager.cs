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
    public class GameDetailManager : IGameDetailService
    {
        private readonly IGameDetailDal _gameDetailDal;

        public GameDetailManager(IGameDetailDal gameDetailDal)
        {
            _gameDetailDal = gameDetailDal;
        }

        public void Create(GameDetail entity)
        {
            _gameDetailDal.Create(entity);
        }

        public void Delete(GameDetail entity)
        {
            _gameDetailDal.Delete(entity);
        }

        public List<GameDetail> GetAll(Expression<Func<GameDetail, bool>> filter)
        {
            return _gameDetailDal.GetAll(filter);
        }

        public GameDetail GetById(int id)
        {
            return _gameDetailDal.GetById(id);
        }

        public void Update(GameDetail entity)
        {
            _gameDetailDal.Update(entity);
        }
    }
}
