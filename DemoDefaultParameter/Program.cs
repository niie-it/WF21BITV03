void Tinh(int a = 3, int b = 1, int c = 0)
{
	Console.WriteLine($"{a} + {b} * {c} = {a + b * c}");
}

Tinh();
Tinh(5);
Tinh(5, 4);
Tinh(5, 4, 2);
Tinh(c: 7, b: 5, a: 3);
Tinh(c: 7, a: 3);
