namespace MDIManage
{
	partial class FrmLogin
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
			label2 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(17, 32);
			label1.Name = "label1";
			label1.Size = new Size(152, 41);
			label1.TabIndex = 0;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 115);
			label2.Name = "label2";
			label2.Size = new Size(143, 41);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(175, 29);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(250, 47);
			textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(175, 109);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(250, 47);
			textBox2.TabIndex = 3;
			// 
			// button1
			// 
			button1.Location = new Point(448, 35);
			button1.Name = "button1";
			button1.Size = new Size(189, 121);
			button1.TabIndex = 4;
			button1.Text = "LOGIN";
			button1.UseVisualStyleBackColor = true;
			// 
			// FrmLogin
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(677, 199);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FrmLogin";
			Text = "LOGIN";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
	}
}