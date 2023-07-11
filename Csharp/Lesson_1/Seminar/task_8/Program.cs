// Составить программу, которая выводит числа от 1 до 100, 
// если число кратно 3, то вместо числа пишет FIZZ, 
// если число кратно 5, то пишем BUZZ, 
// если число кратно и 3 и 5, то пишем FIZZBUZZ

int N = 1;
while (N < 101)
{
    if (N % 3 == 0 && N % 5 == 0) 
    {
        Console.Write("FIZZBUZZ, ");
    }
    else if (N % 3 == 0)
    {
        Console.Write("FIZZ, ");
    }
    else if (N % 5 == 0)
    {
        Console.Write("BUZZ, ");
    }
    else
    {
        Console.Write($"{N}, ");
    }
    N++;
}
