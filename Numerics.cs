// Run this code online: http://ideone.com/fork/4qCTGn
#define CS6 // Siempre en la primera línea del archivo
#undef CS6 // La "desdefinimos" descomentando esta línea
#define VISUAL
using System;
// ...

class Numerics
{
    public static void Main(string[] args)
    {

        int hex = 0x01;
        int blue = 0x0000ff;
        int binario, binario2;
        int numerote;
#if CS6
        // Código si está definida CS6
        binario = 0b010010101;
        binario2 = 0b010_010_101;
        numerote = 7_361_092;
#else
        // Código si no lo está
        binario = Convert.ToInt32("10010101", 2);
        numerote = 7361092;
#endif

        int seis = 6;
        uint diff = UInt32.MaxValue - Int32.MaxValue;
        long diffLong = diff;
        var uno = 1L;

        // Error:
        //int dos = 3 - uno;
        var dos = 3 - uno;

        if (2 == dos)
        {
            Console.WriteLine("2 == dos");
        }

        // NaN
        //var nan = 0 / 0;
        var nan = 0.0/0.0;
        if(nan == Double.NaN)
        {
            Console.WriteLine("nan y Double.NaN son iguales"); // Nunca, nunca se ejecutará
        }
        else
        {
            Console.WriteLine("El operador == no se puede emplear para saber si un número es NaN");
            if (Double.IsNaN(nan))
            {
                Console.WriteLine("Debemos usar el método de clase Double.IsNan, por cierto un NaN se ve así: " + nan);
            }
        }


        // Negative and positive infinity
        double negInf = -1 / 0.0;
        double posInf = 1 / 0.0;
        Console.WriteLine("Infinito negativo: " + negInf);
        Console.WriteLine("Infinito positivo: " + posInf);

        
        //// Precisión de reales
        //double resDivisionEntera = 1 / 3;
        //double resultadoDouble = 1D / 3;
        //float resultadoFloat = 1F / 3;
        //decimal resultadoDecimal = 1M / 3;
        //Console.WriteLine(resDivisionEntera + " " + resDivisionEntera * 3);
        //Console.WriteLine(resultadoDouble + " " + resultadoDouble * 3);
        //Console.WriteLine(resultadoFloat + " " + resultadoFloat * 3);
        //Console.WriteLine(resultadoDecimal + " " + resultadoDecimal * 3);

#if VISUAL
        Console.ReadKey();
#endif
    }
}
