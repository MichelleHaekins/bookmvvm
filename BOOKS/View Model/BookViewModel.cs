using BOOKS.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKS.Models;
using BOOKS.Views;
using static BOOKS.View_Model.BookViewModel;
using System.Transactions;
using System.ComponentModel;
using System.Text.Json;
using System.Net.WebSockets;
namespace BOOKS.View_Model
{
	public class BookViewModel : Bindables, IBookViewModel
	{
		readonly string file = "data.json";
		public BookViewModel()
		{
			Load();
			CommandSave = new(async o =>
			{
				await Save();
				SortBooks();
				Books.ResetBindings();
				MessageBox.Show("Courses saved and sorted!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
			});
			CommandDelete = new(o =>
			{
				if (Current != null)
				{
					books.Remove(Current);
				}
			}, o => Current != null);
			CommandAdd = new(o =>
			{
				var newBook = new BookClass();
				var detailform = new BookDetails(this, newBook);
				if (detailform.ShowDialog() == DialogResult.OK)
				{
					Books.Add(newBook);
					MessageBox.Show("Book added successfully", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			});
			CommandSort = new(o => SortBooks());
			CommandEdit = new(o =>
			{
				if (Current != null)
				{
					var detailform = new BookDetails(this, Current);
					if (detailform.ShowDialog() == DialogResult.OK)
					{
						MessageBox.Show("Book Updated", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}

				}
			}, o => Current != null);
		}
		private BindingList<BookClass> books;
		public BindingList<BookClass> Books
		{
			get=> books;
			set => Set(ref books, value);
		}
		private BookClass _current;
		public BookClass Current { get => _current; set
			{
				Set(ref _current, value);
				CommandDelete.Notify();
				CommandEdit.Notify();
			}
		}
		public void SortBooks()
		{
			var sortedBooks = Books
				.OrderBy(b => b.Title)
				.ThenBy(b => b.Author)
				.ToList();

			Books.Clear();
			foreach (var book in sortedBooks)
			{
              Books.Add(book);

			}
			Books.ResetBindings();
		}
		public Command CommandSort { get; set; }	public Command CommandSave { get; set; }
		
		public Command CommandDelete { get; set; }
		public Command CommandEdit { get; set; }
		public Command CommandAdd { get; set; }

		public interface IBookViewModel
		{
			BindingList<BookClass> Books { get; }
			BookClass Current { get; set; }
			Command CommandSort { get; set; }	
			Command CommandSave { get; set; }
			Command CommandDelete { get; set; }
			Command CommandAdd { get; set; }
			public Command CommandEdit { get; set; }
			Task<IEnumerable<BookClass>> Load();
			Task Save();
		}
		public async Task<IEnumerable<BookClass>> Load()
		{
			if (!File.Exists(file))
			{
				await Save();
			}
			else
			{
				var fs = await File.ReadAllBytesAsync(file);
				books = JsonSerializer.Deserialize<BindingList<BookClass>>(fs) ?? new BindingList<BookClass>();

			}
			SortBooks();
			return books;
		}
		public async Task Save()
		{
			var json = JsonSerializer.Serialize(books);
			await File.WriteAllTextAsync(file, json);	 
		}
	}
 }
	

