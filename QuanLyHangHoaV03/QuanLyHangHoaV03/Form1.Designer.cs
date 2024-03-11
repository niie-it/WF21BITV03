namespace QuanLyHangHoaV03
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
			CboHangHoa = new ComboBox();
			numericUpDown1 = new NumericUpDown();
			button1 = new Button();
			button2 = new Button();
			LblDonGia = new Label();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// CboHangHoa
			// 
			CboHangHoa.DropDownStyle = ComboBoxStyle.DropDownList;
			CboHangHoa.FormattingEnabled = true;
			CboHangHoa.Location = new Point(12, 33);
			CboHangHoa.Name = "CboHangHoa";
			CboHangHoa.Size = new Size(345, 49);
			CboHangHoa.TabIndex = 1;
			CboHangHoa.SelectedIndexChanged += CboHangHoa_SelectedIndexChanged;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(372, 33);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(131, 47);
			numericUpDown1.TabIndex = 2;
			// 
			// button1
			// 
			button1.Location = new Point(520, 27);
			button1.Name = "button1";
			button1.Size = new Size(188, 58);
			button1.TabIndex = 3;
			button1.Text = "Thêm";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(737, 27);
			button2.Name = "button2";
			button2.Size = new Size(188, 58);
			button2.TabIndex = 4;
			button2.Text = "Bớt";
			button2.UseVisualStyleBackColor = true;
			// 
			// LblDonGia
			// 
			LblDonGia.AutoSize = true;
			LblDonGia.Location = new Point(15, 104);
			LblDonGia.Name = "LblDonGia";
			LblDonGia.Size = new Size(61, 41);
			LblDonGia.TabIndex = 5;
			LblDonGia.Text = "Giá";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(15, 184);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 102;
			dataGridView1.Size = new Size(920, 254);
			dataGridView1.TabIndex = 6;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(947, 450);
			Controls.Add(dataGridView1);
			Controls.Add(LblDonGia);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(numericUpDown1);
			Controls.Add(CboHangHoa);
			Name = "Form1";
			Text = "QUẢN LÝ HÀNG HÓA";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox CboHangHoa;
		private NumericUpDown numericUpDown1;
		private Button button1;
		private Button button2;
		private Label label1;
		private DataGridView dataGridView1;
		private Label LblDonGia;
	}
}
