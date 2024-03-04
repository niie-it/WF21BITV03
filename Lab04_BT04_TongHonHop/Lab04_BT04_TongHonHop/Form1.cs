namespace Lab04_BT04_TongHonHop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnTinh_Click(object sender, EventArgs e)
		{
			int N;
			double X;
			if (!int.TryParse(txtN.Text, out N) || (N <= 0))
			{
				MessageBox.Show("Giá trị N không hợp lệ");
				txtN.Focus();
				return;
			}
			if (!double.TryParse(txtX.Text, out X))
			{
				MessageBox.Show("Giá trị X không hợp lệ");
				txtX.Focus();
				return;
			}

			double S4 = 0;
			string S1 = string.Empty;
			string S2 = string.Empty;
			string S3 = string.Empty;

			for (int i = 1; i <= N; i++)
			{
				S1 += $"X" + (i > 1 ? $"^{i}" : "") + "+";
				S2 += $"{X}{(i > 1 ? ($"^{i}") : "")}+";
				S4 += Math.Pow(X, i);
				S3 += $"{Math.Pow(X, i)}+";
			}

			txtS1.Text = S1.Substring(0, S1.Length - 1);
			txtS2.Text = S2.Substring(0, S2.Length - 1);
			txtS3.Text = S3.Substring(0, S3.Length - 1);
			txtS4.Text = S4.ToString();
		}
	}
}
