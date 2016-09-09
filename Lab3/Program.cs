using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!\n");
            string DOYOUWANTTOCONTINUE;
            do
            {
                Console.Write("Enter an integer:\n");
                string Input = Console.ReadLine();
                Console.WriteLine();

                
                    Console.WriteLine("Number   Squared     Cubed");
                    Console.WriteLine("=======  =======     ======");
                    for (int value = 1; value <= int.Parse(Input); value++)

                    {
                        int squared = (int)Math.Pow(value, 2);
                        int cubed = (int)Math.Pow(value, 3);
                        Console.WriteLine("{0}        {1:N0}           {2:N0}",
                                            value, squared, cubed);
                    }
                    Console.WriteLine();
                    Console.Write("Continue? (y/n): ");
                    DOYOUWANTTOCONTINUE = Console.ReadLine();
                    Console.WriteLine();


            } while (DOYOUWANTTOCONTINUE == "y");
            Console.WriteLine("Goodbye!");
         }
    }
}
