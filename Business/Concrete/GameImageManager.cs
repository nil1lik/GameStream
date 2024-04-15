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
    public class GameImageManager : IGameImageService
    {
        public void Create(GameImage entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(GameImage entity)
        {
            throw new NotImplementedException();
        }

        public List<GameImage> GetAll(Expression<Func<GameImage, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public GameImage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(GameImage entity)
        {
            throw new NotImplementedException();
        }
    }
}
