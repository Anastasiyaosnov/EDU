Console.WriteLine("Введите первое число = ");
double FirstNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число = ");
double SecondNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Вы ввели {FirstNum}, {SecondNum}");
double Div = SecondNum / FirstNum;
Console.WriteLine(Div);
if (Div == FirstNum)
{
Console.WriteLine($"Да, {SecondNum} является квадратным корнем {FirstNum}");
}
else
{
   Console.WriteLine($"Нет, {SecondNum} не является квадратным корнем {FirstNum}"); 
}