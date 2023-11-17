using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebGeolocation.Models
{
    public class WebDbContext : DbContext
    {
        public DbSet<Hash> Hashes { get; set; }
        public DbSet<Running> Runnings { get; set; }
        public DbSet<Tracker> Trackers { get; set; }
        public DbSet<User> Users { get; set; }

        public WebDbContext() : base("MDalConnectionDb")
        {

            Database.CreateIfNotExists();
            
        }
    }
}