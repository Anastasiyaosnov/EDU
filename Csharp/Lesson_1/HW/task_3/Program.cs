// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число, чтобы определить, является ли оно чётным");
double userValue = Convert.ToDouble(Console.ReadLine());

if (userValue % 2 == 0)
{
    Console.WriteLine($"{userValue} -> да");
}
else
{
    Console.WriteLine($"{userValue} -> нет");
}

