//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.senariobased
//{
//    internal class StudentQuizGrader
//    {
//        // Questions 
//        public static string[,] Questions =
//    {
//        {
//            "What is the capital of India?",
//            "Mumbai",
//            "New Delhi",
//            "Kolkata",
//            "Chennai"
//        },
//        {
//            "Which keyword is used to define a class in C#?",
//            "struct",
//            "define",
//            "class",
//            "object"
//        },
//        {
//            "Which data type is used to store true or false?",
//            "int",
//            "bool",
//            "string",
//            "char"
//        },
//        {
//            "Which symbol is used for single-line comments in C#?",
//            "/* */",
//            "#",
//            "//",
//            "<!-- -->"
//        },
//        {
//            "Which method is the entry point of a C# program?",
//            "Start()",
//            "Main()",
//            "Run()",
//            "Init()"
//        },
//        {
//            "What is the size of int in C#?",
//            "2 bytes",
//            "4 bytes",
//            "8 bytes",
//            "Depends on system"
//        },
//        {
//            "Which loop executes at least once?",
//            "for",
//            "while",
//            "foreach",
//            "do-while"
//        },
//        {
//            "Which keyword is used to inherit a class?",
//            "inherits",
//            "extends",
//            ":",
//            "base"
//        },
//        {
//            "Which collection stores key-value pairs?",
//            "List",
//            "Array",
//            "Dictionary",
//            "Stack"
//        },
//        {
//            "C# is developed by which company?",
//            "Google",
//            "Apple",
//            "Microsoft",
//            "IBM"
//        }
//    };

//        // Correct answers 
//        public static int[] CorrectAnswers =
//        {
//        2, // New Delhi
//        3, // class
//        2, // bool
//        3, // //
//        2, // Main
//        2, // 4 bytes
//        4, // do-while
//        3, // :
//        3, // Dictionary
//        3  // Microsoft
//    };

//        static int[] Quiz()
//        {
//            int[] StudentAnswer = new int[Questions.GetLength(0)];
//            for (int i = 0; i < Questions.GetLength(0); i++)
//            {
//                Console.WriteLine($"Q{i + 1}. {Questions[i, 0]}");

//                Console.WriteLine("1. " + Questions[i, 1]);
//                Console.WriteLine("2. " + Questions[i, 2]);
//                Console.WriteLine("3. " + Questions[i, 3]);
//                Console.WriteLine("4. " + Questions[i, 4]);

//                int answer = Convert.ToInt32(Console.ReadLine());
//                StudentAnswer[i] = answer;
//                if(answer == CorrectAnswers[i])
//                {
//                    Console.WriteLine("Correct Answer");
//                }
//                else
//                {
//                    Console.WriteLine("Incorrect Answer");
//                }
//                    Console.WriteLine();
//            }
//            return StudentAnswer;
//        }

//        static int CalculateScore(int[] studentScore)
//        {
//            int score = 0;
//            for(int i = 0; i< studentScore.Length; i++)
//            {
//                if(studentScore[i] == CorrectAnswers[i])
//                {
//                    score++;
//                }
//            }
//            return score;
//        }

//        static char FindGrade(int score)
//        {
//            switch (score)
//            {
//                case 10:
//                    {
//                        return 'A'; 
//                    }
//                case 9:
//                    {
//                        return 'B';
//                    }
//                case 8:
//                    {
//                        return 'C';
//                    }
//                case 7:
//                    {
//                        return 'D';
//                    }
//                case 6:
//                    {
//                        return 'E';
//                    }
//                default:
//                    {
//                        return 'F';
//                    }
//            }
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome To EduQuiz: ");
//            // Start Quiz
//            int[] studentAnswer = Quiz();
//            int score = CalculateScore(studentAnswer);
//            char grade = FindGrade(score);
//            Console.WriteLine($"Your Score is {score}, and obtain {grade} Grade");



//        }
//    }
//}
