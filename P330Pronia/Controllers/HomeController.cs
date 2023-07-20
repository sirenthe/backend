using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using P330Pronia.Contexts;

namespace P330Pronia.Controllers
{
	public class HomeController : Controller
	{ 
		private readonly AppDbContext _context;
		public HomeController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()

			
		{
			var sliders = _context.Sliders;
			return View(sliders);
		}
	}
}
