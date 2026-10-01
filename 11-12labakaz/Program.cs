using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите num1: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Введите num2: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = Math.Abs(num1) < Math.Abs(num2) ? num1 : num2;
        Console.WriteLine($"Ближайшее к нулю: {result}");

        Console.WriteLine("Задание 2");

        Console.Write("Введите целое число: ");
        int Oprednum = int.Parse(Console.ReadLine());

        if (Oprednum > 0 && Oprednum % 2 == 0)
            Console.WriteLine($"{Oprednum} — положительное и чётное");

        else if (Oprednum > 0 && Oprednum % 2 != 0)
            Console.WriteLine($"{Oprednum} — положительное и нечётное");

        else if (Oprednum < 0 && Oprednum % 2 == 0)
            Console.WriteLine($"{Oprednum} — отрицательное и чётное");

        else if (Oprednum < 0 && Oprednum % 2 != 0)
            Console.WriteLine($"{Oprednum} — отрицательное и нечётное");

            Console.WriteLine("Задание 3");

        Console.WriteLine("1 — создать файл");
        Console.WriteLine("2 — открыть");
        Console.WriteLine("3 — сохранить");
        Console.WriteLine("4 — закрыть");
        Console.Write("Введите номер команды: ");

        int command = int.Parse(Console.ReadLine());
        string name;

        switch (command)
        {
            case 1: name = "Создать файл"; break;
            case 2: name = "Открыть";      break;
            case 3: name = "Сохранить";    break;
            case 4: name = "Закрыть";      break;
            default: name = "Неизвестная команда"; break;
        }

        Console.WriteLine($"Вы выбрали: {name}");

        Console.WriteLine("Задание 4");

        Console.Write("Введите сумму покупки: ");
        double sum = double.Parse(Console.ReadLine());

        int discount;

        switch (sum)
        {
            case < 1000:              discount = 0;  break;
            case >= 1000 and < 5000:  discount = 5;  break;
            case >= 5000 and < 10000: discount = 10; break;
            default:                  discount = 15; break;
        }

        Console.WriteLine($"Сумма: {sum} руб.");
        Console.WriteLine($"Скидка: {discount}%");
    }
}
    