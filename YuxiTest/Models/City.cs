using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YuxiTest.Models
{
	public class City
	{
		public City()
		{
            Name = string.Empty;
			Country = new Country();
		}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		public string Name { get; set; }
		public Country Country { get; set; }
	}
}

