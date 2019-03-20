using Heysem.WebApiDemo.Entities;
using Heysem.WebApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heysem.WebApiDemo.DataAccess
{
   public interface ICountryDestinationsDal: IEntitiyRepository<CountryDestinations>
    {
        List<CountryDestinationsModel> GetCountryDestinations(int countryId);
    }
}
