namespace Lab04_BT04_TongHonHop
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
			txtX = new TextBox();
			btnTinh = new Button();
			btnNhapLai = new Button();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			txtS1 = new TextBox();
			txtS2 = new TextBox();
			txtS3 = new TextBox();
			txtS4 = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(32, 32);
			label1.Name = "label1";
			label1.Size = new Size(133, 41);
			label1.TabIndex = 0;
			label1.Text = "Số mũ N";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(32, 113);
			label2.Name = "label2";
			label2.Size = new Size(122, 41);
			label2.TabIndex = 1;
			label2.Text = "Giá trị X";
			// 
			// txtN
			// 
			txtN.Location = new Point(237, 43);
			txtN.Name = "txtN";
			txtN.Size = new Size(511, 47);
			txtN.TabIndex = 2;
			// 
			// txtX
			// 
			txtX.Location = new Point(237, 107);
			txtX.Name = "txtX";
			txtX.Size = new Size(511, 47);
			txtX.TabIndex = 3;
			// 
			// btnTinh
			// 
			btnTinh.Location = new Point(237, 177);
			btnTinh.Name = "btnTinh";
			btnTinh.Size = new Size(194, 108);
			btnTinh.TabIndex = 4;
			btnTinh.Text = "Tính";
			btnTinh.UseVisualStyleBackColor = true;
			btnTinh.Click += btnTinh_Click;
			// 
			// btnNhapLai
			// 
			btnNhapLai.Location = new Point(475, 184);
			btnNhapLai.Name = "btnNhapLai";
			btnNhapLai.Size = new Size(207, 98);
			btnNhapLai.TabIndex = 5;
			btnNhapLai.Text = "Nhập loại";
			btnNhapLai.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(46, 337);
			label3.Name = "label3";
			label3.Size = new Size(63, 41);
			label3.TabIndex = 6;
			label3.Text = "S =";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(49, 410);
			label4.Name = "label4";
			label4.Size = new Size(71, 41);
			label4.TabIndex = 7;
			label4.Text = "S = ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(46, 493);
			label5.Name = "label5";
			label5.Size = new Size(71, 41);
			label5.TabIndex = 8;
			label5.Text = "S = ";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(49, 575);
			label6.Name = "label6";
			label6.Size = new Size(71, 41);
			label6.TabIndex = 9;
			label6.Text = "S = ";
			// 
			// txtS1
			// 
			txtS1.Location = new Point(237, 337);
			txtS1.Name = "txtS1";
			txtS1.Size = new Size(511, 47);
			txtS1.TabIndex = 10;
			// 
			// txtS2
			// 
			txtS2.Location = new Point(237, 421);
			txtS2.Name = "txtS2";
			txtS2.Size = new Size(511, 47);
			txtS2.TabIndex = 11;
			// 
			// txtS3
			// 
			txtS3.Location = new Point(237, 492);
			txtS3.Name = "txtS3";
			txtS3.Size = new Size(511, 47);
			txtS3.TabIndex = 12;
			// 
			// txtS4
			// 
			txtS4.Location = new Point(237, 577);
			txtS4.Name = "txtS4";
			txtS4.Size = new Size(511, 47);
			txtS4.TabIndex = 13;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 649);
			Controls.Add(txtS4);
			Controls.Add(txtS3);
			Controls.Add(txtS2);
			Controls.Add(txtS1);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(btnNhapLai);
			Controls.Add(btnTinh);
			Controls.Add(txtX);
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
		private TextBox txtX;
		private Button btnTinh;
		private Button btnNhapLai;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox txtS1;
		private TextBox txtS2;
		private TextBox txtS3;
		private TextBox txtS4;
	}
}
