using System;

class ExceptionTest
{
    /*Define a class InvalidRangeException<T> that holds information about an error
     *condition related to invalid range. It should hold error message and a range definition [start … end].
     *Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
     *by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
     */

    static void PrintNumber()
    {
        int min = 0;
        int max = 100;
        Console.WriteLine("Enter number in range {0}:{1}", min, max);
        int number = int.Parse(Console.ReadLine());
        if (number < min || number > max)
        {
            throw new InvalidRangeExeption<int>(min, max);
        }
        else
        {
            Console.WriteLine("The number {0} is valid!", number);
        }
    }
    static void PrintDate()
    {
        DateTime min = new DateTime(1980, 1, 1);
        DateTime max = new DateTime(2014, 1, 20);
        Console.WriteLine("Enter date in range {0} - {1}", min, max);
        DateTime date = DateTime.Parse(Console.ReadLine());
        if (date < min || date > max)
        {
            throw new InvalidRangeExeption<DateTime>(min, max);
        }
        else
        {
            Console.WriteLine("The date {0} is valid!", date);
        }
    }
    static void Main()
    {
        try
        {
            PrintNumber();
            PrintDate();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error!\n" + ex.Message);
        }
    }
}

