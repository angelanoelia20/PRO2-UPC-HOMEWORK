using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el número de términos para la serie de Fibonacci:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Serie de Fibonacci:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
