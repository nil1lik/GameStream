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
    public class StreamerManager : IStreamerService
    {
        public void Create(Streamer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Streamer entity)
        {
            throw new NotImplementedException();
        }

        public List<Streamer> GetAll(Expression<Func<Streamer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Streamer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Streamer entity)
        {
            throw new NotImplementedException();
        }
    }
}
