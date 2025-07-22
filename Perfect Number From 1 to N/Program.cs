using System;

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





    static void PrintNumberPerfectFROM_1_to_N(int number)
    {
        for (int i = 1; i <= number; i++)
            if (IsPerfectNumber(i))
                Console.WriteLine(i);

    }

    static void Main()
    {

        PrintNumberPerfectFROM_1_to_N(ReadPositiveNumber("Please enter a positive number:"));


    }

}