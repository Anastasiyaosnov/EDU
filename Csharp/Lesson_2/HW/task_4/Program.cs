// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int uservalue = Convert.ToInt32(Console.ReadLine());
    return uservalue;
}

int number = Prompt("Введите число");

switch (number)
{
    case 1:
        Console.WriteLine(number + "-> Нет");
        break;
    case 2:
        Console.WriteLine(number + "-> Нет");
        break;
    case 3:
        Console.WriteLine(number + "-> Нет");
        break;
    case 4:
        Console.WriteLine(number + "-> Нет");
        break;
    case 5:
        Console.WriteLine(number + "-> Нет");
        break;
    case 6:
        Console.WriteLine(number + "-> Да");
        break;
    case 7:
        Console.WriteLine(number + "-> Да");
        break;
    default:
        Console.WriteLine("Такого номера дня недели не существует, введите число от 1 до 7");
        break;

}