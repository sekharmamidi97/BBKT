using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBKT
{
    class Program
    {
        static void Main(string[] args)
        {
            bool wantToPlay = true;
            while (wantToPlay)
            {
                Console.WriteLine("Do you choose a bowling ball, a steak knife, or a tablecloth?");
                string playerChoice = Console.ReadLine();

                Random rm = new Random();
                int computerSelection = rm.Next(1,4);

                if (computerSelection == 1)
                {

                    if (playerChoice == "steak knife")
                    {
                        Console.WriteLine("The computer chose a steak knife!");
                        Console.WriteLine("You tied with the computer!");
                    }

                    else if (playerChoice == "bowling ball")
                    {
                        Console.WriteLine("The computer chose a bowling ball!");
                        Console.WriteLine("You tied with the computer!");
                    }

                    else if (playerChoice == "tablecloth")
                    {
                        Console.WriteLine("The computer chose a tablecloth!");
                        Console.WriteLine("You tied with the computer!");
                    }

                    else
                    {
                        Console.WriteLine("You must choose your weapon! A steak knife, bowling ball, or tablecloth!");
                    }
                }
                else if (computerSelection == 2)
                {

                    if (playerChoice == "steak knife")
                    {
                        Console.WriteLine("The computer chose a tablecloth!");
                        Console.WriteLine("A steak knife can cut a tablecloth, you beat the computer, and you win!");
                    }

                    else if (playerChoice == "bowling ball")
                    {
                        Console.WriteLine("The computer chose a steak knife!");
                        Console.WriteLine("A bowling ball crushes the steak knife, you beat the computer, and you win!");
                    }

                    else if (playerChoice == "tablecloth")
                    {
                        Console.WriteLine("The computer chose a bowling ball!");
                        Console.WriteLine("The tablecloth covers the bowling ball, you beat the computer, and you win!");
                    }

                    else
                    {
                        Console.WriteLine("You must choose your weapon! A steak knife, bowling ball, or tablecloth!");
                    }
                }
                else if (computerSelection == 3)
                {
                    if (playerChoice == "steak knife")
                    {
                        Console.WriteLine("The computer chose a bowling ball!");
                        Console.WriteLine("Doh! A bowling ball crushes the steak knife, the computer beat you, and you lose!");
                    }

                    else if (playerChoice == "bowling ball")
                    {
                        Console.WriteLine("The computer chose a tablecloth!");
                        Console.WriteLine("Doh! The tablecloth covers the bowling ball, the computer beat you, and you lose!");
                    }

                    else if (playerChoice == "tablecloth")
                    {
                        Console.WriteLine("The computer chose a steak knife!");
                        Console.WriteLine("Doh! The steak knife cuts the tablecloth, the computer beat you, and you lose!");
                    }

                    else
                    {
                        Console.WriteLine("You must choose your weapon! A steak knife, bowling ball, or tablecloth!");

                    }

                    Console.WriteLine("Do you want play this game again? y = yes or n = no");
                    ConsoleKeyInfo key = Console.ReadKey();
                    Console.WriteLine();
                    wantToPlay = key.KeyChar == 'y';
                }
            }

        }
    }
}

