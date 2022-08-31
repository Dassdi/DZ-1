int a,b;
string input_a, input_b;

Console.WriteLine("Введите два числа: ");

input_a = Console.ReadLine();
input_b = Console.ReadLine();

a = Int32.Parse(input_a);
b = Int32.Parse(input_b);

if (a>b)
{ 
Console.WriteLine("Наибольшее число: " + a);

}
else
{
Console.WriteLine("Наибольшее число: " + b);
}