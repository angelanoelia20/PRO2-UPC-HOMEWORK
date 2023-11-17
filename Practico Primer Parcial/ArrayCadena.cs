using System;
using System.Linq;

public class ArrayCadena
{
    public string[] Elementos { get; set; }

    public ArrayCadena(int size)
    {
        Elementos = new string[size];
    }

    public string BuscarElemento(string elemento)
    {
        return Elementos.Contains(elemento) ? "TRUE" : "FALSE";
    }

    public int Frecuencia(string elemento)
    {
        return Elementos.Count(x => x == elemento);
    }

    public string[] Complemento(ArrayCadena arrayB)
    {
        return Elementos.Except(arrayB.Elementos).ToArray();
    }

    public int[] ArrayCadenaToArrayEntero()
    {
        return Elementos.SelectMany(s => s.Select(c => (int)c)).ToArray();
    }

    public void Invertir()
    {
        Array.Reverse(Elementos);
        Console.WriteLine(string.Join(", ", Elementos));
    }

    public string[] Diferencia(ArrayCadena arrayB)
    {
        return arrayB.Elementos.Except(Elementos).ToArray();
    }
     public void DiferenciaArrayCadenasByA(claseArrayA)
     {
        int indice = 0;
        claseArrayA C = new claseArray(ArrayCadenas.Length);
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            bool existe = false;
            string datoB = ArrayCadenas[i];
            for(int j = 0; j< ArrayCadenas.Length; j++)
            {
               if (datoB == A.ArrayCadenas[j])
               {
                    existe = true;
                    break;
               }
            }
            if (!existe)
            {
                C.ArrayCadenas[indice] = datoB;
                indice++;
            }
        }
        C.MmostrarArray();
     }
}
