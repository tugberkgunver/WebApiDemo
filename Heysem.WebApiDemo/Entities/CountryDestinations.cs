using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heysem.WebApiDemo.Entities
{
    public class CountryDestinations:IEntity
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int DestinationsId { get; set; }
    }
}
