// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.


int Promt(string massage)
{
    Console.WriteLine($"{massage}");
    return Convert.ToInt32(Console.ReadLine());
}

int value(int uservalue)
{
    int sum = 0;
    int number = 0;
    for (int i = 0; uservalue > 0; i++)
    {
        number = uservalue % 10;
        sum += number;
        uservalue = uservalue / 10;
    }
    return sum;
}

int uservalue1 = Promt("Введите число");
int total = value(uservalue1);
Console.WriteLine($"Сумма цифр в числе {uservalue1} равна {total}");