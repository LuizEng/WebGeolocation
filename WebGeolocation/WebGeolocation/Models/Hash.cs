using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebGeolocation.Models
{
    [Table ("HASH")]
    public class Hash
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column ("iduUHASH")]
        public int Id { get; set; }

        [Column ("LATITUDE")]
        public float Latitude { get; set; }

        [Column("LONGITUDE")]
        public float Longitude { get; set; }

        [Column("ALTITUDE")]
        public float Altitude { get; set; }

        [Column("SPEED")]
        public float Speed { get; set; }

        [Column("COURSE")]
        public float Course { get; set; }

        [Column("DATE")]
        public DateTime Date { get; set; }

        [Column("TIME")]
        public DateTime Time { get; set; }

        [Column("SATELLITES")]
        public int Satellites { get; set;}

        [ForeignKey("Id")]
        public Running RunningId { get; set; }
    }
}