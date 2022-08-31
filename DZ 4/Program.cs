int a,x;
string input_a;
string input_x;

Console.Write("Введите число: ");

input_a = Console.ReadLine();
input_x = Console.ReadLine();
a = Int32.Parse(input_a);
x = Int32.Parse(input_a);

for (x=1; x<a; x++)
if (x%2 == 0)
{ 
Console.WriteLine(x);
}

