using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_1_CWEB2010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions = { "1.", "2.", "3.", "4.", "5.", "6.", "7.", "8.", "9.", "10.", "11.", "12.", "13.", "14.", "15.", "16.", "17.", "18.", "19.", "20." };
            string[] answerKey = {"B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"};
            string[] userAnswer = new string[20];
            string userResponse;
            int[] questionHolder = { 0, 0 };
            int PASS_SCORE = 15;
            int correctHolder, incorrectHolder;
            WriteLine("This is the Minnesota Driver's License Exam. This Exam is 20 questions and will give immediate feedback on whether you passed or failed.");
            WriteLine("To get started, Press Enter");
            while (ReadKey().Key == ConsoleKey.Enter);
            correctHolder = 0;
            incorrectHolder = 0;
            {
                for (int x = 0; x < questions.Length; x++)
                {
                    WriteLine("For question number {0}", (x+1));
                    userResponse = ReadLine();
                    while(userResponse != "A" && userResponse != "B" && userResponse != "C" && userResponse != "D")
                    {
                        WriteLine("Invalid option, please enter a vaue that is between A-D.");
                        userResponse = ReadLine();
                    }
                    
                }
                
                
                    
                

            }
        }
    }
}
