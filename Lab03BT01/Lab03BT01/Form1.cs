namespace Lab03BT01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			if (CboTitle.Text.Length > 0 && TxtFirstName.Text.Length > 0 && txtLastName.Text.Length > 0)
			{
				var chuoi = $"{CboTitle.Text} {TxtFirstName.Text} {txtLastName.Text}";
				LstDanhSach.Items.Add(chuoi);
			}
			else
			{
				MessageBox.Show("Chưa nhập đủ dữ liệu");
			}
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			CboTitle.Text = "";
			TxtFirstName.Clear();
			txtLastName.Text = "";

			//xóa dữ liệu listbox danh sách
			LstDanhSach.Items.Clear();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			var traLoi = MessageBox.Show("Đóng chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (traLoi == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void BtnSaveToFile_Click(object sender, EventArgs e)
		{
			if (LstDanhSach.Items.Count == 0)
			{
				MessageBox.Show("Danh sách rỗng");
				return;
			}
			var danhSach = new List<string>();
			foreach(var item in LstDanhSach.Items)
			{
				danhSach.Add(item.ToString());
			}
			File.WriteAllLines("data.txt", danhSach);
		}
	}
}
