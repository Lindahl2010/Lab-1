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
            //Declarations
            string[] questions = { "1.", "2.", "3.", "4.", "5.", "6.", "7.", "8.", "9.", "10.", "11.", "12.", "13.", "14.", "15.", "16.", "17.", "18.", "19.", "20." };
            string[] answerKey = {"B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"};
            string[] userAnswer = new string[20];
            string userResponse;
            //string[] questionHolder = new string[20];
            List<string> questionHolder = new List<string>();
            int PASS_SCORE = 15;
            int correctHolder, incorrectHolder;
            WriteLine("This is the Minnesota Driver's License Exam. This Exam is 20 questions and will give immediate feedback on whether you passed or failed.");
            WriteLine("To get started, Press 1 or enter any key to exit the program.");
            //Input from user as the number 1 to start the program
            string start = ReadLine();
            while (start == "1")  
            {
                correctHolder = 0;
                incorrectHolder = 0;
                //Loop to go through each question and evaluate if correct or not
                for (int x = 0; x < questions.Length; x++)
                {
                    WriteLine("Question {0}", questions[x]);
                    userResponse = ReadLine();
                    userResponse = userResponse.ToUpper();
                    //While loop in case user enters something other than a,b,c or d
                    while(userResponse != "A" && userResponse != "B" && userResponse != "C" && userResponse != "D")
                    {
                        WriteLine("Invalid option, please enter a vaue that is between A-D.");
                        userResponse = ReadLine();
                    }
                    //User answers are put into an array
                    userAnswer[x] += userResponse;
                    if (userAnswer[x] == answerKey[x])
                    {
                        correctHolder += 1;
                    }
                    else
                    {
                        //questionHolder[x] += questions[x];
                        questionHolder.Add(questions[x]);
                        incorrectHolder += 1;
                    }
                }
                //If statement displaying only when the user passes the exam
                if(correctHolder >= PASS_SCORE)
                {
                    WriteLine("You passed with a score of {0} out of {1}", correctHolder, questions.Length);
                }
                //Else statement if the user needs to retake the exam
                else
                {
                    WriteLine("Sorry, please take the exam again.");
                }
                //Output of how many questions were incorrectly answered if there is any
                WriteLine("Listed below are the questions you missed (if any).");
                WriteLine("These {0} question(s) were answered incorrectly.", incorrectHolder);
                //Loop to display which questions were answered incorrectly
                for (int x = 0; x < questionHolder.Count; x++) 
                {
                    if (questionHolder.Count > 0)
                    {
                        Write("Number {0}, ", questionHolder[x]);
                    }

                }
                //Prompt to press enter to exit the program
                WriteLine("\nTo exit the program, press Enter.");
               /* while (ReadKey().Key != ConsoleKey.Enter) 
                { }*/
            }
        }
    }
}
