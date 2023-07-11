Console.WriteLine("Введите число");
int uservalue = Convert.ToInt32(Console.ReadLine());
switch (uservalue)
{
case 1:
Console.WriteLine("Понедельник");
break;
case 2:
Console.WriteLine("Вторник");
break;
case 3:
Console.WriteLine("Среда");
break;
case 4:
Console.WriteLine("Четверг");
break;
case 5:
Console.WriteLine("Пятница");
break;
default:
Console.WriteLine("Такой день недели я не знаю");
break;
}
