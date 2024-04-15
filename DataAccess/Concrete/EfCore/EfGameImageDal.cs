using DataAccess.Abstract;
using DataAccess.Concretes.Context;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EfCore
{
    public class EfGameImageDal : EfCoreRepository<GameImage, GameStreamDbContext>, IGameImageDal
    {
    }
}
