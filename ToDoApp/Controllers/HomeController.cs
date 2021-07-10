using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;
using Microsoft.EntityFrameworkCore;

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
			return View(context.ToDoList);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id", "Title", "Body", "Date")] ToDoInfo info)
		{
			if (ModelState.IsValid)
			{
				context.Add(info);
				await context.SaveChangesAsync();
			}
			return RedirectToAction("Index");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Delete(int id)
		{
			var info = await context.ToDoList.FindAsync(id);
			context.ToDoList.Remove(info);
			await context.SaveChangesAsync();

			return RedirectToAction("Index");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
