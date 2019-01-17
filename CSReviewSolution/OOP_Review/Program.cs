using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Review
{
    class Program
    {
        static void Main(string[] args)
        {

            //new causes an instance (occurance) of the specified
            //   class to be created and placed in the
            //   receiving variable
            //the variable is a pointer address to the actual
            //   physical memory location of the instance


            //declaring an instance (occurance) of the specified
            //   class will not create a physical instance, just a 
            //   a pointer which can hold a physical instance
            Turn theTurn; // no physical instance, storage is null 

            //new cause the constructor of a class to execute
            //   and a phyiscal instance to be created

            Die Player1 = new Die(); //default
        
            Die Player2 = new Die(6, "green",1); //greedy 

            string menuChoice = "";
            do
            {
                //Console is a static class
                Console.WriteLine("\nMake a choice\n");
                Console.WriteLine("A) Roll");
                Console.WriteLine("B) Set number of dice sides");
                Console.WriteLine("C) Display Current Game Stats");
                Console.WriteLine("X) Exit\n");
                Console.Write("Enter your choice:\t");
                menuChoice = Console.ReadLine();

                //user friendly error handling
                try
                {
                    switch (menuChoice.ToUpper())
                    {
                        case "A":
                            {
                                //Turn is a non-static class
                                //therefore you need to create a new instance to use 
                                theTurn = new Turn();

                                //generate a new FaceValue
                                Player1.Roll();
                                //generate a new FaceValue
                                Player2.Roll();
                                // save the roll 
                                //     set      =        get
                                theTurn.Player1 = Player1.FaceValue;
                                theTurn.Player2 = Player2.FaceValue;
                                //method a) default constructor and individual setting


                                //method b) greedy constructor


                                //display the round results

                                Console.WriteLine("Player1 rollerd {0} {1}", Player1.FaceValue, theTurn.Player2);

                                if (Player1.FaceValue > Player2.FaceValue)
                                {
                                    Console.WriteLine("Player 1 Wins!");
                                }
                                else
                                {
                                    Console.WriteLine("Player 2 Wins!");
                                }

                                //track the round
                                break;
                            }
                        case "B":
                            {
                                string inputSides = "";
                                int sides = 0;

                                Console.Write("Enter your number of desired sides (greater than 1):\t");
                                inputSides = Console.ReadLine();

                                //using the conversion try version of parsing
                                // TryParse has two parameters
                                // one: in string to convert
                                // two: the output conversion value if the string can be
                                //      converted
                                // successful conversion returns a true bool
                                // failed conversion returns a false bool
                                if (int.TryParse(inputSides, out sides))
                                {
                                    //validation of the incoming value
                                    if (sides > 1)
                                    {
                                        //set the die instance Sides

                                    }
                                    else
                                    {
                                        throw new Exception("You did not enter a numeric value greater than 1.");
                                    }
                                }
                                else
                                {
                                    throw new Exception("You did not enter a numeric value.");
                                }
                                break;
                            }
                        case "C":
                            {
                                //Display the current players' stats
                                break;
                            }
                        case "X":
                            {
                                //Display the final players' stats
                                Console.WriteLine("\nThank you for playing.");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Your choice was invalid. Try again.");
                                break;
                            }
                    }//eos
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: " + ex.Message);
                    Console.ResetColor();
                }
            } while (menuChoice.ToUpper() != "X");
        }//eomain

        public static void DisplayCurrentPlayerStats(?????)
        {

            int wins1 = 0;
            int wins2 = 0;
            int draws = 0;

            //travser the List<Turn> to calculate wins, losses, and draws


            //display the results
            Console.WriteLine("\n Total Rounds: " + (wins1 + wins2 + draws).ToString());
            Console.WriteLine("\nPlayer1: Wins: {0}  Player2: Wins: {1}  Total Draws: {2}",
                wins1, wins2, draws);

        }
    }
}
