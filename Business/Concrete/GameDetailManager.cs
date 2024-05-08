using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concretes.Context;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;
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

        public List<GameDetail> GetAll(Expression<Func<GameDetail, bool>> filter = null)
        {
            using (var context = new GameStreamDbContext())
            {
                IQueryable<GameDetail> query = context.GameDetails.Include(g => g.Game).ThenInclude(g => g.GameImages);

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return query.ToList();
            }
        }

        public GameDetail GetById(int id)
        {
            using (var context = new GameStreamDbContext())
            {
                // GameDetailId'ye göre doğru kaydı çekecek şekilde sorguyu ayarlayın
                var gameDetail = context.GameDetails
                    .Where(gd => gd.Id == id) // Burada GameDetailId ile filtreleme yapılır
                    .Include(gd => gd.Game)             // İlişkili Game bilgilerini dahil edin
                    .ThenInclude(g => g.GameImages)    // Game ile ilişkili GameImages bilgilerini dahil edin
                    .FirstOrDefault();                 // İlk veya varsayılan değeri döndür

                return gameDetail; // Çekilen GameDetail nesnesini döndür
            }
        }

        public void Update(GameDetail entity)
        {
            _gameDetailDal.Update(entity);
        }
    }
}
