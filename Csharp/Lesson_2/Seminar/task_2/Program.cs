// // 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number ()
{
    int answer = Convert.ToInt32(new Random().Next(10,100));
    return answer;
}

void Print (int value)
{
    Console.WriteLine(value);
}

int Max (int value)
{
    int num1 = value / 10;
    int num2 = value % 10;
    int max = num1;
    if (max<=num2)
    {
        max = num2;
    }
    return max;
}
int uservalue = number();
Print(uservalue);
Print(Max(uservalue));



