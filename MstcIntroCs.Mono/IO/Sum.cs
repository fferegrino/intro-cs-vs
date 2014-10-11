using System;

class Sum
{
	static void Main()
    {
		int a, b, c;
		a = Int32.Parse(Console.ReadLine());
		b = Int32.Parse(Console.ReadLine());
		c = a + b;
        Console.WriteLine(String.Format("Resultado: {0}", c));
    }
}
