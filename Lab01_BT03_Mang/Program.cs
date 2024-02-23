using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.Write("Nhập số lượng phần tử: ");
int SoLuong = int.Parse(Console.ReadLine());

Random random = new Random();
//Khai báo mảng
List<int> mang = new List<int>();
while (mang.Count < SoLuong)
{
	//list.Add(random.Next());
	mang.Add(random.Next(2, 10000));
}

Console.WriteLine("Mảng: " + string.Join(", ", mang));
Console.WriteLine($"GTLN={mang.Max()}, Tổng={mang.Sum()}");
List<int> mangSoChan = mang.Where(x => x % 2 == 0).ToList();
Console.WriteLine("Mảng số chẵn: " + string.Join(", ", mangSoChan));


// Hàm kiểm tra số nguyên tố
bool LaSoNguyenTo(int N)
{
	if (N < 2) return false;
	for (int i = 2; i <= Math.Sqrt(N); i++)
	{
		if (N % i == 0) { return false; }
	}
	return true;
}

List<int> mangSoNguyenTo = mang.Where(ptu => LaSoNguyenTo(ptu)).ToList();
Console.WriteLine("Mảng số NT: " + string.Join(", ", mangSoNguyenTo));