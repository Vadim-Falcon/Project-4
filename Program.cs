using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Вираз r1:");
        Console.WriteLine("Введіть значення a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть значення x");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть значення t");
        int t = Convert.ToInt32(Console.ReadLine());

        if (a < 0 || x < 0 || t < 0)
        {
            Console.WriteLine("Введені некоректні дані");
            return;
        }   

        int r1 = a * x * t + a;
        Console.WriteLine($"r1 = {r1}");

        if (r1 > 10)
        {
            Console.WriteLine("r1 більше 10");
        }
        else if (r1 == 10)
        {
            Console.WriteLine("r1 дорівнює 10");
        }
        else if (r1 == 0)
        {
            Console.WriteLine("r1 дорівнює 0");
        }
        else
        {
            Console.WriteLine("r1 менше 10");
        }

        Console.WriteLine("Вираз b:");

        float b = a + x / t;
        Console.WriteLine($"b = {b}");  

        if (b > 25)
        {
            Console.WriteLine("b більше 25");
        }
        else if (b == 25)
        {
            Console.WriteLine("b дорівнює 25");
        }
        else if (b == 0)
        {
            Console.WriteLine("b дорівнює 0");
        }
        else
        {
            Console.WriteLine("b менше 25");
        }

        Console.WriteLine("Вираз r2:");
        Console.WriteLine("Введіть значення c: ");
        double c = Convert.ToInt32(Console.ReadLine());

        double r2 = a * (a + x) + c / t;
        Console.WriteLine($"r2 = {r2}");    

        if (r2 > 50)
        {
            Console.WriteLine("r2 більше 50");
        }
        else if (r2 == 50)
        {
            Console.WriteLine("r2 дорівнює 50");
        }
        else if (r2 == 0)
        {
            Console.WriteLine("r2 дорівнює 0");
        }
        else
        {
            Console.WriteLine("r2 менше 50");
        }

    }
}   