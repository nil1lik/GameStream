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
       
    }
}
