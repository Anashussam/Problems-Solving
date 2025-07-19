using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_prime_num_form_1_to_N
{
    class Program
    {
        enum enPrimerNotPrim { prime = 1, NotPrime = 2 };

        static int enterPositiveNumber(string message)
        {

            int Num = 0;
            do
            {
                Console.WriteLine(message);

                Num = Convert.ToInt32(Console.ReadLine());


            } while (Num <= 0);
            return Num;
        }

       static enPrimerNotPrim cheeckPrime(int num)
        {

            double i = num / 2;
                Math.Round(i);
            for(int count=2;count <= i;count++)
            {
                if(count % i ==0)
                {
                    return enPrimerNotPrim.NotPrime;
                }
            }
            return enPrimerNotPrim.prime;
        }

        static void printResult(int num)
        {
            Console.WriteLine("The num from " + 1 + " To " + num);
            Console.WriteLine("are :");

            for(int i=1;i<=num;i++)
            {
                if(cheeckPrime(i) == enPrimerNotPrim.NotPrime)
                {
                    Console.WriteLine(i );
                }
            }
        }

        static void Main(string[] args)
        {
            printResult(enterPositiveNumber("Enter Num positve:"));
        }
    }
}
