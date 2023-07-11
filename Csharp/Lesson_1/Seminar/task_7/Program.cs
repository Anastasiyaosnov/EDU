//Программа рандомно выбирает число, если оно кратно 3, то пишет Fizz, если кратно 5, то BUZZ, если кратно и 3, и 5, то слитно

int value = new Random().Next(1, 100);
Console.WriteLine($"{value}");

int newvalue = value % 3;

if (newvalue == 0)
{
    Console.Write("FIZZ");
}

newvalue = value % 5;

if (newvalue == 0)
{
    Console.Write("BUZZ");
}

else
{
    Console.Write("Число не кратно ни 3, ни 5");
}