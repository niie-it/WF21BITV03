using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWordPad
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "";
		}

		private void TblOpenFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Text|*.txt|WordPad|*.rtf|All files|*.*";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show(ofd.FileName);
				if (Path.GetExtension(ofd.FileName) == ".txt")
				{
					richTextBox1.Text = File.ReadAllText(ofd.FileName);
				}
			}
		}
	}
}
