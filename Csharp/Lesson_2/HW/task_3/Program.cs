// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Не использовать строки для расчета.


int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int uservalue = Convert.ToInt32(Console.ReadLine());
    return uservalue;
}

int number = Prompt("Введите число");
Console.WriteLine(number);

int value = number;

if (number >= 100)

{
    while (value >= 999)
    {
        value = value / 10;
    }
    Console.WriteLine($"Третья цифра заданного числа = {value % 10}");
}
else
{
    Console.WriteLine("Нет третьего числа");
}


