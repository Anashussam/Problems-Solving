using System;

class Program
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

    static void PrintDigits(int num)
    {
        int reverse = 0;
        while(num >0)
        {
            reverse = num % 10; // تخزين باقي القسمة من الرقم 
            num = num / 10;//ازالة للرقم الاخير 
            Console.WriteLine($"Reversed number is: {reverse}");
        }
    }

    static void PrintDigits1(int num)
    {
        int reverse = 0, digits = 0;
        while (num > 0)
        {
             digits = num % 10;
            reverse = reverse * 10 + digits;
            num = num / 10; 
            
        }
        Console.WriteLine($"Reversed number is: {reverse}");
    }

   static  int SumDigits(int num)
    {
        int sum = 0, reverse = 0;
        while (num > 0)
        {
            reverse = num % 10;
            num = num / 10;
            sum = sum + reverse;
        }
        return sum;
    }
    static void Main()
    {
        //PrintDigits(ReadPositiveNumber("Please enter a positive number:"));
        //PrintDigits1(ReadPositiveNumber("Please enter a positive number:"));
        
      Console.WriteLine($"Sum Of Digits = {SumDigits(ReadPositiveNumber("Please enter a positive number:"))}");



    }
}
