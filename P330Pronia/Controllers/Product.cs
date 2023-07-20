using Microsoft.AspNetCore.Mvc;

namespace P330Pronia.Controllers
{
	public class Product : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
