Console.WriteLine("Введите число 1");
string AStr = Console.ReadLine();
int A = int.Parse(AStr);
Console.WriteLine("Введите число 2");
string BStr = Console.ReadLine();
int B = int.Parse(BStr);

if (A>B) Console.WriteLine("число 1 больше, чем число 2");
else Console.WriteLine("число 2 больше, чем число 1");
Console.WriteLine(A);
Console.WriteLine(B);