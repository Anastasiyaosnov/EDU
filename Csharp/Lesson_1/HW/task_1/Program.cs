// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
double userValue1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double userValue2 = Convert.ToDouble(Console.ReadLine());

if (userValue1 > userValue2)
{
    Console.WriteLine($"max = {userValue1}, min {userValue2}");
}
else if (userValue1 < userValue2)
{
    Console.WriteLine($"max = {userValue2}, min = {userValue1}");
}
else {
    Console.WriteLine($"{userValue1} = {userValue2}");
}