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
    public class StreamingManager : IStreamingService
    {
        private readonly IStreamingDal _streamingDal;

        public StreamingManager(IStreamingDal streamingDal)
        {
            _streamingDal = streamingDal;
        }
        public void Create(Streaming entity)
        {
            _streamingDal.Create(entity);
        }

        public void Delete(Streaming entity)
        {
            _streamingDal.Delete(entity);
        }

        public List<Streaming> GetAll(Expression<Func<Streaming, bool>> filter)
        {
            return _streamingDal.GetAll(filter);
        }

        public List<Streaming> GetAll()
        {
            throw new NotImplementedException();
        }

        public Streaming GetById(int id)
        {
            return _streamingDal.GetById(id);
        }

        public void Update(Streaming entity)
        {
            _streamingDal.Update(entity);
        }
    }
}
