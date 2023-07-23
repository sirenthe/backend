//using System.Runtime.CompilerServices;
//using Microsoft.AspNetCore.Mvc;
//using P330Pronia.Contexts;

//namespace P330Pronia.Controllers
//{
//	public class HomeController : Controller
//	{
//		private readonly AppDbContext _context;
//		public HomeController(AppDbContext context)
//		{
//			_context = context;
//		}
//		public IActionResult Index()


//		{
//			var sliders = _context.Sliders;
//			return View(sliders);

//		}

//		public IActionResult Index2()


//		{
//			var cards = _context.cards;
//			return View(cards);
//		}
//	}
//}
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using P330Pronia.Contexts;
using P330Pronia.Models;

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
			var viewModel = new MyViewModel
			{
				Sliders = _context.Sliders,
				Cards = _context.cards
			};

			return View(viewModel);
		}
	}
}



