using System;

namespace RockPaperScissros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What`s you name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);
            

            int ComputerScore = 0;
            int UserScore = 0;
            while (ComputerScore < 3 && UserScore < 3)
            {




                Random r = new Random();
                int computerChoice = r.Next(4);
                Console.WriteLine("Do you choose rock,paper or scissors");
                string userChoice = Console.ReadLine();

                if (computerChoice == 1)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("It is a tie");
                        
                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("It is a tie ");
                        
                        

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("It is a tie ");

                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");

                    }

                }

                else if (computerChoice == 2)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine($"Sorry you lose,paper beat rock {ComputerScore + 1} score for computer");
                        
                        ComputerScore++;

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine($"Sorry you lose,scissors beat paper {ComputerScore + 1} score for computer ");
                        
                        ComputerScore++;

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine($"Sorry you lose,rock beats scissors {ComputerScore + 1} score for computer");
                       
                        ComputerScore++;

                    }
                    else
                    {
                        Console.WriteLine($"You must choose rock,paper or scissors!");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine($"You score,rock beats scissors {UserScore + 1} score for you");
                        
                        UserScore++;

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine($"You score,paper beats rock {UserScore + 1} score for you");
                       
                        UserScore++;

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine($"You score,scissors beat paper {UserScore + 1} score for you");
                        UserScore++;

                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");
                    }


                }






            } if (UserScore == 3)
            {
                Console.WriteLine($"Your score is {UserScore = 3},you win");
            
            }   else if (ComputerScore == 3)

            {
                  

                Console.WriteLine($"Computer score is {ComputerScore = 3},you lose");
            }
        
             
        }
    }
}