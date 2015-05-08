// Run this code online: http://ideone.com/fork/oEQ9Ef
using System;

class Arrays
{
    public static void Main(string[] args)
    {
        // One dimension array:
        //char[] vocales = new char[5];
        //vocales[0] = 'a';
        //vocales[1] = 'e';
        //vocales[2] = 'i';
        //vocales[3] = 'o';
        //vocales[4] = 'u';
        //char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
        char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
        Console.WriteLine("Las vocales:");
        for (int j = 0; j < vocales.Length; j++)
        {
            Console.Write(vocales[j]);
        }
        Console.WriteLine();
        Console.WriteLine();



        // Rectangular array:
        char[,] gato1 = new char[3, 3];
        char[,] gato = // new char[,]
		{
			{'o', 'x', 'o'},
			{'o', 'x', 'o'},
			{'o', 'x', 'o'}
		};

        Console.WriteLine("¡Gato!");
        for (int i = 0; i < gato.GetLength(0); i++)
        {
            for (int j = 0; j < gato.GetLength(1); j++)
            {
                Console.Write(gato[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        // Jagged arrays:
        Console.WriteLine("¡Gato deforme!");
        char[][] noGato1 = new char[3][];
        noGato1[0] = new char[2];
        noGato1[1] = new char[3];
        noGato1[2] = new char[1];

        char[][] noGato =
		{
			new char [] {'o', 'x'},
			new char [] {'o', 'x', 'o'},
			new char [] {'o'}
		};

        for (int i = 0; i < noGato.Length; i++)
        {
            for (int j = 0; j < noGato[i].Length; j++)
            {
                Console.Write(noGato[i][j]);
            }
            Console.WriteLine();
        }

        // D: D: D: D: 
        int[,][][][, , ,][] wtf = new int[2, 3][][][,,,][];


        // Uncomment if running in Visual
        Console.ReadKey();
    }
}
