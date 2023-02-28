using YuxiTest.Models;

namespace YuxiTest.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LocationContext context)
        {
            //Look for Countries
            if (context.Country.Any())
            {
                return; //DB has been seeded
            }

            //Insert countries
            var ecu = new Country { Name = "Ecuador" };
            var countries = new Country[]
            {
                ecu
            };

            context.Country.AddRange(countries);

            //Insert cities
            var uio = new City { Name = "Quito", Country = ecu };
            var gye = new City { Name = "Guayaquil", Country = ecu };
            var cue = new City { Name = "Cuenca", Country = ecu };
            var amb = new City { Name = "Ambato", Country = ecu };
            var iba = new City { Name = "Ibarra", Country = ecu };
            var sto = new City { Name = "Santo Domingo", Country = ecu };
            var tna = new City { Name = "Tena", Country = ecu };
            var que = new City { Name = "Quevedo", Country = ecu };

            var cities = new City[]
            {
                uio, gye, cue, amb, iba, sto, tna, que
            };

            context.City.AddRange(cities);

            //Insert locations
            var locations = new Location[]
            {
                new Location{
                    Name = "Gergina Chicago Style",
                    City = uio,
                    Type = LocationType.Restaurant,
                    OpenTime = new TimeSpan(8,00,00),
                    CloseTime = new TimeSpan(18,00,00),
                    Latitude = -0.20327635754713305,
                    Longitude = -78.48067053823242
                },
                new Location{
                    Name = "Barbería Edibert",
                    City = gye,
                    Type = LocationType.BarberShop,
                    OpenTime = new TimeSpan(9,00,00),
                    CloseTime = new TimeSpan(19,00,00),
                    Latitude = -2.1402317464523337,
                    Longitude = -79.89040579480778
                },
                new Location{
                    Name = "Panaderia el clásico",
                    City = cue,
                    Type = LocationType.Bakery,
                    OpenTime = new TimeSpan(6,00,00),
                    CloseTime = new TimeSpan(17,00,00),
                    Latitude = -2.1875733301675164,
                    Longitude = -79.92782807713299
                },
                new Location{
                    Name = "Tecni Carr",
                    City = amb,
                    Type = LocationType.Mechanic,
                    OpenTime = new TimeSpan(10,00,00),
                    CloseTime = new TimeSpan(20,00,00),
                    Latitude = -1.2581895717715845,
                    Longitude = -78.62173673990783
                },
                new Location{
                    Name = "Cafe Mediterraneo",
                    City = iba,
                    Type = LocationType.CoffeeShop,
                    OpenTime = new TimeSpan(6,00,00),
                    CloseTime = new TimeSpan(9,00,00),
                    Latitude = 0.3382468190500194,
                    Longitude = -78.12276858968981
                },
                new Location{
                    Name = "Sabores Grill",
                    City = sto,
                    Type = LocationType.Restaurant,
                    OpenTime = new TimeSpan(15,00,00),
                    CloseTime = new TimeSpan(21,00,00),
                    Latitude = -0.24598872030973326,
                    Longitude = -79.15289068095773
                },
                new Location{
                    Name = "Tiendas Económicas",
                    City = tna,
                    Type = LocationType.SuperMarket,
                    OpenTime = new TimeSpan(5,00,00),
                    CloseTime = new TimeSpan(20,00,00),
                    Latitude = -0.09770480755937155,
                    Longitude = -78.44986882050318
                },
                new Location{
                    Name = "Michelits",
                    City = uio,
                    Type = LocationType.Restaurant,
                    OpenTime = new TimeSpan(18,00,00),
                    CloseTime = new TimeSpan(23,00,00),
                    Latitude = -0.12619614477547897,
                    Longitude = -78.50198850064072
                },
                new Location{
                    Name = "Supercines Quevedo",
                    City = que,
                    Type = LocationType.Cinema,
                    OpenTime = new TimeSpan(14,00,00),
                    CloseTime = new TimeSpan(21,00,00),
                    Latitude = -1.0094874101919342,
                    Longitude = -79.46927135812912
                },
                new Location{
                    Name = "Dulcería la Palma",
                    City = gye,
                    Type = LocationType.CandyStore,
                    OpenTime = new TimeSpan(9,00,00),
                    CloseTime = new TimeSpan(17,00,00),
                    Latitude = -2.1712958836000342,
                    Longitude = -79.88077171315092
                }
            };

            context.Location.AddRange(locations);
            context.SaveChanges();
        }
    }
}