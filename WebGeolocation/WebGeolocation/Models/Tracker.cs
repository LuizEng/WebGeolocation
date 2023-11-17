using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebGeolocation.Models
{
    [Table ("TRACKER")]
    public class Tracker
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column ("iduTRACKER")]
        public int ID { get; set; }

        [Column ("USUARIO")]
        public int Usuario { get; set; }

        [Column("TRACKER")]
        public int TrackerId { get; set; }
    }
}