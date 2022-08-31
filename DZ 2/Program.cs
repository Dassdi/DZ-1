int num1,num2,num3;
string input_1, input_2, input_3;
int max;

Console.WriteLine("Введите три числа: ");

input_1 = Console.ReadLine();
input_2 = Console.ReadLine();
input_3 = Console.ReadLine();

num1 = Int32.Parse(input_1);
num2 = Int32.Parse(input_2);
num3 = Int32.Parse(input_3);

max=num1;

if (max < num2)
{ 
max = num2;
 if (max < num3)
  {
    max = num3;
  }
}
else
{
    max = num1;
}

Console.WriteLine ("Наибольшее число: " + max);