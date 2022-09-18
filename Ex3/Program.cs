Console.WriteLine("Введите число 1");
string AStr = Console.ReadLine();
double A = double.Parse(AStr);
if ( A%2==0 )
{
    Console.WriteLine("Число четное");
}
else
Console.WriteLine("Число нечетное");