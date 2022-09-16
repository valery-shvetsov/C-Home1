Console.WriteLine("Введите число 1");
string AStr = Console.ReadLine();
int A = int.Parse(AStr);
Console.WriteLine("Введите число 2");
string BStr = Console.ReadLine();
int B = int.Parse(BStr);
Console.WriteLine("Введите число 3");
string CStr = Console.ReadLine();
int C = int.Parse(CStr);
int max=A;
if(A<B) 
{
    max=B;
}
if (A<C)
{
    max=C;
}
Console.Write("Максимальное число= " );
Console.Write(max);