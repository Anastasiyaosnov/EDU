// 4. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Вариант через for

// Console.WriteLine("Введите число > ");
// double inputValue = Convert.ToDouble(Console.ReadLine());

// for (double newValue = inputValue*(-1); newValue < inputValue+1;newValue++)
// {
//     Console.Write($"{newValue}, ");
// }


// Вариант через while

Console.WriteLine("Введите число > ");
double N = Convert.ToDouble(Console.ReadLine());

double unN = -N;

while (unN<N)
{
    Console.Write($"{unN}, ");
    unN++;
}