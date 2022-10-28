// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
try
{
    Console.WriteLine("Введите натуральное число 1");
    int x = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Введите натуральное число 2");
    int y = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Введите натуральное число 3");
    int z = Convert.ToInt32 (Console.ReadLine());
    int max = x;
    if (x > y)
    {
        max = x;
        if (x > z) max = x;
        else max = z;
    }
    if (x < y)
    {
        max = y;
        if (y > z) max = y;
        else max = z;
    }
    Console.WriteLine($"max = {max}");
}
        catch
{
    Console.WriteLine("Вы ввели некорректные данные");
}