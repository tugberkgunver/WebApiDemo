using Heysem.WebApiDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heysem.WebApiDemo.DataAccess
{
    public class EfDestinationDal: EfEntityRepositoryBase<Destinations, HeysemAPIContext>, IDestinationDal
    {
    }
}
