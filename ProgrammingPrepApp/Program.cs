using System;

namespace ProgrammingPrepApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print the Menu:
            PrintMenu();

            // Read and execute selection option:
            int selectedMenuOption = 1;
            while (selectedMenuOption != 0)
            { 
                Console.Write("\n>>> ");

                selectedMenuOption = ReadSelectedMenuOption();
                switch (selectedMenuOption)
                {
                    case 0:
                        break;
                    case 1:
                        PrintHelloWorld();
                        break;
                    case 2:
                        PrintUserInPut();
                        break;
                    case 3:
                        ToggleTextColorInConsole();
                        break;
                    case 4:
                        PrintCurrentDate();
                        break;
                    case 5:
                        PrintLargest();
                        break;
                    case 6:
                        GuessRandomNumber();
                        break;
                    case 7:
                        SaveTextToFileFromConsole();
                        break;
                    case 8:
                        ReadFileAndPrintContentToConsole();
                        break;
                    case 9:
                        GetDecimalcalculations();
                        break;
                    case 10:
                        PrintMultiplicationTable();
                        break;
                    case 11:
                        PrintArrays();
                        break;
                    case 12:
                        CheckIfPalindrome();
                        break;
                    case 13:
                        PrintNumberSeries();
                        break;
                    case 14:
                        PrintEvenAndOddNumbers();
                        break;
                    case 15:
                        PrintSum();
                        break;
                    case 16:
                        PrintCharacters();
                        break;
                    default:
                        Console.WriteLine(">>> Invalid Option Selected, TRY AGAIN.....");
                        continue;
                }
            }
        }

        private static void PrintCharacters()
        {
            Console.Write("> Submit the name of your character: ");
            string character1 = Console.ReadLine();
            
            Console.Write("> Submit the name of your opponents character: ");
            string character2 = Console.ReadLine();

            // Generate characters:

            Random random = new Random();

            Player player1 = new Player(character1);
            player1.Health = random.Next(101);
            player1.Luck = random.Next(101);
            player1.Strength = random.Next(101);
            //player1.IncreaseHealth(20);
            
            Player player2 = new Player(character2);
            player2.Health = random.Next(101);
            player2.Luck = random.Next(101);
            player2.Strength = random.Next(101);


            // Print Players:

            string player1AsString = string.Format
                ("> Player 1: You\n" +
                "Name: {0}" + "\n" +
                "Health: {1}" + "\n" +
                "Strength: {2}" + "\n" +
                "Luck: {3}" + "\n",
                player1.Name,
                player1.Health,
                player1.Strength,
                player1.Luck);

            string player2AsString = string.Format
                ("> Player 2: Opponent\n" +
                "Name: {0}" + "\n" +
                "Health: {1}" + "\n" +
                "Strength: {2}" + "\n" +
                "Luck: {3}" + "\n",
                player2.Name,
                player2.Health,
                player2.Strength,
                player2.Luck);

            Console.WriteLine(player1AsString);
            Console.WriteLine(player2AsString);
        }

        private static void PrintSum()
        {
            Console.WriteLine("> Type a series of numbers, press enter to submit.....");

            int sum = 0;
            List<string> numbersList = Console.ReadLine().Split(',').ToList();
            foreach (string number in numbersList)
            {
                int n;
                int.TryParse(number.Trim(), out n);
                sum += n;
            }

            Console.WriteLine("> Sum of submitted numbers: " + sum);
        }

        private static void PrintNumberSeries()
        {
            Console.WriteLine("> Submit first number and press ENTER.....");
            string firstNumber = Console.ReadLine();
            int x = 0;
            int.TryParse(firstNumber, out x);

            Console.WriteLine("> Submit second number and press ENTER.....");
            string secondNumber = Console.ReadLine();
            int y = 0;
            int.TryParse(secondNumber, out y);

            int min = x >= y ? y : x;
            int max = x <= y ? y : x;

            string result = "";
            for (int i = min + 1; i < max; i++)
            {
                result += i + " ";
            }

            Console.WriteLine("Series: " + result);
        }

        private static void CheckIfPalindrome()
        {
            Console.WriteLine("> Submit a word and press ENTER to check if it is a palindrome.....");

            string input = Console.ReadLine();
            List<char> leftList = input.ToList();
            List<char> rightList = new List<char>();

            for (int i = leftList.Count() - 1 ; i >= 0; i--)
            {
                rightList.Add(leftList[i]);
            }

            string right = "";
            foreach (char item in rightList)
            {
                right += item;
            }

            bool isPalindrome = input.Equals(right);
            Console.WriteLine(string.Format("Answer: {0}", isPalindrome));
        }

        public static void PrintArrays()
        {
            Random rand = new Random();

            int[] randArray = new int[10];
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = rand.Next(101);
            }
            
            int tmp;
            int[] sortedArray = new int[randArray.Length];
            for (int i = 0; i < randArray.Length; i++)
            {
                sortedArray[i] = randArray[i];
            }
            
            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                for (int j = i + 1; j < sortedArray.Length; j++)
                {
                    if (sortedArray[i] > sortedArray[j])
                    {
                        tmp = sortedArray[i];
                        sortedArray[i] = sortedArray[j];
                        sortedArray[j] = tmp;
                    }
                }
            }

            Console.WriteLine("[First Array: Random Numbers]");
            Console.WriteLine(string.Join(" ", randArray));
            Console.WriteLine("");
            Console.WriteLine("[Second Array: First Array Sorted from smallest to largest number]");
            Console.WriteLine(string.Join(" ", sortedArray));
        }

        private static void PrintMultiplicationTable()
        {
            string res = "";
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    res += (i * j) + "\t";
                }
                res += "\n";
            }

            string ret = string.Format(
                "--------------------------------------------------------------------------------" + "\n" +
                "{0}" +
                "--------------------------------------------------------------------------------"
                , res);

            Console.WriteLine(ret);
        }

        private static void GetDecimalcalculations()
        {
            Console.WriteLine("> Write a decimal number, press ENTER to submit.....");

            double submittedDecimal = 0.0;
            bool isParsable = Double.TryParse(Console.ReadLine(), out submittedDecimal);

            double sqr = Math.Sqrt(submittedDecimal);
            double powerTwo = Math.Pow(submittedDecimal, 2);
            double powerTen = Math.Pow(submittedDecimal, 10);

            Console.WriteLine("Square root of {0}: {1}", submittedDecimal, sqr);
            Console.WriteLine("{0} raised to the power of 2: {1}", submittedDecimal, powerTwo);
            Console.WriteLine("{0} raised to the power of 10: {1}", submittedDecimal, powerTen);

        }

        private static void ReadFileAndPrintContentToConsole()
        {
            string fileName = "input_from_console.txt";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullFilePath = string.Format("{0}{1}{2}", desktopPath, "\\", fileName);

            string content = "";
            if (File.Exists(fullFilePath))
            {
                content = File.ReadAllText(fullFilePath);
                Console.WriteLine("> Content of file: " + fullFilePath);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File not found: " + fullFilePath);
            }
        }

        private static void SaveTextToFileFromConsole()
        {
            Console.WriteLine("> Write text and press ENTER to write it to file.....\n");
            Console.Write("> ");

            string input = Console.ReadLine();

            string fileName = "input_from_console.txt";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullFilePath = string.Format("{0}{1}{2}", desktopPath, "\\", fileName);
            
            File.AppendAllText(fullFilePath, input + "\n");

            Console.WriteLine("Text was written to file: " + fullFilePath);
        }

        private static void GuessRandomNumber()
        {
            Random rand = new Random();
            int randInt = rand.Next(1, 101);

            bool randIntFound = false;
            int numberOfGuesses = 0;

            while (!randIntFound)
            {
                Console.Write("Guess the random number, 1-100: ");

                string guess = Console.ReadLine();
                numberOfGuesses++;

                int guessAsInt = 0;
                bool isIntGuess = int.TryParse(guess, out guessAsInt);

                if (isIntGuess)
                {
                    if (guessAsInt == randInt)
                    {
                        randIntFound = true;
                        Console.WriteLine(String.Format("Your Guess Was Correct! It took {0} tries", numberOfGuesses));
                    }
                    else
                    {
                        string lowerOrHigher = "";
                        if (guessAsInt < randInt)
                        {
                            lowerOrHigher= "low";
                        }
                        else
                        {
                            lowerOrHigher = "high";
                        }
                        Console.WriteLine(String.Format("Your Guess Was NOT Correct! The guessed value was to {0}.", lowerOrHigher));
                    }
                }
                else
                {
                    Console.WriteLine(String.Format("Invalid guess input. Input must be a positive Integer."));
                }
            }
        }

        private static void PrintLargest()
        {
            
            Console.Write("First Number: ");
            string firstNumber = Console.ReadLine();

            Console.Write("Second Number: ");
            string secondNumber = Console.ReadLine();

            int intValueFirst = 0;
            bool isIntFirst = int.TryParse(firstNumber, out intValueFirst);

            int intValueSecond = 0;
            bool isIntSecond = int.TryParse(secondNumber, out intValueSecond);

            if (isIntFirst && isIntSecond)
            {
                int result = GetLargestInt(intValueFirst, intValueSecond);
                Console.WriteLine(String.Format("Largest Number: {0}", result));
            }
            else
            {
                Console.WriteLine("Invalid Input Provided, Function terminated.");
            }
        }

        private static int GetLargestInt(int first, int second)
        {
            if (first == second)
            {
                return first;
            }
            else
            {
                if (first > second)
                {
                    return first;
                }
                else
                {
                    return second;
                }
            }
        }

        private static void PrintCurrentDate()
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = string.Format(
                "Current Date: {0}-{1}-{2}", 
                currentDate.Year, currentDate.Month, currentDate.Day);
            Console.WriteLine(formattedDate);
        }

        private static void ToggleTextColorInConsole()
        {
            if (Console.ForegroundColor == ConsoleColor.Gray)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else
            {
                Console.ResetColor();
            }
        }

        private static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        private static void PrintUserInPut()
        {
            Console.WriteLine("> Enter Requested Information And Press Enter to submit:" + System.Environment.NewLine);
            
            Console.Write("> First Name: ");
            string firstName = Console.ReadLine().Trim();
            
            Console.Write("> Last Name: ");
            string lastName = Console.ReadLine().Trim();

            Console.Write("> Age: ");
            string age = Console.ReadLine().Trim();
            
            Console.WriteLine(string.Format("{0}{1}{2}{3}",
                System.Environment.NewLine + "Submitted User Data:" + System.Environment.NewLine,
                "First Name: " + firstName + System.Environment.NewLine,
                "Last Name: " + lastName + System.Environment.NewLine,
                "Age: " + age + System.Environment.NewLine));
        }

        private static void PrintEvenAndOddNumbers()
        {
            Console.WriteLine("> Type a list of numbers, separated by comma, press ENTER to submit.....");
            
            string input = Console.ReadLine();
            List<string> splitList = input.Split(',').ToList();

            string evenNumbers = "";
            string oddNumbers = "";
            foreach (string item in splitList)
            {
                item.Trim();
                int itemAsInt = 0; 
                int.TryParse(item, out itemAsInt);
                if ((itemAsInt % 2) == 0)
                {
                    evenNumbers += itemAsInt + " ";
                }
                else
                {
                    oddNumbers += itemAsInt + " ";
                }
            }

            Console.WriteLine("Even Numbers: " + evenNumbers);
            Console.WriteLine("Odd Numbers: " + oddNumbers);
        }
       
        private static int ReadSelectedMenuOption()
        {
            string selectedOption = Console.ReadLine();
            int intValue = 0;
            bool isInt = int.TryParse(selectedOption, out intValue);

            if (isInt && (intValue >= 0 && intValue <= 16))
            {
                return intValue;
            }
            else
            {
                return -1;
            }
        }

        private static void PrintMenu()
        {
            string menu = string.Format(
                "Menu:{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}",

                System.Environment.NewLine + "[0] Close Program" + System.Environment.NewLine,
                "[1] Print Hello Word!" + System.Environment.NewLine,
                "[2] Print User Input" + System.Environment.NewLine,
                "[3] Toggle Text Color In Console" + System.Environment.NewLine,
                "[4] Print Current Date" + System.Environment.NewLine,
                "[5] Print the largest of two numbers given by user" + System.Environment.NewLine,
                "[6] Guess the Random Number" + System.Environment.NewLine,
                "[7] Write text to file on harddrive" + System.Environment.NewLine,
                "[8] Read and print content from file to console" + System.Environment.NewLine,
                "[9] Decimal calculations" + System.Environment.NewLine,
                "[10] Print multiplication tables, 1-10" + System.Environment.NewLine,
                "[11] Print arrays" + System.Environment.NewLine,
                "[12] Check if user input is a palindrome" + System.Environment.NewLine,
                "[13] Print all numbers between x and y" + System.Environment.NewLine,
                "[14] Sorting and listing of even numbers and odd numbers" + System.Environment.NewLine,
                "[15] Print sum of submitted numbers" + System.Environment.NewLine,
                "[16] Print Characters" + System.Environment.NewLine,
                System.Environment.NewLine + "> ENTER option from Menu (0-16) and PRESS ENTER to EXECUTE....." + System.Environment.NewLine

                );
            
            Console.WriteLine(menu);
        }



        
    }
}