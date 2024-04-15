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
    public class StreamingManager : IStreamingService
    {
        public void Create(Streaming entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Streaming entity)
        {
            throw new NotImplementedException();
        }

        public List<Streaming> GetAll(Expression<Func<Streaming, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Streaming GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Streaming entity)
        {
            throw new NotImplementedException();
        }
    }
}
