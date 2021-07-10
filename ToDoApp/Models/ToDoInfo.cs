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
	/// 優先度
	/// </summary>
	public class Priority
	{
		public int Id { get; set; }
		public string Name { get; set; }
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

		public DbSet<Priority> Priorities { get; set; }
	}
}
