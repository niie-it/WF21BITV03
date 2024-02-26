void NhapSoNguyenDuong(out int So)
{
	while (true)
	{
		Console.Write("Nhập số dương: ");
		if (int.TryParse(Console.ReadLine(), out So) && So > 0)
		{
			break;
		}
		Console.WriteLine("Nhập sai...");
	}
}

NhapSoNguyenDuong(out int ABC);
Console.WriteLine($"ABC={ABC}");

void ChuyenDoi(ref int x, ref int y)
{

}

int x, a = 7, b = 9;
NhapSoNguyenDuong(out x);
ChuyenDoi(ref a, ref b);