// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

try
{
    Console.WriteLine("Введите натуральное число 1");
    int x = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Введите натуральное число 2");
    int y = Convert.ToInt32 (Console.ReadLine());
    if (x==y)
    {
        Console.WriteLine($"Число {x} равно числу {y}");
    }
    if (x > y)
    {
        Console.WriteLine($"Число {x} больше числа {y}");
    }
    if (x<y)
    {
        Console.WriteLine($"Число {y} больше числа {x}");
    }
}
        catch
{
    Console.WriteLine("Вы ввели некорректные данные");
}