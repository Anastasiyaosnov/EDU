// 4.1. Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет 
// 15 -> нет 
// 12 -> да


int Prompt (string mes)
{
    Console.WriteLine(mes);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void answer (int value)
{
    int number = new Random().Next();
    while(number%value>0)
    {
        Console.WriteLine($"{number} -> no");
        number = new Random().Next();
    }
    Console.WriteLine($"{number} -> yes");
}

int user = Prompt("add");
answer(user);
