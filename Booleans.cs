// Run this code online: http://ideone.com/fork/9oHRIW
using System;
using System.Collections;

class Booleans
{
	public static void Main (string[] args)
	{

		var boolArray = new bool[100]; // 100 bytes
		var bitArray = new BitArray(100);

		bitArray [10] = true;
		boolArray [10] = true;

		// Short circuited
		if (ReturnFalse ("1a") && ReturnTrue ("1b")) {
		}

		// Non short circuited
		if (ReturnFalse ("2a") & ReturnTrue ("2b")) {
		}


		// Short circuited
		if (ReturnTrue ("3a") ||  ReturnFalse ("1b")) {
		}

		// Non short circuited
		if (ReturnTrue ("4a") |  ReturnFalse ("4b")) {
		}

		//// Uncomment if running in Visual Studios
		//Console.ReadKey();
	}

	static bool ReturnFalse(string message)
	{
		Console.WriteLine (message);
		return false;
	}

	static bool ReturnTrue(string message)
	{
		Console.WriteLine (message);
		return true;
	}
}
