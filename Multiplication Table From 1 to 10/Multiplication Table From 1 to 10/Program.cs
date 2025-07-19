using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_From_1_to_10
{
    class Program
    {

        static void header()
        {
            Console.WriteLine("\t\t Multiplication Table From 1 to 10 \n\n");
            Console.WriteLine("\t");

            for(int i=1;i<=10;i++)
            {
                Console.Write("  "+i + "  " );
            }
           
            Console.Write("\n====================================================\n");
        }

       

        static void printTaple()
        {
            header();
           
            for (int i = 1; i <= 10; i++)
            {
               
                Console.Write($"{i,2} | ");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            printTaple();
          Console.WriteLine();
        }
    }
}
