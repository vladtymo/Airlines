namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using DAL.Models;

    public class AirlinesDbContext : DbContext
    {
        public AirlinesDbContext()
            : base("name=AirlinesDbContext")
        {
            Database.SetInitializer(new Initializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Явне налаштування зв'язків використовуючи FluentAPI
            modelBuilder.Entity<Flight>().HasRequired(flight => flight.CityFrom)
                                         .WithMany(city => city.FlightsFrom)
                                         .HasForeignKey(flight => flight.CityFromId)
                                         .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flight>().HasRequired(flight => flight.CityTo)
                                         .WithMany(city => city.FlightsTo)
                                         .HasForeignKey(flight => flight.CityToId)
                                          .WillCascadeOnDelete(false);
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Models.Type> Types { get; set; }
        public virtual DbSet<Airplane> Airplanes { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
    }
}