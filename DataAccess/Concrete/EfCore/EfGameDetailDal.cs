using DataAccess.Abstract;
using DataAccess.Concretes.Context;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EfCore
{
    public class EfGameDetailDal : EfCoreRepository<GameDetail, GameStreamDbContext>, IGameDetailDal
    {
        public override List<GameDetail> GetAll(Expression<Func<GameDetail, bool>> filter)
        {
            using (var context = new GameStreamDbContext())
            {
                IQueryable<GameDetail> query = context.GameDetails.Include(g => g.Game).ThenInclude(g=> g.GameImages);

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return query.ToList();
            }
        }

        public override GameDetail GetById(int id)
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

    }
}
