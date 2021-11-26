Console.WriteLine("Write number 1");
double number1 = double.Parse(Console.ReadLine());
Console.WriteLine("Write number 2");
double number2 = double.Parse(Console.ReadLine());
double result6 = (number1 + number2) / 2;
Console.WriteLine(result6 + " avg");

double g, r, t;
Console.WriteLine("Write number 1");
g = double.Parse(Console.ReadLine());
Console.WriteLine("Write number 2");
r = double.Parse(Console.ReadLine());
Console.WriteLine("Write number 3");
t = double.Parse(Console.ReadLine());
double result2 = g + r + t;
double result3 = g * t * r;
Console.WriteLine(result2 + " sum");
Console.WriteLine(result3 + " productз");


Console.WriteLine("Grivna v rubli");
Console.WriteLine("How much grivnas?");
string i = Console.ReadLine();
double p = Convert.ToDouble(i);
double result4 = p * 2.7;
Console.WriteLine(result4);