namespace BOOKS.Views
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnSave = new Button();
			btnEdit = new Button();
			btnDelete = new Button();
			btnAdd = new Button();
			dgvBook = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
			SuspendLayout();
			// 
			// btnSave
			// 
			btnSave.Location = new Point(491, 8);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(243, 41);
			btnSave.TabIndex = 9;
			btnSave.Text = "Sort and Save";
			btnSave.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(281, 448);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(232, 41);
			btnEdit.TabIndex = 8;
			btnEdit.Text = "Edit Book";
			btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(545, 448);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(243, 41);
			btnDelete.TabIndex = 7;
			btnDelete.Text = "Delete Book";
			btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(12, 448);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(230, 41);
			btnAdd.TabIndex = 6;
			btnAdd.Text = "Add Book";
			btnAdd.UseVisualStyleBackColor = true;
			// 
			// dgvBook
			// 
			dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvBook.Location = new Point(44, 55);
			dgvBook.Name = "dgvBook";
			dgvBook.RowHeadersWidth = 51;
			dgvBook.Size = new Size(744, 387);
			dgvBook.TabIndex = 5;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(812, 503);
			Controls.Add(btnSave);
			Controls.Add(btnEdit);
			Controls.Add(btnDelete);
			Controls.Add(btnAdd);
			Controls.Add(dgvBook);
			Name = "MainForm";
			Text = "MainForm";
			Load += MainForm_Load;
			((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnSave;
		private Button btnEdit;
		private Button btnDelete;
		private Button btnAdd;
		private DataGridView dgvBook;
	}
}