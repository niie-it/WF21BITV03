/* Nhập vào các tên trái cây cho đến khi nhập chữ STOP hoặc không nhập gì cả thì dừng
 */
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
List<string> mangTraiCay = new List<string>();
while (true)
{
	Console.Write("Tên trái cây: ");
	string ten = Console.ReadLine().Trim();

	if (ten.ToUpper() == "STOP" || ten == "")
	{
		break;
	}
	if (mangTraiCay.Contains(ten, StringComparer.OrdinalIgnoreCase))
	{
		Console.WriteLine($"{ten} đã có.");
		continue;
	}
	mangTraiCay.Add(ten);
	Console.WriteLine($"Count={mangTraiCay.Count}, Capacity={mangTraiCay.Capacity}");
	Console.WriteLine(string.Join(", ", mangTraiCay));
}

Console.Write("Cần tìm: ");
string search = Console.ReadLine().Trim();
if (mangTraiCay.Contains(search, StringComparer.OrdinalIgnoreCase))
{
	Console.WriteLine($"Tìm thấy {search}.");

	//mangTraiCay.Remove(search);
	int viTri = mangTraiCay.IndexOf(search);
	if (viTri > -1)
	{
		mangTraiCay.RemoveAt(viTri);
	}
	Console.WriteLine("Sau khi xóa: " + string.Join(", ", mangTraiCay));
}