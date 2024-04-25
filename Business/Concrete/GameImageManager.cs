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
    public class GameImageManager : IGameImageService
    {
        private readonly IGameImageDal _gameImageDal;

        public GameImageManager(IGameImageDal gameImageDal)
        {
            _gameImageDal = gameImageDal;
        }

        public void Create(GameImage entity)
        {
            _gameImageDal.Create(entity);
        }

        public void Delete(GameImage entity)
        {
            _gameImageDal.Delete(entity);
        }

        public List<GameImage> GetAll(Expression<Func<GameImage, bool>> filter)
        {
            return _gameImageDal.GetAll(filter);
        }

        public GameImage GetById(int id)
        {
            return _gameImageDal.GetById(id);
        }

        public void Update(GameImage entity)
        {
            _gameImageDal.Update(entity);
        }
    }
}
