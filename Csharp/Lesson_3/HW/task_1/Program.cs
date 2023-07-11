// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
System.Console.Write($"{message}");
int answer = Convert.ToInt32(Console.ReadLine());
return answer;
}

void Array(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
collection[index] = Prompt($"Введите {index+1} число: ");
index++;
}
}

void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
    Console.Write($"{col[position]}");
    position++;
}
}

void exam (int[] col)
{
    if (col[0] == col[4] && col[1] == col[3])
    {
        Console.WriteLine("");
        Console.WriteLine("Это палиндром ");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Это не палиндром ");
    }
}

int[] total = new int[5];
Array(total);

PrintArray(total);
exam(total);

