int count = int.Parse(Console.ReadLine());
int limit = int.Parse(Console.ReadLine());

int oddNumbers = 0;
int evenNumbers = 0;
while (count < limit + 1)
{
    if (count % 2 == 0)
    {
        oddNumbers++;
    }
    else
    {
        evenNumbers++;
    }
    count++;
}
Console.WriteLine(oddNumbers);
Console.WriteLine(evenNumbers);
