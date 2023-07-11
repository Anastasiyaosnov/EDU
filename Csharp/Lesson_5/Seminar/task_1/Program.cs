// Задача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



// int[] FillArray(int value, int min, int max)
// {
//     int[] array = new int[value];
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void Print (int[] array)
// {
//     for(int i = 0; i<array.Length-1;i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write(array[array.Length-1]);
// }

// int[] newArray(int[] array)
// {
//     int val = array.Length;
//     if (val % 2 == 0)
//     {   int[] new1 = new int[val];
//         for (int index = 0; index < new1.Length / 2; index++)
//         {
//             new1[index] = array[index] * array[val - 1 - index];
//         }
//     }
//     else
//     {
//         int[] new1 = new int[val/2+1];
//         for (int index = 0; index < new1.Length / 2; index++)
//         {
//             new1[index] = array[index] * array[val - 1 - index];
//         }
//         new1[val/2+1]=array[val/2+1];
//     }
//     return new1;
// }

// int[] userArray = FillArray(10,0,10);
// Print(userArray);
// Console.WriteLine();
// Print(newArray(userArray));