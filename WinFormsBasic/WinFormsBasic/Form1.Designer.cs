namespace WinFormsBasic
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
			txtHoTen = new TextBox();
			btnChao = new Button();
			lblChao = new Label();
			btnNhapLai = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(38, 47);
			label1.Name = "label1";
			label1.Size = new Size(108, 41);
			label1.TabIndex = 0;
			label1.Text = "Họ tên";
			label1.Click += label1_Click;
			// 
			// txtHoTen
			// 
			txtHoTen.Location = new Point(318, 54);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(408, 47);
			txtHoTen.TabIndex = 1;
			// 
			// btnChao
			// 
			btnChao.Location = new Point(318, 134);
			btnChao.Name = "btnChao";
			btnChao.Size = new Size(188, 58);
			btnChao.TabIndex = 2;
			btnChao.Text = "Chào";
			btnChao.UseVisualStyleBackColor = true;
			btnChao.Click += btnChao_Click;
			// 
			// lblChao
			// 
			lblChao.AutoSize = true;
			lblChao.Location = new Point(61, 232);
			lblChao.Name = "lblChao";
			lblChao.Size = new Size(97, 41);
			lblChao.TabIndex = 3;
			lblChao.Text = "label2";
			// 
			// btnNhapLai
			// 
			btnNhapLai.Location = new Point(538, 134);
			btnNhapLai.Name = "btnNhapLai";
			btnNhapLai.Size = new Size(188, 58);
			btnNhapLai.TabIndex = 4;
			btnNhapLai.Text = "Nhập lại";
			btnNhapLai.UseVisualStyleBackColor = true;
			btnNhapLai.Click += btnNhapLai_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnNhapLai);
			Controls.Add(lblChao);
			Controls.Add(btnChao);
			Controls.Add(txtHoTen);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Chào buổi sáng";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtHoTen;
		private Button btnChao;
		private Label lblChao;
		private Button btnNhapLai;
	}
}
