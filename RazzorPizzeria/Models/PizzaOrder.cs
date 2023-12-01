using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazzorPizzeria.Models
{
	[Table("PizzaTable", Schema = "PruebaAPI")]
	public class PizzaOrder
	{
		[Key]
		public int Id { get; set; }
		public string PizzaName { get; set; }
		public float BasePrice { get; set; }
	}
}
