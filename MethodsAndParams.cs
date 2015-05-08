using System;

class MethodsAndParams
{
    public static void Main(string[] args) // <- Este es un método
    {
        string cincoString = "5";
        int cincoInt = Int32.Parse("5");

        Console.WriteLine(cincoInt);
        Console.WriteLine(cincoInt.ToString());
        //      ^^^^^^             ^^^^^^^^
        //      static             de clase
        Console.WriteLine(); // Salto de carro


        int aa = 1, bb = 9;
        int c1 = 0, c2;

        // Para los métodos estáticos no es necesario instanciar la clase
        Console.WriteLine("Suma estática:");
        Console.WriteLine(Sumas.SumaStatic(aa, bb));
        Console.WriteLine(); // Salto de carro


        Console.WriteLine("Suma estática (usando ref):");
        Console.WriteLine("Antes:\t\t" + c1);
        Sumas.SumaStaticRef(aa, bb, ref c1);
        Console.WriteLine("Después:\t" + c1);
        Console.WriteLine(); // Salto de carro

        // Para los métodos de clase es necesario instanciar la clase
        Sumas sumas = new Sumas();


        Console.WriteLine("Suma normal, sin ref");
        c1 = 0;
        Console.WriteLine("Antes:\t\t" + c1);
        sumas.SumaNormal(aa, bb, c1);
        Console.WriteLine("Después:\t" + c1);
        Console.WriteLine(); // Salto de carro

        Console.WriteLine("Suma normal, con ref");
        c1 = 0;
        Console.WriteLine("Antes:\t\t" + c1);
        sumas.SumaNormal(aa, bb, c1);
        Console.WriteLine("Después:\t" + c1);
        Console.WriteLine(); // Salto de carro

        Console.WriteLine("Suma normal, con out");

        //Console.WriteLine("Antes:\t\t" + c2); // Error, porque c2 no está inicializada
        sumas.SumaOut(aa, bb, out c2);
        Console.WriteLine("Después:\t" + c2);
        Console.WriteLine(); // Salto de carro

        // Uncomment if running in Visual
        //Console.ReadKey();
    }

    class Sumas
    {
        public void SumaNormal(int a, int b, int c)
        {
            c = a + b;
        }

        public int SumaNormal(int a, int b)
        {
            return a + b;
        }

        public void SumaRef(int a, int b, ref int c)
        {
            c = a + b;
        }

        public void SumaOut(int a, int b, out int c)
        {
            c = a + b;
        }

        public static int SumaStatic(int a, int b)
        {
            return a + b;
        }
        public static void SumaStaticRef(int a, int b, ref int c)
        {
            c = a + b;
        }
    }
}
