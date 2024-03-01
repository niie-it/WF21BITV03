using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_BT02_KeThuaHinhHoc
{
	public class HinhHoc
	{
		public double DienTich { get; set; }
		public double ChuVi { get; set; }
		public virtual void TinhDienTichChuVi() { }
		public override string ToString()
		{
			return "Hinh chua xac dinh";
		}
	}

	public class HinhChuNhat : HinhHoc
	{
		public double Dai { get; set; }
		public double Rong { get; set; }
		public override void TinhDienTichChuVi()
		{
			DienTich = Dai * Rong;
			ChuVi = (Dai + Rong) * 2;
		}
		public override string ToString()
		{
			return $"HCN D={Dai}, R={Rong}, P={ChuVi}, S={DienTich}";
		}
	}

	public class HinhTron : HinhHoc
	{
		public double BanKinh { get; set; }
		public override void TinhDienTichChuVi()
		{
			DienTich = BanKinh * BanKinh * Math.PI;
			ChuVi = 2 * BanKinh * Math.PI;
		}
		public override string ToString()
		{
			return $"Tron R={BanKinh}, P={ChuVi}, S={DienTich}";
		}
	}
}
