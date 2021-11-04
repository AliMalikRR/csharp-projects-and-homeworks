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
            if (args.Length == 0)
            {
                consoleColour("You did not enter anything", ConsoleColor.Cyan);
            }
            else if (args.Length == 3)
            {
                float n1 = 0; // we set our numbers to 0 so there a value for them even if our try block fails
                float n2 = 0;
                string op = args[1];
                try
                {
                    // if they enter a string in postiion 0 or 2 there will be an error as you cant convert a string to a float so we move into the catch block.
                    n1 = Convert.ToSingle(args[0]);
                    n2 = Convert.ToSingle(args[2]);
                }
                catch
                {
                    consoleColour("Error you can only enter numbers", ConsoleColor.Cyan);
                    Environment.Exit(0); // close the program if we hit this catch cause there no point of carrying on
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
                    consoleColour("Unknow operator try use '+', '-', 'x' or '/'", ConsoleColor.Cyan);
                }
            }
            else if(args.Length != 3)
            {
                consoleColour("oops, you did not format your question correctly", ConsoleColor.Cyan);
            }

        }

    }

 }
