using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sup.Models
{
    public class Route
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Location> Location { get; set; }

        public System.Net.HttpStatusCode StatusCode { get; set; }
    }
}