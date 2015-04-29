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

		// TODO: Añadir uso de StringBuilder
		
        Console.WriteLine(html);

        //// Uncomment if running in Visual
        Console.ReadKey();
    }
}
