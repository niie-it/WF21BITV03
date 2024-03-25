namespace DemoVeHinh
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Color MauDangChon = Color.Black;
		private void BtnChonMau_Click(object sender, EventArgs e)
		{
			var cd = new ColorDialog();
			cd.FullOpen = true;
			if (cd.ShowDialog() == DialogResult.OK)
			{
				MauDangChon = cd.Color;
				BtnChonMau.BackColor = cd.Color;
			}
		}

		private void BtnVeChu_Click(object sender, EventArgs e)
		{
			int X = int.Parse(TxtX.Text);
			int Y = int.Parse(TxtY.Text);

			//vẽ trên control nào thì lấy đối tượng Graphics của control đó
			var g = panel1.CreateGraphics();
			g.DrawString(
				TxtNoiDung.Text,
				new Font("Arial", 20, FontStyle.Bold),
				new SolidBrush(MauDangChon),
				X, Y
			);
		}
	}
}
