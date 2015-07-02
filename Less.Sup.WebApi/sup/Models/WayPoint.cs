using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Less.Sup.WebApi.Models
{
    public class WayPoint
    {
        [Key]
        public int Id { get; set; }

        public DbGeography DbGeography { get; set; }

        /// <summary>
        /// Geographische Länge
        /// --> längs durch die Pole
        /// 0-180 östlich 
        /// und 0-180 westlich
        /// oder -west und +ost
        /// oder Ost/E West/W
        /// </summary>
        [Required]
        public double Longitude { get; set; }

        /// <summary>
        /// geographische Breite
        /// --> Breiter wirds zum äquator, weniger breit zu den Polen hin
        /// -90(Südpol) - 90 (NordPol)
        /// </summary>
        [Required]
        public double Latitude { get; set; }

        public string Info { get; set; }

        [ForeignKey("Route")]
        [Required]
        public int RouteId { get; set; }

        public Route Route { get; set; }
    }
}