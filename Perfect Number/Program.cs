using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class program
{
   

   static int ReadPositiveNumber(string message)
    {
      
        int number;
        do
        {
            Console.WriteLine(message);
        } while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);

        return number;
    }

    static bool IsPerfectNumber(int number)
    {
     
        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                sum += i;
        }

        return number == sum;
    }

    static void PrintResults(int number)
    {
        if (IsPerfectNumber(number))
            Console.WriteLine($"{number} is a Perfect Number.");
        else
            Console.WriteLine($"{number} is NOT a Perfect Number.");

    }


    static void Main()
    {
       
        PrintResults(ReadPositiveNumber("Please enter a positive number:"));


    }
}
