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