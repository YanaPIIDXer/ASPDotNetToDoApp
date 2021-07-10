using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp.Views.Home
{
    public class ToDoController : Controller
    {
        private readonly ToDoContext _context;

        public ToDoController(ToDoContext context)
        {
            _context = context;
        }

        // GET: ToDo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ToDo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Body,Date,Priority")] ToDoInfo toDoInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(toDoInfo);
                await _context.SaveChangesAsync();
            }
            return Redirect("/");
        }

        // GET: ToDo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toDoInfo = await _context.ToDoList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (toDoInfo == null)
            {
                return NotFound();
            }

            return View(toDoInfo);
        }

        // POST: ToDo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var toDoInfo = await _context.ToDoList.FindAsync(id);
            _context.ToDoList.Remove(toDoInfo);
            await _context.SaveChangesAsync();
            return Redirect("/");
        }

        private bool ToDoInfoExists(int id)
        {
            return _context.ToDoList.Any(e => e.Id == id);
        }
    }
}
