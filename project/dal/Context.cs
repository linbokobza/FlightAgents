using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using project.Models;

namespace project.dal
{
    public class Context : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Flight>().ToTable("tblFlight");
            modelBuilder.Entity<FlightBooking>().ToTable("tblFlightBooking");
            modelBuilder.Entity<Users>().ToTable("tblUsers");
            modelBuilder.Entity<CreditCard>().ToTable("tblCreditCard");
        }
        public DbSet<Flight> flights { get; set; }
        public DbSet<FlightBooking> flightBooking { get; set; }
        public DbSet<Users> user { get; set; }
        public DbSet<CreditCard> CD { get; set; }

    }
}