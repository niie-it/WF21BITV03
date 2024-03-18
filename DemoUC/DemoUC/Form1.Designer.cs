namespace DemoUC
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
			ucLogin1 = new UCLogin();
			button1 = new Button();
			SuspendLayout();
			// 
			// ucLogin1
			// 
			ucLogin1.Location = new Point(12, 12);
			ucLogin1.Name = "ucLogin1";
			ucLogin1.Size = new Size(685, 216);
			ucLogin1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(358, 305);
			button1.Name = "button1";
			button1.Size = new Size(303, 115);
			button1.TabIndex = 1;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(ucLogin1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private UCLogin ucLogin1;
		private Button button1;
	}
}
