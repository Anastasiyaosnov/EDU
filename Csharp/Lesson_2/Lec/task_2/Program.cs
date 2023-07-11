// Допустим, у нас есть массив array, в котором n элементов. Найдём элемент, совпадающий с
//некоторым значением, который определяет пользователей.

// метод Fill заполняет массив рандомными числами в заданном диапозоне.
// метод Print просто последовательно печатает на экрне эти числа.
// Тип данных void позволяет делать определенные действия, ничего не возвращая.


// в скобках не создается новый массив, а прописывается аргумент, т.е. возможно в будущем использовать на каком-то новом массиве.


// void Fill(int[] mas1)
// {
//     int mas1index = 0;
//     while (mas1index < mas1.Length)
//     {
//         mas1[mas1index] = new Random().Next(1, 10);
//         mas1index++;
//     }

// }

// void Print(int[] mas2)
// {
//     int mas2index = 0;

//     while (mas2index < mas2.Length)
//     {
//         Console.WriteLine($"{mas2[mas2index]}, ");
//         mas2index++;
//     }

// }


// int IndexOf(int[] collection, int find)
// {
//     int index = 0;
//     int position = 0;
//     while (index < collection.Length)
//     {
//         if(collection[index] == find)
//     {
//             position = index;
//             break; //Если поставить break, то операция останавливается на первом удачном совпадении позиции и индекса, если не поставить, то прогонит до конца и покажет самый последний успешный варинт.
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int [10];
// Fill(array);
// Print(array);

// int value = IndexOf(array, 4);
// Console.WriteLine();

// Console.WriteLine(value);