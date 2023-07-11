// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Factorial (int number)
{
    if (number == 1)
    {
        return 1;
    }
    return number * Factorial(number-1);
}

Console.WriteLine(Factorial(3));