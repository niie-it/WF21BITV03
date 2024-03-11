using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04BT2_TruyenDuLieu
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnKhoiTao_Click(object sender, EventArgs e)
		{
			if (int.TryParse(TxtSoCot.Text, out int soCot) && int.TryParse(TxtSoDong.Text, out int soDong) && soCot > 0 && soDong > 0)
			{
				var form = new FrmXuat(soDong, soCot);
				form.StartPosition = FormStartPosition.CenterScreen;
				form.ShowDialog();
			}
			else
			{
				MessageBox.Show("Chưa hợp lệ");
			}
		}
	}
}
