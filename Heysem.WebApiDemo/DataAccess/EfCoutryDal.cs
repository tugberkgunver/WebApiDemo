using Heysem.WebApiDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Heysem.WebApiDemo.DataAccess
{
    public class EfCoutryDal: EfEntityRepositoryBase<Country, HeysemAPIContext>, ICountryDal
    {
      
    }
}
