// Задача 5*: Напишите программу, которая генерирует последовательность случайных чисел из 10 элементов в диапазоне от 1 до 10, и подсчитывает, сколько сгенерировалось чисел больше 5.

int[] array ()
{
    int [] massive = new int [10];
    for (int i = 0; i <massive.Length;i++)
    {
        massive[i] = new Random().Next(0,10);
    }
    return massive;
}

void Print(int[] array)
{
    int index = 0;
    while(index<array.Length)
    {
        Console.WriteLine(array[index]);
        index++;
    }
}

int Total (int[] massive)
{
    int sum = 0;
    foreach(int element in massive)
    {
        if (element ==5)
        {
            sum ++;
        }
    }
    return sum;
}

int[] newarray = array();
Print(newarray);
Console.WriteLine(Total(newarray));

