
using System;

namespace csharpTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Welcome to The Number Guessing Game");
            Console.WriteLine("There are three levels: Choose  \n A for Easy,\n B for Medium and \n C for Hard");
            Console.WriteLine("====================================");

            
                string chosenLevel = Console.ReadLine();
                int guesses;
                Random rnd = new Random();
                int randomNumber;
                int userNumber;

                if (chosenLevel.ToLower() == "a")
                {
                    Console.WriteLine("Welcome to the easy Level");
                    guesses = 6;
                    randomNumber = rnd.Next(1, 10);

                    while (guesses > 0)
                    {
                        
                        Console.Write("Please enter your Number : ");
                        userNumber = int.Parse(Console.ReadLine());
                        if (userNumber == randomNumber)
                        {
                            Console.WriteLine("Congratulations!!! You got it right! ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was wrong! Try again. ");
                            guesses--;

                            Console.WriteLine("You have " + guesses + " number of guesses left to remain in the game.");
                        }
                    }
                }
                else if (chosenLevel.ToLower() == "b")
                {
                    Console.WriteLine("Welcome to the medium Level");
                    guesses = 4;
                    randomNumber = rnd.Next(1, 20);

                    while (guesses > 0)
                    {
                        
                        Console.Write("Please enter your Number : ");
                        userNumber = int.Parse(Console.ReadLine());
                        if (userNumber == randomNumber)
                        {

                            Console.WriteLine("Congratulations!!! You got it right! ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was wrong! Try again. ");
                            guesses--;

                            Console.WriteLine("You have " + guesses + " number of guesses left to remain in the game.");
                        }
                    }
                }
                else if (chosenLevel.ToLower() == "c")
                {
                    Console.WriteLine("Welcome to the hard Level");
                    guesses = 3;
                    randomNumber = rnd.Next(1, 50);

                    while (guesses > 0)
                    {
                        
                        Console.Write("Please enter your Number : ");
                        userNumber = int.Parse(Console.ReadLine());
                        if (userNumber == randomNumber)
                        {

                            Console.WriteLine("Congratulations!!! You got it right! ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was wrong! Try again. ");
                            guesses--;

                            Console.WriteLine("You have " + guesses + " number of guesses left to remain in the game.");
                        }
                    }
                }
                else{
                    Console.WriteLine("To play the game, choose between Letters A, B and C");
                }
             }
    }
}
