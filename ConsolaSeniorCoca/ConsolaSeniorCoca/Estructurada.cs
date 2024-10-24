using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaSeniorCoca;
public abstract class Estructurada
{
    public static void EjecutarEstructurada()
    {
        int numeroFeo = 8;

        int[] numeros = new int[] { 1, 2, 3, 5, 19, 12, 2, 7, 10, 4 };

        foreach (int numeroBonito in numeros)
        {
            bool numeroFeoGana = DimeSiNumeroFeoGana(numeroFeo, numeroBonito);

            if (numeroFeoGana)
            {
                Console.WriteLine("Ni modo, ganó :(");
            }
            else
            {
                Console.WriteLine("Ganó el cine, señores.");
            }
        }

    }

    private static bool DimeSiNumeroFeoGana(int numeroFeo, int numeroBonito)
    {
        return numeroFeo > numeroBonito;
    }
}
