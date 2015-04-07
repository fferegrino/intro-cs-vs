using System;

class Numerics
{
	public static void Main (string[] args)
	{

		int hex = 0x01;
		int blue = 0x0000ff;

		//// Coming in C# 6.0:
		//int binario = 0b0101;
		int binario = Convert.ToInt32("0101",2);

		int seis = 6;
		uint diff = UInt32.MaxValue - Int32.MaxValue;
		long diffLong = diff;
		var uno = 1L;

		// Error:
		//int dos = 3 - uno;
		var dos = 3 - uno;

		if (2 == dos) {
			Console.WriteLine ("2 == dos");
		}

		double tr1 =  1 / 3;
		double tr2 = 1D / 3;
		float tr3 = 1F / 3;
		decimal tr4 = 1M / 3;
		Console.WriteLine (tr1 + " " + tr1 *3);
		Console.WriteLine (tr2 + " " + tr2 *3);
		Console.WriteLine (tr3 + " " + tr3 *3);
		Console.WriteLine (tr4 + " " + tr4 *3);

		//// Uncomment if running in Visual
		//Console.ReadKey();
	}
}
