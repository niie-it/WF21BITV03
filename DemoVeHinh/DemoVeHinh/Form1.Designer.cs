namespace DemoVeHinh
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
			BtnChonMau = new Button();
			panel1 = new Panel();
			TxtNoiDung = new TextBox();
			BtnVeChu = new Button();
			label1 = new Label();
			label2 = new Label();
			TxtX = new TextBox();
			TxtY = new TextBox();
			SuspendLayout();
			// 
			// BtnChonMau
			// 
			BtnChonMau.BackColor = Color.Black;
			BtnChonMau.Location = new Point(47, 38);
			BtnChonMau.Name = "BtnChonMau";
			BtnChonMau.Size = new Size(188, 58);
			BtnChonMau.TabIndex = 0;
			BtnChonMau.UseVisualStyleBackColor = false;
			BtnChonMau.Click += BtnChonMau_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Location = new Point(310, 22);
			panel1.Name = "panel1";
			panel1.Size = new Size(1138, 823);
			panel1.TabIndex = 1;
			// 
			// TxtNoiDung
			// 
			TxtNoiDung.Location = new Point(23, 272);
			TxtNoiDung.Name = "TxtNoiDung";
			TxtNoiDung.Size = new Size(250, 47);
			TxtNoiDung.TabIndex = 2;
			// 
			// BtnVeChu
			// 
			BtnVeChu.Location = new Point(23, 344);
			BtnVeChu.Name = "BtnVeChu";
			BtnVeChu.Size = new Size(250, 58);
			BtnVeChu.TabIndex = 3;
			BtnVeChu.Text = "Vẽ chữ";
			BtnVeChu.UseVisualStyleBackColor = true;
			BtnVeChu.Click += BtnVeChu_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 130);
			label1.Name = "label1";
			label1.Size = new Size(36, 41);
			label1.TabIndex = 4;
			label1.Text = "X";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(23, 196);
			label2.Name = "label2";
			label2.Size = new Size(35, 41);
			label2.TabIndex = 4;
			label2.Text = "Y";
			// 
			// TxtX
			// 
			TxtX.Location = new Point(102, 130);
			TxtX.Name = "TxtX";
			TxtX.Size = new Size(79, 47);
			TxtX.TabIndex = 5;
			// 
			// TxtY
			// 
			TxtY.Location = new Point(102, 193);
			TxtY.Name = "TxtY";
			TxtY.Size = new Size(79, 47);
			TxtY.TabIndex = 6;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1460, 857);
			Controls.Add(TxtY);
			Controls.Add(TxtX);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(BtnVeChu);
			Controls.Add(TxtNoiDung);
			Controls.Add(panel1);
			Controls.Add(BtnChonMau);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button BtnChonMau;
		private Panel panel1;
		private TextBox TxtNoiDung;
		private Button BtnVeChu;
		private Label label1;
		private Label label2;
		private TextBox TxtX;
		private TextBox TxtY;
	}
}
