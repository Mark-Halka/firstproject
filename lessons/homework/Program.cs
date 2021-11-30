double a, b;
string c;

Console.WriteLine("Write first number");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Write second number");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Choose type of coculation: +, -, *, /");
c = Console.ReadLine();

switch (c)
{
    case "+":
        Console.WriteLine(a + b);
        break;
    case "-":
        Console.WriteLine(a - b);
        break;
    case "*":
        Console.WriteLine(a * b);
        break;
    case "/":
        if (a == 0)
        {
            Console.WriteLine("Error 404");
        }
        else
        {
            if (b == 0)
            {
                Console.WriteLine("Error 404");
            }
            else
            {
                Console.WriteLine(a / b);
            }
        }
        break;
    default:
        Console.WriteLine("Error 404");
        break;
}