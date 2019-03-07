using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace QuizGame
{
    public static class Question
    {

        private static int Index = 0;

        private static string Menu(List<string> options, string prompt)
        {
            Console.CursorVisible = false;

            var previousColor = Console.ForegroundColor;
            Console.Clear();

            Console.SetCursorPosition(0,20);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Navigate with the up and down arrow. Select answer with Enter");
            Console.ForegroundColor = previousColor;
            Console.SetCursorPosition(0,0);

            Console.WriteLine("<======================== The Yrgo C# Quiz 2019! ========================>");

            Console.Write($"{Name}\t\t      ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Correct answers: { CorrectAnswers}\t\t ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Wrong answers: { WrongAnswers}");
            Console.ForegroundColor = previousColor;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(prompt);
            for (int i = 0; i < options.Count; i++)
            {
                if (i == Index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(options[i]);
                }
                else
                {
                    Console.WriteLine(options[i]);
                }
                Console.ResetColor();
            }
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    if (Index <= 0)
                    {
                        Index = options.Count - 1;
                    }
                    else { Index--; }
                    break;
                case ConsoleKey.DownArrow:
                    if (Index == options.Count - 1)
                    {
                        Index = 0;
                    }
                    else { Index++; }
                    break;
                case ConsoleKey.Enter:
                    return options[Index];
                default:
                    break;
            }
            Console.Clear();
            return "";
        }

        public static int CorrectAnswers { get; set; }

        public static int WrongAnswers { get; set; }

        public static string Name;

        public static void AnswerPrint(string answer)
        {
            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(answer);
            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        public static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("<===================== Welcome to The Yrgo C# Quiz 2019! =====================>");

            Console.WriteLine();

            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();

            Console.WriteLine();

            var question = $"Welcome {Name} are you ready to start the quiz?";

            List<string> mainMenu = new List<string>()
            {
                "Yes",
                "No"
            };

            while (true)
            {
                string userSelection = Menu(mainMenu, question);
                switch (userSelection)
                {
                    case "Yes":
                        Console.Clear();
                        Index = 0;
                        Console.WriteLine("That is the Spirit!");
                        QuestionOne();
                        break;

                    case "No":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is not an option!");
                        Thread.Sleep(2000);
                        break;

                    default:
                        break;
                }
            }

        }

        public static void QuestionOne()
        {
            var question = "What is the symbol for less than?";

            List<string> options = new List<string>()
            {
                "<",
                ">",
                "=>"
            };

            Console.CursorVisible = false;

            while (true)
            {
                string userSelection = Menu(options, question);
                switch (userSelection)
                {
                    case "<":
                        Console.Clear();
                        CorrectAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the correct answer!");
                        QuestionOneAnswer();
                        break;

                    case ">":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionOneAnswer();
                        break;

                    case "=>":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionOneAnswer();
                        break;

                    default:
                        break;
                }

            }
        }

        public static void QuestionOneAnswer()
        {
            AnswerPrint("The correct answer was \"<\" ");
            QuestionTwo();
        }

        public static void QuestionTwo()
        {
            var question = "Does C# support multiple inheritances?";

            List<string> options = new List<string>()
            {
                "No",
                "Yes"
            };

            Console.CursorVisible = false;

            while (true)
            {
                string userSelection = Menu(options, question);
                switch (userSelection)
                {
                    case "No":
                        Console.Clear();
                        CorrectAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the correct answer!");
                        QuestionTwoAnswer();
                        break;

                    case "Yes":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionTwoAnswer();
                        break;

                    default:
                        break;
                }

            }
        }

        public static void QuestionTwoAnswer()
        {
            AnswerPrint("The correct answer was \"No\" ");
            QuestionThree();
        }

        public static void QuestionThree()
        {
            var question = "The C# keyword \"int\" maps to which .Net type?";

            List<string> options = new List<string>()
            {
                "System.int16",
                "System.int32",
                "System.int64",
                "System.int128"
            };

            Console.CursorVisible = false;

            while (true)
            {
                string userSelection = Menu(options, question);
                switch (userSelection)
                {
                    case "System.int16":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionThreeAnswer();
                        break;

                    case "System.int32":
                        Console.Clear();
                        CorrectAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the correct answer!");
                        QuestionThreeAnswer();
                        break;

                    case "System.int64":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionThreeAnswer();
                        break;

                    case "System.int128":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionThreeAnswer();
                        break;

                    default:
                        break;
                }

            }
        }

        public static void QuestionThreeAnswer()
        {
            AnswerPrint("The correct answer was \"System.int32\" ");
            QuestionFour();
        }

        public static void QuestionFour()
        {
            var question = "Which of these statements correctly declares a two-dimensional integer array in C#?";

            List<string> options = new List<string>()
            {
                "int[,] myArray;",
                "int[][] myArray;",
                "int[2] myArray;",
                "System.Array[2] myArray;",
                "System.Array[,] myArray;"
            };

            Console.CursorVisible = false;

            while (true)
            {
                string userSelection = Menu(options, question);
                switch (userSelection)
                {
                    case "int[,] myArray;":
                        Console.Clear();
                        CorrectAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the correct answer!");
                        QuestionFourAnswer();
                        break;

                    case "int[][] myArray;":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionFourAnswer();
                        break;

                    case "int[2] myArray;":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionFourAnswer();
                        break;

                    case "System.Array[2] myArray;":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionFourAnswer();
                        break;

                    case "System.Array[,] myArray;":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionFourAnswer();
                        break;

                    default:
                        break;
                }

            }
        }

        public static void QuestionFourAnswer()
        {
            AnswerPrint("The correct answer was \"int[,] myArray;\" ");
            QuestionFive();
        }

        public static void QuestionFive()
        {
            var question = "Which foreach is correct?";

            List<string> options = new List<string>()
            {
                "Foreach(var items as item) " +
                "{ \n" +
                "  Console.WriteLine(item); \n" +
                "}",

                "foreach(var item in items) \n" +
                "{ \n" +
                "  Console.WriteLine(item); \n" +
                "}",

                "Foreach(var item in items) \n" +
                "{ \n" +
                "  Console.WriteLine(item); \n" +
                "}"
            };

            Console.CursorVisible = false;

            while (true)
            {
                string userSelection = Menu(options, question);
                switch (userSelection)
                {
                    case "Foreach(var items as item) " +
                         "{ \n" +
                         "  Console.WriteLine(item); \n" +
                         "}":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionFiveAnswer();
                        break;

                    case "foreach(var item in items) \n" +
                         "{ \n" +
                         "  Console.WriteLine(item); \n" +
                         "}":
                        Console.Clear();
                        CorrectAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the correct answer!");
                        QuestionFiveAnswer();
                        break;

                    case "Foreach(var item in items) \n" +
                         "{ \n" +
                         "  Console.WriteLine(item); \n" +
                         "}":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionFiveAnswer();
                        break;

                    default:
                        break;
                }

            }
        }

        public static void QuestionFiveAnswer()
        {
            AnswerPrint("The correct answer was \n\nforeach(var item in items) \n{  \n  Console.WriteLine(item); \n}");
            QuestionSix();
        }

        public static void QuestionSix()
        {
            var question = "Can you change the value of a variable while debuggin a C# application?";

            List<string> options = new List<string>()
            {
                "No",
                "Yes"
            };

            Console.CursorVisible = false;

            while (true)
            {
                string userSelection = Menu(options, question);
                switch (userSelection)
                {
                    case "No":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionSixAnswer();
                        break;

                    case "Yes":
                        Console.Clear();
                        CorrectAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the correct answer!");
                        QuestionSixAnswer();
                        break;

                    default:
                        break;
                }

            }
        }

        public static void QuestionSixAnswer()
        {
            AnswerPrint("The correct answer was \"Yes\" ");
            QuestionSeven();
        }

        public static void QuestionSeven()
        {
            var question = "Which Of The Following Operator Can Be Used To Access The Member Function Of A Class?";

            List<string> options = new List<string>()
            {
                ":",
                "::",
                ".",
                "#"
            };

            Console.CursorVisible = false;

            while (true)
            {
                string userSelection = Menu(options, question);
                switch (userSelection)
                {
                    case ":":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionSevenAnswer();
                        break;

                    case "::":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionSevenAnswer();
                        break;

                    case ".":
                        Console.Clear();
                        CorrectAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the correct answer!");
                        QuestionSevenAnswer();
                        break;

                    case "#":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionSevenAnswer();
                        break;

                    default:
                        break;
                }

            }
        }

        public static void QuestionSevenAnswer()
        {
            AnswerPrint("The correct answer was \".\" ");
            QuestionEight();
        }

        public static void QuestionEight()
        {
            var question = "Which Of The Following Gives The Correct Count Of The Constructors That A Class Can Define?";

            List<string> options = new List<string>()
            {
                "1",
                "2",
                "Any Number",
                "None of the above"
            };

            Console.CursorVisible = false;

            while (true)
            {
                string userSelection = Menu(options, question);
                switch (userSelection)
                {
                    case "1":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionEightAnswer();
                        break;

                    case "2":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionEightAnswer();
                        break;

                    case "Any Number":
                        Console.Clear();
                        CorrectAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the correct answer!");
                        QuestionEightAnswer();
                        break;

                    case "None of the above":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionEightAnswer();
                        break;

                    default:
                        break;
                }

            }
        }

        public static void QuestionEightAnswer()
        {
            AnswerPrint("The correct answer was \"Any Number\" ");
            QuestionNine();
        }

        public static void QuestionNine()
        {
            var question = "Which of the following is NOT an Arithmetic operator in C#.NET?";

            List<string> options = new List<string>()
            {
                "**",
                "+",
                "/",
                "%",
                "*"
            };

            Console.CursorVisible = false;

            while (true)
            {
                string userSelection = Menu(options, question);
                switch (userSelection)
                {
                    case "**":
                        Console.Clear();
                        CorrectAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the correct answer!");
                        QuestionNineAnswer();
                        break;

                    case "+":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionNineAnswer();
                        break;

                    case "/":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionNineAnswer();
                        break;

                    case "%":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionNineAnswer();
                        break;

                    case "*":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionNineAnswer();
                        break;

                    default:
                        break;
                }

            }
        }

        public static void QuestionNineAnswer()
        {
            AnswerPrint("The correct answer was \"**\" ");
            QuestionTen();
        }

        public static void QuestionTen()
        {
            var question = "What is the output of this C# code? \n\n" +
            	"int? i = 8 >> 5; \n" +
            	"int? j = i > 0 ? i: null; \n" +
            	"var a = j == int.MinValue; \n" +
            	"Console.WriteLine(a); \n";

            List<string> options = new List<string>()
            {
                "1",
                "null",
                "0",
                "-2147483648"
            };

            Console.CursorVisible = false;

            while (true)
            {
                string userSelection = Menu(options, question);
                switch (userSelection)
                {
                    case "1":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionTenAnswer();
                        break;

                    case "null":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionTenAnswer();
                        break;

                    case "0":
                        Console.Clear();
                        WrongAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the wrong answer!");
                        QuestionTenAnswer();
                        break;

                    case "-2147483648":
                        Console.Clear();
                        CorrectAnswers += 1;
                        Index = 0;
                        Console.WriteLine("That is the correct answer!");
                        QuestionTenAnswer();
                        break;

                    default:
                        break;
                }

            }
        }

        public static void QuestionTenAnswer()
        {
            AnswerPrint("The correct answer was \"-2147483648\" ");
            EndGame();
        }

        public static void EndGame()
        {
            var previousColor = Console.ForegroundColor;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct answers: {CorrectAnswers}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong answers: {WrongAnswers}");
            Console.ForegroundColor = previousColor;
            Console.WriteLine();
            Console.WriteLine("To play again press any key...");
            Console.ReadKey();
            MainMenu();
        }
    }
}
