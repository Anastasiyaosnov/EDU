// Напишите программу вычисления модуля числа.
//     2 -> 2
//     -3 -> 3
//     -7 -> 7

Console.WriteLine("Введите число > ");
double N = Convert.ToDouble(Console.ReadLine());

if (N < 0)
{
    Console.WriteLine($"Модуль числа равен {N * -1}");
}
else
{
    Console.WriteLine($"Модуль числа равен {N}");
}