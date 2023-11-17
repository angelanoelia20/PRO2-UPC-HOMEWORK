class Program
{
    static void Main()
    {
        ArrayEntero arrayEnteroA = new ArrayEntero(5);
        arrayEnteroA.Elementos[0] = 3;
        arrayEnteroA.Elementos[1] = 10;
        arrayEnteroA.Elementos[2] = 20;
        arrayEnteroA.Elementos[3] = 2;
        arrayEnteroA.Elementos[4] = 7;

        ArrayEntero arrayEnteroB = new ArrayEntero(3);
        arrayEnteroB.Elementos[0] = 30;
        arrayEnteroB.Elementos[1] = 100;
        arrayEnteroB.Elementos[2] = 200;

        ArrayCadena arrayCadenaA = new ArrayCadena(4);
        arrayCadenaA.Elementos[0] = "claudia";
        arrayCadenaA.Elementos[1] = "Maria";
        arrayCadenaA.Elementos[2] = "andres";
        arrayCadenaA.Elementos[3] = "fernando";

        ArrayCadena arrayCadenaB = new ArrayCadena(5);
        arrayCadenaB.Elementos[0] = "carmelo";
        arrayCadenaB.Elementos[1] = "claudia";
        arrayCadenaB.Elementos[2] = "seni";
        arrayCadenaB.Elementos[3] = "jose";
        arrayCadenaB.Elementos[4] = "valentina";

        Console.WriteLine($"---------------------------------");
        arrayEnteroA.MostrarMaxMin();
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Suma: {arrayEnteroA.Suma()}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Promedio: {arrayEnteroA.Promedio()}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Frecuencia Elemento: {arrayEnteroA.Frecuencia(10)}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Buscar Elemento: {arrayCadenaA.BuscarElemento("Claudia")}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Frecuencia Elemento: {arrayCadenaA.Frecuencia("Claudia")}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Complemento: {string.Join(", ", arrayCadenaA.Complemento(arrayCadenaB))}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"ArrayCadena to ArrayEntero: {string.Join(", ", arrayCadenaA.ArrayCadenaToArrayEntero())}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Diferencia: {string.Join(", ", arrayCadenaA.Diferencia(arrayCadenaB))}");
        Console.WriteLine($"---------------------------------");
        arrayCadenaA.Invertir();
    }
}