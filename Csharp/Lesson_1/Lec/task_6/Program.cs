double base1 = new Random().Next(1, 10);
double base2 = new Random().Next(1, 10);
double base3 = new Random().Next(1, 10);
double base4 = new Random().Next(1, 10);
double base5 = new Random().Next(1, 10);
double base6 = new Random().Next(1, 10);
double max = base1;
Console.WriteLine(base1);
Console.WriteLine(base2);
Console.WriteLine(base3);
Console.WriteLine(base4);
Console.WriteLine(base5);
Console.WriteLine(base6);
Console.WriteLine(max);
if(base2 > max)
{
max = base2;
}
if(base3 > max)
{
max = base3;
}
if(base4 > max)
{
max = base4;
}
if(base5 > max)
{
max = base5;
}
if(base6 > max)
{
max = base6;
}
Console.WriteLine(max);
