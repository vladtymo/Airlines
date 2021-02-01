using System.Data.Entity;
using DAL.Models;

namespace DAL
{
    internal class Initializer : CreateDatabaseIfNotExists<AirlinesDbContext>
    {
        protected override void Seed(AirlinesDbContext context)
        {
            base.Seed(context);

            Type type1 = context.Types.Add(new Models.Type() { Name = "Commercial" });
            Type type2 = context.Types.Add(new Models.Type() { Name = "Jets" });
            Type type3 = context.Types.Add(new Models.Type() { Name = "Props" });
            context.SaveChanges();

            Country ua = context.Countries.Add(new Models.Country() { Name = "Ukraine" });
            Country pl = context.Countries.Add(new Models.Country() { Name = "Poland" });
            Country tr = context.Countries.Add(new Models.Country() { Name = "Turkey" });
            Country usa = context.Countries.Add(new Models.Country() { Name = "United States" });
            Country fr = context.Countries.Add(new Models.Country() { Name = "France" });
            context.SaveChanges();

            City kyiv = context.Cities.Add(new City() { Name = "Kyiv", CountryId = ua.Id });
            City lviv = context.Cities.Add(new City() { Name = "Lviv", CountryId = ua.Id });
            City rivne = context.Cities.Add(new City() { Name = "Rivne", CountryId = ua.Id });
            City warsaw = context.Cities.Add(new City() { Name = "Warsaw", CountryId = pl.Id });
            City krakow = context.Cities.Add(new City() { Name = "Kraków", CountryId = pl.Id });
            City istanbul = context.Cities.Add(new City() { Name = "İstanbul", CountryId = tr.Id });
            City ankara = context.Cities.Add(new City() { Name = "Ankara", CountryId = tr.Id });
            context.SaveChanges();

            Airplane airplane1 = context.Airplanes.Add(new Airplane()
            {
                Model = "Boeing 787",
                CountryId = usa.Id,
                MaxPassengers = 287,
                TypeId = type1.Id
            });
            Airplane airplane2 = context.Airplanes.Add(new Airplane()
            {
                Model = "Airbus A320",
                CountryId = fr.Id,
                MaxPassengers = 256,
                TypeId = type1.Id
            });
            context.SaveChanges();

            context.Flights.Add(new Flight()
            {
                DepartureTime = System.DateTime.Now,
                AirplaneId = airplane1.Id,
                CityFromId = kyiv.Id,
                CityToId = ankara.Id
            });
            context.Flights.Add(new Flight()
            {
                DepartureTime = System.DateTime.Now,
                AirplaneId = airplane1.Id,
                CityFromId = lviv.Id,
                CityToId = krakow.Id
            });
            context.Flights.Add(new Flight()
            {
                DepartureTime = System.DateTime.Now,
                AirplaneId = airplane2.Id,
                CityFromId = warsaw.Id,
                CityToId = istanbul.Id
            });
            context.SaveChanges();
        }
    }
}