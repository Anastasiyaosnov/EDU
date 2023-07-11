// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите первое число");
double userValue1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double userValue2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число");
double userValue3 = Convert.ToDouble(Console.ReadLine());

double maxValue = userValue1;
if (maxValue <= userValue2)
{
    maxValue = userValue2;
}
if (maxValue <= userValue3)
{
    maxValue = userValue3;
}
    Console.WriteLine($"Максимальное число среди {userValue1}, {userValue2}, {userValue3} -> {maxValue}");