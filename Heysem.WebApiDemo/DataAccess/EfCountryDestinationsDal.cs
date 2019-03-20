using Heysem.WebApiDemo.Entities;
using Heysem.WebApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heysem.WebApiDemo.DataAccess
{
    public class EfCountryDestinationsDal : EfEntityRepositoryBase<CountryDestinations, HeysemAPIContext>, ICountryDestinationsDal
    {
        public List<CountryDestinationsModel> GetCountryDestinations(int countryId)
        {
            using (HeysemAPIContext context = new HeysemAPIContext())
            {
                var result = from cd in context.CountryDestinations
                             join d in context.Destinations on cd.DestinationsId equals d.DestinationId

                             where cd.CountryId == countryId
                             select new CountryDestinationsModel
                             {
                                 DestinationId = d.DestinationId,
                                 Name = d.Name,
                                 ParentDestinationId = d.ParentDestinationId
                                 
                             };
                return result.ToList();
            }
        }
    }
}
