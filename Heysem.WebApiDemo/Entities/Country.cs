using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heysem.WebApiDemo.Entities
{
    public class Country:IEntity
    {
        public int CountryId { get; set; }
        public string ISO { get; set; }
        public string Name { get; set; }
        
    }
}
