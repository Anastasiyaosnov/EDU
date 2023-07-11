// Задача *: Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). 
// Постарайтесь сделать одним циклом 
// // [1, 3, 5, 6, 6, 4] -> 5


int [] FillArray (int value, int min, int max)
{
    int [] array = new int [value];
    for (int index =0; index<array.Length;index++)
    {
        array[index] = new Random().Next(min,max+1);
    }
    return array;
}

void Print (int[] array)
{
    for(int i = 0; i<array.Length-1;i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length-1]);
}


int Max (int[] array)
{
    int max1 = array[0];
    int max2 = array[0];
    for(int index=0; index<array.Length;index++)
    {
        
        if(max2<=array[index]&&max2<max1)
        {
            max2=array[index];
        }
        if(max1<=array[index])
        {
            max1=array[index];
        }
        
    }
    return max2;
}

int[] userArray = FillArray(10,-10,10);
Print(userArray);
Console.WriteLine("");
Console.WriteLine(Max(userArray));