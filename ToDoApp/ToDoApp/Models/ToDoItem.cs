using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

		/// <summary>
		/// モックデータを作成
		/// </summary>
		/// <returns>モックデータ配列</returns>
		public static ToDoItem[] CreateMockData()
		{
			return new ToDoItem[]
			{
				new ToDoItem()
				{
					Id = 1,
					Title = "Title1",
					Body = "Body1",
					Date = DateTime.Now
				},
				new ToDoItem()
				{
					Id = 2,
					Title = "Title2",
					Body = "Body2",
					Date = DateTime.Now
				},
				new ToDoItem()
				{
					Id = 3,
					Title = "Title3",
					Body = "Body3",
					Date = DateTime.Now
				},
				new ToDoItem()
				{
					Id = 4,
					Title = "Title4",
					Body = "Body4",
					Date = DateTime.Now
				},
				new ToDoItem()
				{
					Id = 5,
					Title = "Title5",
					Body = "Body5",
					Date = DateTime.Now
				},
			};
		}
	}
}
