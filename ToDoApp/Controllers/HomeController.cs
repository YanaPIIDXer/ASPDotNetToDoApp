using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> logger;

		private readonly ToDoContext context;

		public HomeController(ILogger<HomeController> logger, ToDoContext context)
		{
			this.logger = logger;
			this.context = context;
		}

		public IActionResult Index()
		{
			ViewBag.ToDoList = context.ToDoList;
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
