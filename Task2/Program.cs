using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string numberInput = Console.ReadLine();
        int number = int.Parse(numberInput);

        if(number % 2 == 0 )
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}