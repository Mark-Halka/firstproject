int a = 1000;
for (; ; )
{
    a--;
    a--;
    a--;
    a--;
    a--;
    a--;
    a--;
    Console.WriteLine(a);
    System.Threading.Thread.Sleep(1);
}

for (int i = 5; i >= 0; i--)
{
    Console.WriteLine(i);
}
