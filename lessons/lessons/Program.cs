
//break це червона кнопка яка зупиняє цикл
for (int i = 0; i <= 100; i++)
{
    Console.WriteLine(i);
    string a = Console.ReadLine();
    if (a == "exit")
    {
        break;
    }
}

//continue це червона кнопка яка пропускає якісь значння 
for (int i = 0; i <= 100 ; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}


