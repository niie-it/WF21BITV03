namespace Lab04_BT01_TinhTong
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
			label1 = new Label();
			label2 = new Label();
			txtN = new TextBox();
			txtTong = new TextBox();
			btnTinh = new Button();
			btnThoat = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 12F);
			label1.Location = new Point(52, 71);
			label1.Name = "label1";
			label1.Size = new Size(161, 46);
			label1.TabIndex = 0;
			label1.Text = "Giá trị N";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 12F);
			label2.Location = new Point(56, 142);
			label2.Name = "label2";
			label2.Size = new Size(102, 46);
			label2.TabIndex = 1;
			label2.Text = "Tổng";
			// 
			// txtN
			// 
			txtN.Font = new Font("Times New Roman", 12F);
			txtN.Location = new Point(226, 76);
			txtN.Name = "txtN";
			txtN.Size = new Size(458, 53);
			txtN.TabIndex = 2;
			// 
			// txtTong
			// 
			txtTong.Font = new Font("Times New Roman", 12F);
			txtTong.ForeColor = Color.Blue;
			txtTong.Location = new Point(226, 151);
			txtTong.Name = "txtTong";
			txtTong.ReadOnly = true;
			txtTong.Size = new Size(458, 53);
			txtTong.TabIndex = 3;
			// 
			// btnTinh
			// 
			btnTinh.Font = new Font("Times New Roman", 12F);
			btnTinh.Location = new Point(99, 263);
			btnTinh.Name = "btnTinh";
			btnTinh.Size = new Size(188, 58);
			btnTinh.TabIndex = 4;
			btnTinh.Text = "Tính";
			btnTinh.UseVisualStyleBackColor = true;
			btnTinh.Click += btnTinh_Click;
			// 
			// btnThoat
			// 
			btnThoat.Font = new Font("Times New Roman", 12F);
			btnThoat.Location = new Point(342, 263);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(188, 58);
			btnThoat.TabIndex = 5;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnThoat);
			Controls.Add(btnTinh);
			Controls.Add(txtTong);
			Controls.Add(txtN);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtN;
		private TextBox txtTong;
		private Button btnTinh;
		private Button btnThoat;
	}
}
