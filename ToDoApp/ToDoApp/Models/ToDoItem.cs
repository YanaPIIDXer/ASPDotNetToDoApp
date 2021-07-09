using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Models
{
	/// <summary>
	/// TODO項目
	/// </summary>
	public class ToDoItem
	{
		/// <summary>
		/// ID
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// タイトル
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// 本文
		/// </summary>
		public string Body { get; set; }

		/// <summary>
		/// 日付
		/// </summary>
		public DateTime Date { get; set; }
	}

	/// <summary>
	/// ToDoItemコンテキストクラス
	/// </summary>
	public class TodoContext : DbContext
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="options">コンテキストオプション</param>
		public TodoContext(DbContextOptions<TodoContext> options)
			: base(options)
		{
		}

		/// <summary>
		/// TODOリスト
		/// </summary>
		public DbSet<ToDoItem> ToDoList { get; set; }
	}
}
