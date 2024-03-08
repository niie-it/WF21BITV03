namespace Lab03BT01
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			BtnAdd = new Button();
			BtnClear = new Button();
			btnClose = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			CboTitle = new ComboBox();
			TxtFirstName = new TextBox();
			txtLastName = new TextBox();
			LstDanhSach = new ListBox();
			BtnSaveToFile = new Button();
			SuspendLayout();
			// 
			// BtnAdd
			// 
			BtnAdd.Font = new Font("Tahoma", 12F);
			BtnAdd.Location = new Point(57, 39);
			BtnAdd.Name = "BtnAdd";
			BtnAdd.Size = new Size(278, 95);
			BtnAdd.TabIndex = 0;
			BtnAdd.Text = "Add Name";
			BtnAdd.UseVisualStyleBackColor = true;
			BtnAdd.Click += BtnAdd_Click;
			// 
			// BtnClear
			// 
			BtnClear.Font = new Font("Tahoma", 12F);
			BtnClear.Location = new Point(755, 39);
			BtnClear.Name = "BtnClear";
			BtnClear.Size = new Size(208, 95);
			BtnClear.TabIndex = 0;
			BtnClear.Text = "Clear";
			BtnClear.UseVisualStyleBackColor = true;
			BtnClear.Click += BtnClear_Click;
			// 
			// btnClose
			// 
			btnClose.Font = new Font("Tahoma", 12F);
			btnClose.Location = new Point(1006, 39);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(208, 95);
			btnClose.TabIndex = 0;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F);
			label1.Location = new Point(57, 208);
			label1.Name = "label1";
			label1.Size = new Size(95, 48);
			label1.TabIndex = 1;
			label1.Text = "Title";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F);
			label2.Location = new Point(515, 208);
			label2.Name = "label2";
			label2.Size = new Size(206, 48);
			label2.TabIndex = 2;
			label2.Text = "First name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 12F);
			label3.Location = new Point(908, 208);
			label3.Name = "label3";
			label3.Size = new Size(203, 48);
			label3.TabIndex = 3;
			label3.Text = "Last name";
			// 
			// CboTitle
			// 
			CboTitle.Font = new Font("Tahoma", 12F);
			CboTitle.FormattingEnabled = true;
			CboTitle.Items.AddRange(new object[] { "Mr.", "Miss.", "Mrs.", "Dr." });
			CboTitle.Location = new Point(57, 285);
			CboTitle.Name = "CboTitle";
			CboTitle.Size = new Size(302, 56);
			CboTitle.TabIndex = 4;
			// 
			// TxtFirstName
			// 
			TxtFirstName.Font = new Font("Tahoma", 12F);
			TxtFirstName.Location = new Point(515, 285);
			TxtFirstName.Name = "TxtFirstName";
			TxtFirstName.Size = new Size(326, 56);
			TxtFirstName.TabIndex = 5;
			// 
			// txtLastName
			// 
			txtLastName.Font = new Font("Tahoma", 12F);
			txtLastName.Location = new Point(907, 293);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(310, 56);
			txtLastName.TabIndex = 6;
			// 
			// LstDanhSach
			// 
			LstDanhSach.Font = new Font("Tahoma", 12F);
			LstDanhSach.FormattingEnabled = true;
			LstDanhSach.ItemHeight = 48;
			LstDanhSach.Location = new Point(57, 375);
			LstDanhSach.Name = "LstDanhSach";
			LstDanhSach.Size = new Size(1160, 244);
			LstDanhSach.TabIndex = 7;
			// 
			// BtnSaveToFile
			// 
			BtnSaveToFile.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnSaveToFile.Location = new Point(421, 39);
			BtnSaveToFile.Name = "BtnSaveToFile";
			BtnSaveToFile.Size = new Size(277, 95);
			BtnSaveToFile.TabIndex = 8;
			BtnSaveToFile.Text = "Save to File";
			BtnSaveToFile.UseVisualStyleBackColor = true;
			BtnSaveToFile.Click += BtnSaveToFile_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1304, 658);
			Controls.Add(BtnSaveToFile);
			Controls.Add(LstDanhSach);
			Controls.Add(txtLastName);
			Controls.Add(TxtFirstName);
			Controls.Add(CboTitle);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnClose);
			Controls.Add(BtnClear);
			Controls.Add(BtnAdd);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button BtnAdd;
		private Button BtnClear;
		private Button btnClose;
		private Label label1;
		private Label label2;
		private Label label3;
		private ComboBox CboTitle;
		private TextBox TxtFirstName;
		private TextBox txtLastName;
		private ListBox LstDanhSach;
		private Button BtnSaveToFile;
	}
}
