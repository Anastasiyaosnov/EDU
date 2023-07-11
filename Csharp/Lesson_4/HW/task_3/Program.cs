// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). Реализовать через функции.


int Promt(string massage)
{
    Console.WriteLine($"{massage}");
    return Convert.ToInt32(Console.ReadLine());
}

int[] array(int lenght, int num1, int num2)
{
    int[] first = new int[lenght];
    for (int i = 0; i < first.Length; i++)
    {
        first[i] = new Random().Next(num1, num2 + 1);
    }
    return first;
}

void PrintArray(int[] array1)
{
    int lenght1 = array1.Length;
    for (int i = 0; i < lenght1; i++)
        Console.Write($"{array1[i]} ");
}

int userv1 = Promt("Введите длину массива");
int userv2 = Promt("Введите минимальное значение элемента массива");
int userv3 = Promt("Введите максимальное значение элемента массива");

int[] total = array(userv1, userv2, userv3);
PrintArray(total);