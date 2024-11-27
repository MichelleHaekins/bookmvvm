using BOOKS.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKS.Models
{
	public class BookClass : Bindables
	{
		private string _isbn;
		public string ISBN { get => _isbn; set => Set(ref _isbn, value); }

		private string title;
		public string Title{ get => title; set => Set(ref title, value); }
		private string description;
		public string Description{ get => description; set =>Set(ref description, value); }

		private string author;
		public string Author{ get => author; set=> Set(ref author, value); }

		private string yop;
		public string YOP{ get => yop; set=>Set(ref yop, value); }


	}
}
