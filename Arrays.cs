// Run this code online: http://ideone.com/fork/i2I3mO
using System;

class Arrays
{
	public static void Main (string[] args)
	{
		// Rectangular array:
		char[,] gato1 = new char[3,3];
		char[,] gato = // new char[,]
		{
			{'o', 'x', 'o'},
			{'o', 'x', 'o'},
			{'o', 'x', 'o'}
		};

		for(int i = 0; i < gato.GetLength(0);i++)
		{
			for(int j = 0; j < gato.GetLength(1); j++)
			{
				Console.Write(gato[i,j]);
			}
			Console.WriteLine ();
		}


		// Jagged arrays:
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

		for(int i = 0; i < noGato.Length ;i++)
		{
			for(int j = 0; j < noGato[i].Length; j++)
			{
				Console.Write(noGato[i][j]);
			}
			Console.WriteLine ();
		}


		int [,][][][,,,][] wtf = new int[2,3][][][,,,][];


		//// Uncomment if running in Visual
		//Console.ReadKey();
	}
}
