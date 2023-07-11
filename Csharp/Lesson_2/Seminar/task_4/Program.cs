// 2.1. Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8


int number()
{
    int answer = Convert.ToInt32(new Random().Next(10, 10000));
    return answer;
}

void Print(int value)
{
    Console.WriteLine(value);
}

int Max(int value)
{
    int max = 0;
    while (value > 0)
    {
        int index = value % 10;
        if (max <= index)
        {
            max = index;
        }
        value = value / 10;
    }

    return max;
}
int uservalue = number();
Print(uservalue);
Print(Max(uservalue));
