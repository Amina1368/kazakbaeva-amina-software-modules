//double a = double.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int d = int.Parse(Console.ReadLine());
//if (a >= 0)
//{
//    Console.WriteLine("Число а положительное");
//}
//else if (a == 0)
//{
//    Console.WriteLine("Число а равно 0");
//}
//else if (a < 0)
//{
//    Console.WriteLine("Число а отрицательное");
//}
//switch (b)
//{
//    case 0: Console.WriteLine("Число b равно 0");
//        break;
//    case 1: Console.WriteLine("Число b положительное");
//        break;
//    case -1: Console.WriteLine("Число b отрицательное");
//        break;
//}

using System;

class Program
{
    static void Main()
    { 
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());

        double[] numbers = { a, b, c, d };

       
        int positiveCount = 0;
        int zeroCount = 0;
        int negativeCount = 0;
        foreach (double num in numbers)
        {
            if (num > 0)
            {
                positiveCount++;
            }
            else if (num < 0)
            {
                negativeCount++;
            }
            else 
            {
                zeroCount++;
            }
        }

        Console.WriteLine($"Положительных чисел: {positiveCount}");
        Console.WriteLine($"Равных нулю: {zeroCount}");
        Console.WriteLine($"Отрицательных чисел: {negativeCount}");
    }
}
