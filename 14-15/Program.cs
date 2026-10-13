int PIN = 0;
int rightPIN =0427;
int popitka = 0;

do
{
    Console.WriteLine("Введите ПИН : {PIN}");
    rightPIN = int.Parse (Console.ReadLine());
    popitka++;
}
while (PIN != rightPIN);
Console.WriteLine($"Число попыток {popitka}");

bool Terminal;
while (true)
{
    Console.WriteLine("Yes or No");
    if ( answer == "Yes" )
    {
        Console.WriteLine("Yes");
    }
    else (answer == "No")
}
