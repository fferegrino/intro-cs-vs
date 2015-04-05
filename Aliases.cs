// Run this code online: http://ideone.com/fork/crXMAD
using System;

class Aliases
{
	public static void Main (string[] args)
	{
		// Cool:
		int five1 = Int32.Parse("5");

		// This works but...
		Int32 five2 = int.Parse("5");

		if (five1 == five2) {
			Console.WriteLine ("five1 y FIVE2 son iguales");
		}


		// Cool:
		string emptyString1 = String.Empty;

		// This works but...
		String emptyString2 = string.Empty;

		if (emptyString1 == emptyString2) {
			Console.WriteLine ("emptyString1 y emptyString2 son iguales");
		}

		//// Uncomment if running in Visual
		//Console.ReadKey();
	}
}
