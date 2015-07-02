using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Sup.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        public DbGeography Point { get; set; }

        [Required]
        public double Longitude { get; set; }
        [Required]
        public double Latitude { get; set; }

        public string Info { get; set; }

        [ForeignKey("Route")]
        [Required]
        public int RouteId { get; set; }

        public Route Route { get; set; }
    }
}