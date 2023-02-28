using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YuxiTest.Models
{
	public class Country
	{
		public Country()
		{
			Name = string.Empty;
		}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		public string Name { get; set; }
	}
}

