// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);


bool ValidateNumber(int number)
{
if (number >= 100 && number < 1000)
{
return true;
}

System.Console.WriteLine("Число не трехзначное");
return false;
}

if (ValidateNumber(number))
{
int result1 = number % 10;
int result2 = number /100;
System.Console.WriteLine($"Полученное число {result2}{result1}");
}