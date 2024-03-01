using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
	public class HinhTron
	{
		//Automatic Property
		public double BanKinh { get; set; }

		//Property dạng get (chỉ đọc)
		public double ChuVi => 2 * BanKinh * Math.PI;
		public double DienTich => Math.Pow(BanKinh, 2) * Math.PI;

		public void Xuat()
		{
			Console.WriteLine($"Tròn có R={this.BanKinh}, S={DienTich}, P={ChuVi}");
		}
		public override string ToString()
		{
			return $"Tròn có R={this.BanKinh}, S={DienTich}, P={ChuVi}";
		}
	}
}
