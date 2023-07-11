// // 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


int Prompt (string mes)
{
    Console.WriteLine(mes);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool search (int value1, int value2)
{
    if (value1%value2==0)
    {
        return true;
    }
    else
    {
        int total = value1%value2;
        Console.WriteLine($"не кратно, остаток {total}");
        return false;
    }
}

int num1 = Prompt("1");
int num2 = Prompt("2");
if(search(num1,num2))
{
    Console.WriteLine($"кратно");
}