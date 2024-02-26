/*BT4: Nhập vào đoạn văn (có thể đọc từ file).
Hãy đếm số lượng xuất hiện từng từ (word) trong đoạn đó.
HINT:
- Phân tách đoạn văn thành mảng các từ <chuoi>.Split()
- Dùng Dictionary để lưu trữ từ==>số lượng (VD: { "an": 2, "ngu": 5}
- [Option] Đọc chuỗi từ file:File.ReadAllText(<duong_dan>)*/
using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
Console.Write("Nhập chuỗi: ");
var chuoiNhap = Console.ReadLine().Trim();

//chuoiNhap = chuoiNhap.Replace(",", "");
chuoiNhap = Regex.Replace(chuoiNhap, "[?,.!]", "");

var mangCacTu = chuoiNhap.Split();
Console.WriteLine(string.Join(";", mangCacTu));
var thongKe = new Dictionary<string, int>();
foreach (var tu in mangCacTu)
{
	if (thongKe.ContainsKey(tu))
	{
		thongKe[tu] += 1;
	}
	else
	{
		thongKe[tu] = 1;
	}
}
foreach(var tu in thongKe.Keys)
{
	Console.WriteLine($"{tu} xuất hiện {thongKe[tu]}.");
}