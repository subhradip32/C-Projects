using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPC_Game
{
    class Program
    {
        static string Genrate(String[] ElementsList)
        {
            Random choice = new Random();
            int num = choice.Next(ElementsList.Length);
            return ElementsList[num];
        }
        static String Ask()
        {
            Console.WriteLine("Enter your choice (Rock/Paper/Scissor): ");
            return Console.ReadLine();
        }
        static void Main()
        {
            int Score = 0;
            String[] Elements = {"Rock","Paper","Scissor"}; 
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine($"Current Score: {Score}");
                Console.ResetColor();
                String ask =Ask();
                if (ask == "")
                {
                    break; 
                }
                else
                {
                    string Pcchoice = Genrate(Elements);
                    if (ask == Pcchoice) {
                        Score++; 
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine($"Genrated Choice: {Pcchoice}");
                    Console.ResetColor();
                    Console.WriteLine("<-------------------------------------------->");
                }
            }
        }

        
    }
}
