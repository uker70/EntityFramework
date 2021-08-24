using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSynopsis.PersonClasses.FemaleClasses;
using EntityFrameworkSynopsis.PersonClasses.MaleClasses;

namespace EntityFrameworkSynopsis
{
    class EFSContext : DbContext
    {
        public EFSContext() : base("EFSDB")
        {

        }

        public DbSet<Person> Person { get; set; }
        //public DbSet<Girl> Girl { get; set; }
        //public DbSet<Boy> Boy { get; set; }
        //public DbSet<Woman> Woman { get; set; }
        //public DbSet<Man> Man { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Airline> Airline { get; set; }
        public DbSet<Review> Review { get; set; }
        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasKey(r => new {r.Airline, r.Person});
        }*/
    }
}
