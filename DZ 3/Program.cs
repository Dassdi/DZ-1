int a;
string input_a;

Console.WriteLine("Введите число: ");

input_a = Console.ReadLine();
a = Int32.Parse(input_a);

if (a%2 == 0)
{ 
Console.WriteLine("Четное число");
}
else
{
Console.WriteLine("Нечетное число");
}

