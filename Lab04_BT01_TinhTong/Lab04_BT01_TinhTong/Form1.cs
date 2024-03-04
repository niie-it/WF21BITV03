namespace Lab04_BT01_TinhTong
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnTinh_Click(object sender, EventArgs e)
		{
			if (int.TryParse(txtN.Text, out int N) && N > 0)
			{
				int S = 0;
				for (int i = 1; i <= N; i++)
				{
					S += i;
				}
				txtTong.Text = S.ToString();
			}
			else
			{
				MessageBox.Show("Giá trị không chính xác");
				txtN.Focus();
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			//this.Close();
			var result = MessageBox.Show("Bạn chắc đóng chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
