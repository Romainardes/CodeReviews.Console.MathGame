using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public static class Method
    {
        public static int num1 {  get; set; }
        public static int num2 { get; set; }
        public static int answer {  get; set; }
        public static string OpAnswer { get; set; }
        public static string difficultyLevel { get; set; }


        public static void PerformOperation(int OperationMethod, int DifficultyMethod)
        {
            Random r = new Random();    
            OpAnswer = OperationMethod.ToString();
            difficultyLevel = DifficultyMethod.ToString();                      
            string[] opstring = new string[2];
            
            switch (OpAnswer)
            {
                
                case "1":
                    opstring[0] = "sum ";
                    opstring[1] = "+ ";
                    if (difficultyLevel == "1")
                    {
                        num1 = r.Next(10);                       
                        num2 = r.Next(10);                        
                        answer = num1 + num2;                        
                    }
                    else if (difficultyLevel == "2")
                    {
                        num1 = r.Next(101, 999);
                        num2 = r.Next(11, 99);
                        answer = num1 + num2;
                        
                    }
                    else
                    {
                        num1 = r.Next(10001, 99999);
                        num2 = r.Next(10001, 99999);
                        answer = num1 + num2;
                        
                    }
                    break;

                case "2":
                    opstring[0] = "subtraction ";
                    opstring[1] = "- ";

                    if (difficultyLevel == "1")
                    {
                        num1 = r.Next(5, 10);
                        num2 = r.Next(1, 5);
                        answer = num1 - num2;
                        
                    }
                    else if (difficultyLevel == "2")
                    {
                        num1 = r.Next(51, 99);
                        num2 = r.Next(1, 49);
                        answer = num1 - num2;
                        
                    }
                    else
                    {
                        num1 = r.Next(10001, 99999);
                        num2 = r.Next(1999, 9999);
                        answer = num1 - num2;
                        
                    }
                    break;

                case "3":
                    opstring[0] = "multiplication ";
                    opstring[1] = "x ";
                    if (difficultyLevel == "1")
                    {
                        num1 = r.Next(5, 10);
                        num2 = r.Next(1, 5);
                        answer = num1 * num2;
                        

                    }
                    else if (difficultyLevel == "2")
                    {
                        num1 = r.Next(51, 99);
                        num2 = r.Next(1, 49);
                        answer = num1 * num2;
                        
                    }
                    else
                    {
                        num1 = r.Next(101, 999);
                        num2 = r.Next(101, 999);
                        answer = num1 * num2;
                        
                    }
                    break;
                case "4":
                    opstring[0] = "division ";
                    opstring[1] = "/ ";
                Reroll:
                    if (difficultyLevel == "1")
                    {
                        num2 = r.Next(1, 100);
                        answer = r.Next(1, 50);
                        if (answer * num2 > 100)
                        {
                            goto Reroll;
                        }
                        else
                        {
                            num1 = answer * num2;
                        }
                        
                    }
                    //  Observation: since I chose to implement difficulty levels,
                    //  Im allowing dividends > 100 in difficulties 2-3

                    else if (difficultyLevel == "2")
                    {
                        num2 = r.Next(5, 400);
                        answer = r.Next(3, 40);
                        num1 = answer * num2;
                        
                    }
                    else
                    {
                        num2 = r.Next(101, 999);
                        answer = r.Next(6, 50);
                        num1 = answer * num2;
                        
                    }
                    break;
            }
            Console.WriteLine("What is the result of the " + opstring[0] + num1 + " " + opstring[1] + num2 + "?");
            DateTime inicial = DateTime.Now;

            if (Console.ReadLine().ToString() == answer.ToString())
            {
                Games t = new Games(opstring[1], num1, num2, answer, "Won");
                Program.gameshistory.Add(t);
                Console.WriteLine("Correct answer!");
                
            }
            else
            {
               
                Games t = new Games(opstring[1], num1, num2, answer, "Lost");
                Program.gameshistory.Add(t);
                Console.WriteLine("Wrong answer :( Try again!");
                
            }
            DateTime final = DateTime.Now;
            TimeSpan ts = final - inicial;
            double totalSeconds = ts.TotalSeconds;
            string formatted = totalSeconds.ToString("F2");

            Console.WriteLine($"Your calculation took " + formatted + " seconds!");
            Console.WriteLine("Press a key to play again.");
            Console.ReadLine();
        }




    }


    
}
