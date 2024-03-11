namespace QuanLyHangHoaV03
{
	public partial class Form1 : Form
	{
		static List<HangHoa> HangHoas = new List<HangHoa>()
		{
			new HangHoa{MaHh=Guid.NewGuid(), TenHh = "Dell Vostro", SoLuong=5, DonGia=19909000},
			new HangHoa{MaHh=Guid.NewGuid(), TenHh = "HP Probook", SoLuong=3, DonGia=21909000},
			new HangHoa{MaHh=Guid.NewGuid(), TenHh = "ASUS Vivobook", SoLuong=8, DonGia=17909000},
		};

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CboHangHoa.DisplayMember = "TenHh";
			CboHangHoa.ValueMember = "MaHh";
			CboHangHoa.DataSource = HangHoas;

			dataGridView1.DataSource = HangHoas;
		}

		private void CboHangHoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				var giaTriChon = Guid.Parse(CboHangHoa.SelectedValue.ToString());

				var hangHoa = HangHoas.SingleOrDefault(hh => hh.MaHh == giaTriChon);
				if (hangHoa != null)
				{
					LblDonGia.Text = hangHoa.DonGia.ToString();
				}
			}
			catch { }
		}
	}
}
