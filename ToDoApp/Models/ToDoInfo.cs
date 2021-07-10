using System;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Models
{
	/// <summary>
	/// TODO情報
	/// </summary>
	public class ToDoInfo
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
		public DateTime Date { get; set; }
	}

	/// <summary>
	/// ToDoInfo コンテキストクラス
	/// </summary>
	public class ToDoContext : DbContext
	{
		public ToDoContext(DbContextOptions<ToDoContext> options)
			: base(options)
		{
		}

		public DbSet<ToDoInfo> ToDoList { get; set; }
	}
}