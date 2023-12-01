using Microsoft.AspNetCore.Mvc.RazorPages;
using RazzorPizzeria.Data;
using RazzorPizzeria.Models;

namespace RazzorPizzeria.Pages
{
	public class OrdersModel : PageModel
	{
		public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();
		private readonly ApplicationDbContext _context;
		public OrdersModel(ApplicationDbContext context)
		{
			_context = context;
		}
		public void OnGet()
		{
			PizzaOrders = _context.PizzaOrders.ToList();
		}
	}
}
