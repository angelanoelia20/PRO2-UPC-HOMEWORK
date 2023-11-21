using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número para calcular su factorial: ");
        int num = int.Parse(Console.ReadLine());

        Recursividad recursividad = new Recursividad();
        long factorial = recursividad.CalcularFactorial(num);

        Console.WriteLine($"El factorial de {num} es: {factorial}");
    }
}
