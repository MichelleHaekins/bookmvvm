using BOOKS.Models;
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
	public partial class MainForm : Form
	{
		private readonly IBookViewModel _viewModel;
		readonly BindingSource _bindingSource;
		public MainForm(IBookViewModel vm)
		{
			InitializeComponent();
			_viewModel = vm;	
			_bindingSource = new BindingSource();
			dgvBook.DataSource = vm.Books;
			_bindingSource.DataSource = vm.Books;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			dgvBook.SelectionChanged += delegate
			{
				_viewModel.Current = dgvBook.CurrentRow?.DataBoundItem as BookClass;
			};
			btnAdd.Command = _viewModel.CommandAdd;
			btnEdit.Command = _viewModel.CommandEdit;	  
			btnDelete.Command = _viewModel.CommandDelete;	
			btnSave.Command = _viewModel.CommandSave;
		}
	}
}
