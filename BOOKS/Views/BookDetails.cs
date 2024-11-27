using BOOKS.Models;
using BOOKS.View_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BOOKS.View_Model.BookViewModel;
namespace BOOKS.Views
{
	public partial class BookDetails : Form
	{
		private BookViewModel _viewModel;
		public BookClass BookClass { get; set; }

		public BookDetails(IBookViewModel vm, BookClass book)
		{
			InitializeComponent();
			vm = _viewModel;
			BookClass = book;
			tbAuthor.DataBindings.Add("Text", BookClass, "Author");
			tbDescription.DataBindings.Add("Text", BookClass, "Description");
			tbISBN.DataBindings.Add("Text", BookClass, "ISBN");
			tbTitle.DataBindings.Add("Text", BookClass, "Title");
			tbYOP.DataBindings.Add("Text", BookClass, "YOP");
		}

		private void BookDetails_Load(object sender, EventArgs e)
		{

		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (BookClass == null)
			{
				BookClass = new BookClass();
			}
			BookClass.Title = tbTitle.Text;
			BookClass.Description = tbDescription.Text;
			BookClass.Author = tbAuthor.Text;
			BookClass.YOP = tbYOP.Text;
			BookClass.ISBN = tbISBN.Text;
			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
