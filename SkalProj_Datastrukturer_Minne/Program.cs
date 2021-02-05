using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }


       

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            do
            {
                Console.WriteLine("Please enter input string like +Adam or -Adam or press \"Q\" to exit to the main menue: ");
                List<string> theList = new List<string>();
                string input = Console.ReadLine();
                if (input.Equals("Q")) break;
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine();
                        foreach (string list in theList)
                        {
                            Console.WriteLine($"Elements in this list after (+) operation: {list}");
                        }
                        Console.WriteLine($"\nCount of this list after (+) operation: {theList.Count}");
                        Console.WriteLine($"Capacity of this list after (+) operation: {theList.Capacity}");
                        Console.WriteLine();

                        break;
                    case '-':
                        theList.Remove(value);
                        foreach (string list in theList)
                        {
                            Console.WriteLine($"Elements in this list after (-) operation: {list}");
                        }
                        Console.WriteLine($"\nCount of this list after (-) operation: {theList.Count}");
                        Console.WriteLine($"Capacity of this list after (-) operation: {theList.Capacity}");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please use only + or - before string");
                        Console.WriteLine();
                        break;
                }

            } while (true);
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            do
            {
                Queue<int> theQueue = new Queue<int>();
                int[] values = new int[5];
                Console.WriteLine("Please enter 5 input integer seperated by space or press \"Q\" to exit to the main menue: \n");
                string enqueueInput = Console.ReadLine();
                if (enqueueInput.Equals("Q")) break;
                if (enqueueInput.Length > 5)
                {
                    string trimInput = Regex.Replace(enqueueInput, @"\s+", " ");
                    string[] subs = trimInput.Split(' ', '\t');
                    values = Array.ConvertAll(subs, int.Parse);
                }
                else
                {
                    Console.WriteLine("Invalid input!");

                }
                Console.WriteLine();

                Console.WriteLine("Please choose from the following option!");
                Console.WriteLine("\n1) Enqueue items");
                Console.WriteLine("2) Dequeue items");
                Console.WriteLine();

                string option = Console.ReadLine();

                //Console.WriteLine(values[1]);

                switch (option)
                {
                    case "1":
                        for (int i = 0; i < values.Length; i++)
                        {
                            theQueue.Enqueue(values[i]);
                        }
                        foreach (int number in theQueue)
                        {
                            Console.WriteLine($"Enqueue item: {number}");
                        }

                        Console.WriteLine();

                        break;

                    case "2":
                        for (int i = 0; i < values.Length; i++)
                        {
                            theQueue.Enqueue(values[i]);
                        }

                        Console.WriteLine($"Dequeue item: {theQueue.Dequeue()}");
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Input!");
                        Console.WriteLine();
                        break;
                }

            } while (true);

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */


            do
            {
                Stack<int> theStack = new Stack<int>();
                int[] values = new int[5];
                Console.WriteLine("Please enter 5 input integer seperated by space or press \"Q\" to exit to the main menue: \n");
                string pushInput = Console.ReadLine();
                if (pushInput.Equals("Q")) break;
                if (pushInput.Length > 5)
                {
                    string trimInput = Regex.Replace(pushInput, @"\s+", " ");
                    string[] subs = trimInput.Split(' ', '\t');
                    values = Array.ConvertAll(subs, int.Parse);
                }
                else
                {
                    Console.WriteLine("Invalid input!");

                }
                Console.WriteLine();

                Console.WriteLine("Please choose from the following option!");
                Console.WriteLine("\n1) Push items");
                Console.WriteLine("2) Pop items");
                Console.WriteLine();

                string option = Console.ReadLine();

                //Console.WriteLine(values[1]);

                switch (option)
                {
                    case "1":
                        for (int i = 0; i < values.Length; i++)
                        {
                            theStack.Push(values[i]);
                        }
                        foreach (int number in theStack)
                        {
                            Console.WriteLine($"Push item: {number}");
                        }

                        Console.WriteLine();

                        break;

                    case "2":
                        for (int i = 0; i < values.Length; i++)
                        {
                            theStack.Push(values[i]);
                        }

                        Console.WriteLine($"Pop item: {theStack.Pop()}");
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Input!");
                        Console.WriteLine();
                        break;
                }



            } while (true);
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            do
            {
                Stack<char> theStack = new Stack<char>();
                bool isValid = true;

                Console.WriteLine("Please enter parenthesis or press \"Q\" to the main menu: \n");
                string userInput = Console.ReadLine();
                if (userInput.Equals("Q")) break;
                string top = Regex.Replace(userInput, @"\s+", " ");

                for (int i = 0; i < top.Length; i++)
                {
                    switch (top[i])
                    {
                        case '(':
                            theStack.Push(top[i]);
                            break;
                        case ')':
                            isValid = (theStack.Count > 0 && theStack.Pop() == '(');
                            break;
                        case '{':
                            theStack.Push(top[i]);
                            break;
                        case '}':
                            isValid = (theStack.Count > 0 && theStack.Pop() == '{');
                            break;
                        case '[':
                            theStack.Push(top[i]);
                            break;
                        case ']':
                            isValid = (theStack.Count > 0 && theStack.Pop() == '[');
                            break;

                        default:
                            break;
                    }

                }

                if (isValid && theStack.Count == 0)
                {
                    Console.WriteLine("\nAll the paranthesis are perfectly matched in the stack.");
                }
                else
                {
                    Console.WriteLine("\nThere are still pending paranthesis in the stack.");
                }
                Console.WriteLine();


            } while (true);

        }

    }
}

