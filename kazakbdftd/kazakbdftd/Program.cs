using System;

class Program
{
    static void Main()
    {
        //1
        int n = 12;

        if (n < 1 || n > 12)
        {
            Console.WriteLine("1 <= N <= 12");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{0,5}", i * j);
            }

            Console.WriteLine();
        }

        //3

        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
            alphabet[i] = (char)('A' + i);
        foreach (char letter in alphabet)
            Console.Write(letter + " ");
        Console.WriteLine();


        int R = 5;
        int C = 10;


        if (R >= 1 && R <= 20 && C >= 1 && C <= 20)
        {
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Размеры должны быть в диапазоне от 1 до 20.");
        }

    }
}
    


