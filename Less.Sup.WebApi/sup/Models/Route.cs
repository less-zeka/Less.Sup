using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Less.Sup.WebApi.Models
{
    public class Route
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<WayPoint> WayPoints { get; set; }
    }
}