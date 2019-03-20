using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heysem.WebApiDemo.Models
{
    public class CountryDestinationsModel
    {
        public int DestinationId { get; set; }
        public string Name { get; set; }
        public int? ParentDestinationId { get; set; }
    }
}
