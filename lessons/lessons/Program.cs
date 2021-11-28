bool ininfected = true;
if (!ininfected)
{
    Console.WriteLine("Character is infected");
}
else
{
    Console.WriteLine("Character is not infected");
}
// ! - не, міняє значеня на протилежне
bool HightTemperature = true;
bool ColderNotWorking = true;
if (HightTemperature && ColderNotWorking)
{
    Console.WriteLine("Procesor is crashed");
}
/* && - провіряє два файли і якщо хочяб один файл false комп використовує else а в
цому випадку нічого не робить */
int fanSpeed = 0;
bool HightTemperature1 = false;
bool ColderNotWorking1 = fanSpeed <= 2999;
if (HightTemperature1 || ColderNotWorking1)
{
    Console.WriteLine("Procesor is crashed");
}
// || провіряє два файли і якщо хочяб один файл true комп використовує if
// &, | - непотрібна фігня




