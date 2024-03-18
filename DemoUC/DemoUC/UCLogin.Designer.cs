namespace DemoUC
{
	partial class UCLogin
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLogin));
			label1 = new Label();
			TxtUsername = new TextBox();
			label2 = new Label();
			TxtPassword = new TextBox();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F);
			label1.Location = new Point(57, 36);
			label1.Name = "label1";
			label1.Size = new Size(197, 48);
			label1.TabIndex = 0;
			label1.Text = "Username";
			// 
			// TxtUsername
			// 
			TxtUsername.Font = new Font("Tahoma", 12F);
			TxtUsername.Location = new Point(269, 28);
			TxtUsername.Name = "TxtUsername";
			TxtUsername.Size = new Size(378, 56);
			TxtUsername.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F);
			label2.Location = new Point(57, 129);
			label2.Name = "label2";
			label2.Size = new Size(187, 48);
			label2.TabIndex = 0;
			label2.Text = "Password";
			// 
			// TxtPassword
			// 
			TxtPassword.Font = new Font("Tahoma", 12F);
			TxtPassword.Location = new Point(269, 121);
			TxtPassword.Name = "TxtPassword";
			TxtPassword.PasswordChar = '$';
			TxtPassword.Size = new Size(378, 56);
			TxtPassword.TabIndex = 2;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(3, 28);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(67, 72);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			// 
			// UCLogin
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(pictureBox1);
			Controls.Add(TxtPassword);
			Controls.Add(TxtUsername);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "UCLogin";
			Size = new Size(679, 220);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox TxtUsername;
		private Label label2;
		private TextBox TxtPassword;
		private PictureBox pictureBox1;
	}
}
