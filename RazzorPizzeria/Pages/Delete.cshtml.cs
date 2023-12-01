using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazzorPizzeria.Data;

namespace RazzorPizzeria.Pages
{
	[BindProperties(SupportsGet = true)]
	public class DeleteModel : PageModel
	{
		public int Id { get; set; }
		public bool IsDeleted { get; set; }

		private readonly ApplicationDbContext _context;

		public DeleteModel(ApplicationDbContext context)
		{
			_context = context;
		}


		public void OnGet()
		{
			var result = _context.PizzaOrders.Find(Id);
			if (result == null)
			{
				IsDeleted = false;
			}
			else
			{
				IsDeleted = true;
				_context.PizzaOrders.Remove(result);
				_context.SaveChanges();
			}
		}
	}
}
