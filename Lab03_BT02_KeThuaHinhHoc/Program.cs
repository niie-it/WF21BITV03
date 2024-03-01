using Lab03_BT02_KeThuaHinhHoc;

List<HinhHoc> dsHinh = new List<HinhHoc>();

//tự nhập từng loại hình
dsHinh.Add(new HinhTron { BanKinh = 7 });
dsHinh.Add(new HinhChuNhat { Dai = 11, Rong = 2 });
dsHinh.Add(new HinhChuNhat { Dai = 8, Rong = 8 });
dsHinh.Add(new HinhTron { BanKinh = 17 });
dsHinh.Add(new HinhTron { BanKinh = 27 });
dsHinh.Add(new HinhChuNhat { Dai = 11, Rong = 22 });
dsHinh.Add(new HinhTron { BanKinh = 37 });

foreach(var hh in dsHinh)
{
	hh.TinhDienTichChuVi();
	Console.WriteLine(hh);
}