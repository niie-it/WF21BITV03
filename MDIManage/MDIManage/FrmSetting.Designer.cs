namespace MDIManage
{
	partial class FrmSetting
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
			menuStrip1 = new MenuStrip();
			categoryToolStripMenuItem = new ToolStripMenuItem();
			yearToolStripMenuItem = new ToolStripMenuItem();
			toolStrip1 = new ToolStrip();
			toolStripButton1 = new ToolStripButton();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(40, 40);
			menuStrip1.Items.AddRange(new ToolStripItem[] { categoryToolStripMenuItem, aboutToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 52);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// categoryToolStripMenuItem
			// 
			categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yearToolStripMenuItem });
			categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
			categoryToolStripMenuItem.Size = new Size(163, 48);
			categoryToolStripMenuItem.Text = "Category";
			// 
			// yearToolStripMenuItem
			// 
			yearToolStripMenuItem.Name = "yearToolStripMenuItem";
			yearToolStripMenuItem.Size = new Size(448, 54);
			yearToolStripMenuItem.Text = "Year";
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(40, 40);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
			toolStrip1.Location = new Point(0, 52);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(800, 51);
			toolStrip1.TabIndex = 1;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(58, 44);
			toolStripButton1.Text = "toolStripButton1";
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new Size(124, 48);
			aboutToolStripMenuItem.Text = "About";
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(448, 54);
			helpToolStripMenuItem.Text = "Help";
			// 
			// FrmSetting
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(toolStrip1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "FrmSetting";
			Text = "FrmSetting";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem categoryToolStripMenuItem;
		private ToolStripMenuItem yearToolStripMenuItem;
		private ToolStrip toolStrip1;
		private ToolStripButton toolStripButton1;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
	}
}