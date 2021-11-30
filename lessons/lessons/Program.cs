int a = int.Parse(Console.ReadLine());
switch (a)
{
    case 1:
        Console.WriteLine("your number is 1");
        break;
    case 2:
        Console.WriteLine("your number is 2");
        break;
    case 3:
    default:
        Console.WriteLine("Error 404");
        break;
}
string b = Console.ReadLine();
switch (b)
{
    case "+":
        Console.WriteLine("+");
        break;
    case "-":
        Console.WriteLine("-");
        break;
} 
