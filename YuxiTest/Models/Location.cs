using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YuxiTest.Models
{
	public class Location
	{
		public Location()
		{
			Name = string.Empty;
			City = new City();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		public string Name { get; set; }
		public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
		public City City { get; set; }
		public double Latitude { get; set; }
		public double Longitude{ get; set; }
		public LocationType Type { get; set; }
	}
}

