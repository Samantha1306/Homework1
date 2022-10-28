// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите целое число");
int x = Convert.ToInt32 (Console.ReadLine());
int y = 2;
int z = x % 2;
if (z == 0)
{
    while (y < x)
    {
        Console.Write(y + ", ");
        y = y + 2;
    }
    Console.WriteLine(y);
}
else 
{
    while (y < x)
    {
        Console.Write(y + ", ");
        y = y + 2;
    }
}