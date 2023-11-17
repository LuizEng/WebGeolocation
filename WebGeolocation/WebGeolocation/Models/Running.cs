using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebGeolocation.Models
{
    [Table ("RUNNING")]
    public class Running
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
       // [Column ("iduRUNNING")]
        public int Id { get; set; }

        [Column ("INITIALDATE")]
        public DateTime InitialDate { get; set; }

        [Column("FINALDATE")]
        public DateTime FinalDate { get; set; }
    }
}