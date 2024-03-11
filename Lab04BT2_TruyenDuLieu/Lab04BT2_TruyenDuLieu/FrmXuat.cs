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
	public partial class FrmXuat : Form
	{
		const int KhoangCachLe = 10;
		const int KhoangCachButton = 10;
		const int Rong = 60;
		const int Cao = 60;

		public FrmXuat(int soDong = 1, int soCot = 1)
		{
			InitializeComponent();

			//Sinh động form có n dòng, m cột button
			Button button;
			for (int i = 0; i < soDong; i++)
			{
				for (int j = 0; j < soCot; j++)
				{
					button = new Button();
					button.Left = KhoangCachLe + (KhoangCachButton + Rong) * j;
					button.Top = KhoangCachLe + (KhoangCachButton + Cao) * i;
					button.Height = Cao;
					button.Width = Rong;
					button.Text = $"{i},{j}";

					//gắn sự kiện
					button.Click += ClickButton;

					//thêm button vô Form
					this.Controls.Add(button);
				}
			}

			//resize kích thước Form
			this.ClientSize = new Size(
				KhoangCachLe + (KhoangCachButton + Rong) * soCot,
				KhoangCachLe + (KhoangCachButton + Cao) * soDong
			);
		}

		protected void ClickButton(object sender, EventArgs e)
		{
			MessageBox.Show("Click lên button: " + (sender as Button).Text);
		}
	}
}
