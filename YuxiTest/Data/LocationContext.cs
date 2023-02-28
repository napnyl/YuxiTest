using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using YuxiTest.Models;

namespace YuxiTest.Data
{
	public class LocationContext : DbContext
    {
		public LocationContext(DbContextOptions<LocationContext> options) : base(options)
        {
		}

        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Location> Location { get; set; }

    }
}

