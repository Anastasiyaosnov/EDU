// Задача 6*: Напишите программу
// , которая выводит первые заданные элемента
// следующей последовательности:
// -> 12
// 1 2 2 3 3 3 4 4 4 4 5 5


int Prompt(string message)
{
    Console.Write($"{message} >"); // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

int[] elements(int value)
{
int index = 0;
int num = 1;
int sum = 0;
int count = 0;
int[] array = new int[value];

while (index < array.Length)
{
    count = 0;
    while(count<array.Length)
    {
        if (array[count]==num)
        {
            sum++;
        }
        count++;
    }
    if (sum==num)
    {
        num++;       
    }
    sum=0;
    array[index] = num;
    index++;
}
return array;
}


void Print(int[] massive)
{
    int index = 0;
    while (index < massive.Length)
    {
        Console.Write(massive[index]);
        index++;
    }
    
}


int [] userArray = elements(Prompt("add"));
Print(userArray);