Console.WriteLine("Введите целое число более 2 ");
string AStr = Console.ReadLine();
int A = int.Parse(AStr);
int I=2;
Console.Write("Четные числа менее ");
Console.WriteLine(A);

while (I<A)
{
 Console.WriteLine(I); 
 I=I+2;
}
Console.WriteLine("Задача выполнена");
