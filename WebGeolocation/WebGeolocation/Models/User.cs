using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebGeolocation.Models
{
    [Table ("USERS")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column ("iduUSER")]
        public int ID { get; set; }

        [Column ("NAME")]
        public string Name { get; set; }

        [Column ("PASSWORD")]
        public string Password { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("PHONE")]
        public string Phone { get; set; }

    }
}