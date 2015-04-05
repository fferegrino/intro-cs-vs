// Run this code online: http://ideone.com/fork/OSRRUI
using System;

class ValueAndReferenceTypes
{

    static void Main(string[] args)
    {
        var timeReference1 = new TimeReference();
        TimeReference timeReference2 = timeReference1;

        // Modify only one instance
        timeReference1.Minutes = 15;
        timeReference1.Hours = 12;

        Console.WriteLine("Reference types:");
        Console.WriteLine("timeReference1:\tHours: " + timeReference1.Hours + "\tMinutes: " + timeReference1.Minutes);
        Console.WriteLine("timeReference2:\tHours: " + timeReference2.Hours + "\tMinutes: " + timeReference2.Minutes);

        var timeValue1 = new TimeValue();
        TimeValue timeValue2 = timeValue1;

        // Modify only one instance
        timeValue1.Minutes = 15;
        timeValue1.Hours = 12;

        Console.WriteLine("Value types:");
        Console.WriteLine("timeValue1:\tHours: " + timeValue1.Hours + "\tMinutes: " + timeValue1.Minutes);
        Console.WriteLine("timeValue2:\tHours: " + timeValue2.Hours + "\tMinutes: " + timeValue2.Minutes);


        //// Uncomment if running in Visual Studio:
        //Console.ReadKey();
    }
}

struct TimeValue
{
    public int Hours;
    public int Minutes;
}

class TimeReference
{
    public int Hours;
    public int Minutes;
}
