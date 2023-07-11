// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.

int Promt(string massage)
{
    Console.WriteLine($"{massage}");
    return Convert.ToInt32(Console.ReadLine());
}

int degree(int uservalue1, int uservalue2)
{
    int result = 1;
    for (int i = 0; i < uservalue2; i++)
    {
        result = result * uservalue1;
    }
    return result;
}

int A = Promt("Введите число A");
int B = Promt("Введите число B");

int total = degree(A, B);

Console.WriteLine($"Число {A} в степени {B} = {total}");