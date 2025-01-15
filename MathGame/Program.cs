using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace MathGame
{
    internal class Program 
    {
        public static List<Games> gameshistory = new List<Games>();






        static void Main(string[] args)
        {
            
            

            
            #region OperationChoice
            OperationChoice:
            Console.WriteLine("Welcome to my first Math Game!");
            Console.Write("Pick your poison: ");
            Console.WriteLine("1 - Sum, 2 - Subtraction, 3 - Multiplication, 4 - Division, 5 - Game history");
            
            string OpAnswer = Console.ReadLine().ToString();
            
            if (OpAnswer == "5")
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------");
                foreach (Games game in gameshistory)
                {
                    Console.WriteLine($"Operation: {game.n1} {game.OperationType} {game.n2}");
                    Console.WriteLine($"Answer: {game.answer}");
                    Console.WriteLine($"Result: {game.winlose}");
                    Console.WriteLine("-----------------------------------------------");
                              
                }
                Console.Write("Press a key to continue.");
                Console.ReadKey();
                Console.Clear();
                goto OperationChoice;
            }
            else if (OpAnswer != "1" && OpAnswer != "2" && OpAnswer != "3" && OpAnswer != "4")
                {                        
                    Console.Clear();
                    Console.WriteLine("Invalid option.");
                    goto OperationChoice;
                    
            }

            #endregion

            int Operation = int.Parse(OpAnswer);
        DifficultyChoice:
            Console.WriteLine("Now choose the difficulty level:");
            Console.WriteLine("1 - Easy, 2 - Normal, 3 - Hard");

            string difficultyLevel = Console.ReadLine().ToString();            
            if (difficultyLevel != "1" && difficultyLevel != "2" && difficultyLevel != "3")
            {
                Console.Clear();
                Console.WriteLine("Invalid option.");
                goto DifficultyChoice;
            }
                        
            Method.PerformOperation(Operation, int.Parse(difficultyLevel));

            goto OperationChoice;
            

          

        }




       
       




    }


}

