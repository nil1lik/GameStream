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
    public class StreamerManager : IStreamerService
    {
        private readonly IStreamerDal _streamerDal;

        public StreamerManager(IStreamerDal streamerDal)
        {
            _streamerDal = streamerDal;
        }

        public void Create(Streamer entity)
        {
            _streamerDal.Create(entity);
        }

        public void Delete(Streamer entity)
        {
            _streamerDal.Delete(entity);
        }

        public List<Streamer> GetAll(Expression<Func<Streamer, bool>> filter)
        {
            return _streamerDal.GetAll(filter);
        }

        public List<Streamer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Streamer GetById(int id)
        {
            return _streamerDal.GetById(id);
        }

        public void Update(Streamer entity)
        {
            _streamerDal.Update(entity);
        }
    }
}
