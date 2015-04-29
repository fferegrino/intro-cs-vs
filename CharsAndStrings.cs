// Run this code online: http://ideone.com/fork/xUWjOj
using System;

class CharsAndStrings
{
    public static void Main(string[] args)
    {
        char slash = '\\';
        char quote = '\"';

        string h = "mundo";
        Console.WriteLine(h);       // mundo

        string hseq = "\\mundo\\";
        Console.WriteLine(hseq);    // \mundo\

        string hver = @"\\mundo\\";
        Console.WriteLine(hver);    // \\mundo\\

        string a = h + hseq + hver;
        Console.WriteLine(a);// mundo\mundo\\\mundo\\

        var mundo = "\"mundo\"";

        if (mundo[0] == quote)
        {

            Console.WriteLine("mundo [0] == quote");
        }


        var html =
@"
<html>
    <head>
        <title>Mi página web</title>
    </head>
    <body>
    </body>
</html>
";
		Console.WriteLine(html);
		
		// TODO: Añadir uso de StringBuilder
		// This example was found at http://stackoverflow.com/questions/21644658/how-to-use-stringbuilder-wisely
		StringBuilder myString = new StringBuilder("123");
		while (Console.ReadLine() == "a")
		{
			myString.Append("+PQR"); //Average loop times 4~ or more
		}
		myString.Append("345");
		Console.WriteLine(myString.ToString());

        //// Uncomment if running in Visual
        //Console.ReadKey();
    }
}
