class Recursividad
{
    public long CalcularFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            // Caso base: el factorial de 0 y 1 es 1
            return 1;
        }
        else
        {
            // Caso recursivo: n! = n * (n-1)!
            return n * CalcularFactorial(n - 1);
        }
    }
}