using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Heysem.WebApiDemo.Entities
{
    public class Destinations:IEntity
    {
        [Key]
        public int DestinationId { get; set; }
        public string Name { get; set; }
        public int? ParentDestinationId { get; set; }
    }
}
