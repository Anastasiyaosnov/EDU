// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число");
double N = Convert.ToDouble(Console.ReadLine());
double current = 1;

while (current < N-1)
{
    if (current % 2 == 0)
    {
        Console.Write($"{current}, ");
    }
    current++;
}
while (current <= N)
{
    if (current % 2 == 0)
    {
        Console.Write($"{current}");
    }
    current++;
}