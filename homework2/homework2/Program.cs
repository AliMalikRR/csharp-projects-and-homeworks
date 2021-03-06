using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace homework2
{
    class Program
    {
        static void consoleColour(string message, ConsoleColor colour) // use for error messages only (Red)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            // Homework 2 
            // todo: do not allow users to enter decimal point numbers and then make a nice error message for that. Thats about it and just try make it more robust so i cant be crashed.

            if (args.Length == 0)
            {
                consoleColour("ERROR, you did not enter anything", ConsoleColor.Red);
            }
            else if (args.Length == 3)
            {
                float n1 = 0; // we set our numbers to 0 so theres a value for them even if our try catch block fails
                float n2 = 0;
                string op = args[1];
                try
                {
                    n1 = Convert.ToSingle(args[0]);
                    n2 = Convert.ToSingle(args[2]);
                }
                catch
                {
                    consoleColour("ERROR, you can only enter numbers", ConsoleColor.Red);
                    Environment.Exit(0); // close the program if we hit this catch cause there no point of carrying on at that point
                }
                if (args[1] == "+")
                {
                    Console.WriteLine(n1 + n2);
                }
                else if (args[1] == "-")
                {
                    Console.WriteLine(n1 - n2);
                }
                else if (args[1] == "x")
                {
                    Console.WriteLine(n1 * n2);
                }
                else if (args[1] == "/")
                {
                    Console.WriteLine(n1 / n2);
                }
                else if (args[1] != "+" || args[1] != "-" || args[1] != "x" || args[1] != "/" || args[1] == "")
                {
                    consoleColour("ERROR, unknow operator: ", ConsoleColor.Red);
                    consoleColour("try use: '+', '-', 'x', '/'", ConsoleColor.Green);
                }
            }
            else if(args.Length != 3)
            {
                consoleColour("oops, you did not format your question correctly", ConsoleColor.Red);
                consoleColour("try enter something like: 'x + x' or 'x / x' ", ConsoleColor.Green);
            }

        }

    }

 }
