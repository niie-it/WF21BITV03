/*
BT1: Viết hàm in bảng cửu chương của N
Input: N
Output: Bảng cửu chương
	N X 1 = ?
	...
	N x 10 = ?
*/
void InBangCuuChuong(int N)
{
	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine($"{N} X {i} = {N * i}");
	}
}

var random = new Random();
InBangCuuChuong(random.Next(1, 100));

/*BT2: Viết hàm kiểm tra 1 chuỗi có là Palindom hay không
(chuỗi đối xứng)*/
bool IsPalindonre(string chuoiKiemTra)
{
	int length = chuoiKiemTra.Length;
	for (int i = 0; i < length / 2; i++)
	{
		if (chuoiKiemTra[i] != chuoiKiemTra[length - 1 - i])
		{
			return false;
		}
	}
	return true;
}

bool checkPalindore(string chuoi) => chuoi == chuoi.Reverse().ToString();
bool checkPalindore2(string chuoi) { return chuoi == chuoi.Reverse().ToString(); }