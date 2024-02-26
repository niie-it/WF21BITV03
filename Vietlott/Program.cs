const int MEGA645 = 45;
const int POWER655 = 55;

List<string> PhatSinh1BoSo(int type)
{
	var dsSo = new List<int>();
	var rd = new Random(type);
	while (dsSo.Count < 6)
	{
		var soSinhRa = rd.Next(1, type + 1);
		if (!dsSo.Contains(soSinhRa))
		{
			dsSo.Add(soSinhRa);
		}
	}
	dsSo.Sort();
	return dsSo.Select(so => so.ToString("00")).ToList();
}

Console.WriteLine(string.Join(", ", PhatSinh1BoSo(POWER655)));
Console.WriteLine(string.Join(", ", PhatSinh1BoSo(MEGA645)));