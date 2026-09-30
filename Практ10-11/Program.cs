using System;

class Program
{
    static void Main()
    {

        double v1 = 1, v2 = 2, v3 = 3, v4 = 4;
       Console.WriteLine($"Первый вектор = ({v1}; {v2}; {v3}; {v4})");

        double v5 = 5, v6 = 6, v7 = 7, v8 = 8;
        Console.WriteLine($"Второй вектор = ({v5}; {v6}; {v7}; {v8})");

        double Scalar = v1*v5 + v2*v6 + v3*v7 + v4*v8;
        Console.WriteLine($"Скалярное произведение = {Scalar}");

        double Dlina1v = Math.Sqrt(v1*v1 + v2*v2 + v3*v3 + v4*v4);
        double Dlina2v = Math.Sqrt(v5*v5 + v6*v6 + v7*v7 + v8*v8);

        
        Console.WriteLine($"Длина первого вектора = {Dlina1v}");
        Console.WriteLine($"Длина второго вектора = {Dlina2v}");

         Console.WriteLine ("Задание 2");
        double x = 5, w = 1, b = 0;
        Console.WriteLine($"x = {x}; w = {w}; b = {b}");

        double z = w * x + b;
        Console.WriteLine($"z = {z}");

        double y = 1 / (1 + Math.Exp(-z));
        Console.WriteLine($"Сигмоида = {y}");

        double q = y * (1 - y);
        Console.WriteLine($"Производная сигмоиды = {q}");


         Console.WriteLine ("Задание 3");

        double T = 1500, C = 7, B = 2;
        Console.WriteLine($"Количество токенов = {T}");
        Console.WriteLine($"Среднее количество символов на токен = {C}");
        Console.WriteLine($"Количество байт на символ = {B}");
        double S = T * C;
        Console.WriteLine($"Приблизительное число символов = {S}");
        double KB = S * B / 1024;
        Console.WriteLine($"Приблизительный объём текста в килобайтах = {KB}");

    }
    
}

