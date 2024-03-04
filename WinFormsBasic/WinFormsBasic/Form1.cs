namespace WinFormsBasic
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnChao_Click(object sender, EventArgs e)
		{
			string loiChao = $"Xin chào bạn {txtHoTen.Text}";
			lblChao.Text = loiChao;
			MessageBox.Show(loiChao);
		}

		private void btnNhapLai_Click(object sender, EventArgs e)
		{
			txtHoTen.Text = "";
			lblChao.Text = "";
			txtHoTen.Focus();
		}
	}
}
