using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NetcoreTraining.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[JsonPropertyName("desc")]
		public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

	}
}

