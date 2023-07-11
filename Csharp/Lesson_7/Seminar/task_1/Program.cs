// Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.



void FillMatrix(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


int Prompt(string message)

{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int [,] Switch (int[,] array)
{
    int [] zone = new int[array.GetLength(1)];
    for(int i=0; i<array.GetLength(1);i++)
    {
        zone[i]=array[0,i];
        array[0,i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i]=zone[i];
    }
    return array;
}



int UserRows = Prompt("Введите количество строк");
int UserColumns = Prompt("Введите количество столбцов");
int UserMin = Prompt("Введите min");
int UserMax = Prompt("Введите max");

int [,] userMatrix = new int [UserRows,UserColumns];
FillMatrix(userMatrix, UserMin, UserMax);

PrintArray(userMatrix);
Console.WriteLine();
// int num = userMatrix.GetLength(0);
// Console.WriteLine(num);
// Console.WriteLine(userMatrix[userMatrix.GetLength(0)-1,0]);
int [,] switchmatrix = Switch(userMatrix);
PrintArray(switchmatrix);

