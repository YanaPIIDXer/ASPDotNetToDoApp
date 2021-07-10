using System;

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
}
