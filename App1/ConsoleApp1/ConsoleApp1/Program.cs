using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("AGE: ");
                int Age = Convert.ToInt32(Console.ReadLine());
                if (Age > 18)
                {
                    Console.WriteLine("you are eligible for voting");
                }
                else if(Age == 0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("you are not eligible for voting");
                }
                Console.ReadLine();
            }
                
        }
    }
}
