// Run this code online: http://ideone.com/fork/3D8DbI
#define TEST
#define STEP_BY_STEP
//#define FINAL_VERSION
using System;

class ConditionalCompilation
{
    public static void Main(string[] args)
    {
        int abc = 0;
        for (int i = 10; i < 100; i++)
        {
            abc += i;
#if (STEP_BY_STEP && TEST) && !FINAL_VERSION
            Console.WriteLine("At " + i + " abc is " + abc);
#endif
        }
#if TEST && !FINAL_VERSION
        Console.WriteLine("Partial result is " + abc);
#else
        Console.WriteLine("No partial result for you :(");
#endif

        for (int i = 100; i < 1000; i++)
        {
            abc += i;
        }
        Console.WriteLine("Final result is: " + abc);

        // Uncomment if running in Visual
        //Console.ReadKey();
    }
}
