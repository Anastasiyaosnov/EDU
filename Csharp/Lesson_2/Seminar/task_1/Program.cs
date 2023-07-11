// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// int Prompt(string message)
// {
// System.Console.Write($"{message} >");
// int answer = Convert.ToInt32(Console.ReadLine());
// return answer;
// }

// bool ValidateNumber(int number)
// {
// if (number >= 100 && number < 1000)
// {
// return true;
// }

// System.Console.WriteLine("Число не трехзначное");
// return false;
// }

// int number = Prompt("Введите число");
// if (ValidateNumber(number))
// {
// int result = number % 10;
// System.Console.WriteLine($"Последняя цифра введенного числа {result}");
// }






// // 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// // 456 -> 6
// // 782 -> 2
// // 918 -> 8

int Prompt (string value) 
{
    Console.WriteLine(value);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

// void number (int value)
// {
//     if (value>0)
//     {
//     if (value>99 && value<1000)
//     {
//         int answer = value%10;
//         Console.WriteLine($"{answer}");
//     }
//     else
//     {
//       Console.WriteLine("Число не трехзначное");
//     }
//     }
//     else
//     {
//         if ((value*-1)>99 && (value*-1<1000))
//     {
//         int answer = (value*-1)%10;
//         Console.WriteLine($"{answer}");
//     }
//     else
//     {
//       Console.WriteLine("Число не трехзначное");
//     }
//     }
// }

bool number (int value)
{
    if (value >=100 && value <1000)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Число не трехзначное");
        return false;
    }
}

int UserValue = Prompt("Введите трехзначное число");
if (number(UserValue))
{
    int answer = UserValue%10;
    Console.WriteLine(answer);
}
