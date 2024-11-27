namespace BOOKS.Views
{
	partial class BookDetails
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
			label1 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			tbISBN = new TextBox();
			tbYOP = new TextBox();
			tbAuthor = new TextBox();
			tbDescription = new TextBox();
			tbTitle = new TextBox();
			btnOK = new Button();
			btnCancel = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(61, 36);
			label1.Name = "label1";
			label1.Size = new Size(41, 20);
			label1.TabIndex = 0;
			label1.Text = "ISBN";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(32, 278);
			label3.Name = "label3";
			label3.Size = new Size(135, 20);
			label3.TabIndex = 2;
			label3.Text = "Year Of Publication";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(61, 207);
			label4.Name = "label4";
			label4.Size = new Size(54, 20);
			label4.TabIndex = 3;
			label4.Text = "Author";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(61, 151);
			label5.Name = "label5";
			label5.Size = new Size(85, 20);
			label5.TabIndex = 4;
			label5.Text = "Description";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(61, 91);
			label6.Name = "label6";
			label6.Size = new Size(38, 20);
			label6.TabIndex = 5;
			label6.Text = "Title";
			// 
			// tbISBN
			// 
			tbISBN.Location = new Point(173, 40);
			tbISBN.Name = "tbISBN";
			tbISBN.Size = new Size(276, 27);
			tbISBN.TabIndex = 6;
			// 
			// tbYOP
			// 
			tbYOP.Location = new Point(173, 275);
			tbYOP.Name = "tbYOP";
			tbYOP.Size = new Size(276, 27);
			tbYOP.TabIndex = 7;
			// 
			// tbAuthor
			// 
			tbAuthor.Location = new Point(173, 204);
			tbAuthor.Name = "tbAuthor";
			tbAuthor.Size = new Size(276, 27);
			tbAuthor.TabIndex = 8;
			// 
			// tbDescription
			// 
			tbDescription.Location = new Point(173, 148);
			tbDescription.Name = "tbDescription";
			tbDescription.Size = new Size(276, 27);
			tbDescription.TabIndex = 9;
			// 
			// tbTitle
			// 
			tbTitle.Location = new Point(173, 84);
			tbTitle.Name = "tbTitle";
			tbTitle.Size = new Size(276, 27);
			tbTitle.TabIndex = 10;
			// 
			// btnOK
			// 
			btnOK.Location = new Point(114, 362);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(94, 29);
			btnOK.TabIndex = 11;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(311, 362);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(94, 29);
			btnCancel.TabIndex = 12;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// BookDetails
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			Controls.Add(tbTitle);
			Controls.Add(tbDescription);
			Controls.Add(tbAuthor);
			Controls.Add(tbYOP);
			Controls.Add(tbISBN);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label1);
			Name = "BookDetails";
			Text = "BookDetails";
			Load += BookDetails_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox tbISBN;
		private TextBox tbYOP;
		private TextBox tbAuthor;
		private TextBox tbDescription;
		private TextBox tbTitle;
		private Button btnOK;
		private Button btnCancel;
	}
}