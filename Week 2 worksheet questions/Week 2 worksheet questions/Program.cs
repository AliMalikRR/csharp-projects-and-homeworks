using System;
using System.Collections.Generic;
using System.Linq;

namespace Week_2_worksheet_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            //essential1();
            //essential2();
            //essential3();
        }
        public static void essential1()
        {
            List<string> names = new List<string>();

            names.Add("Ali");
            names.Add("John");
            names.Add("Dannish");
            names.Add("Zubair");
            names.Add("Zeshan");
            names.Add("Mojo");
            names.Add("Ehsoe");
            names.Add("Drew");
            names.Add("Chirs");
            names.Add("Josh");

            while (true)
            {
                Console.WriteLine("Enter (1) to display the guest list");
                Console.WriteLine("Enter (2) to add names to the list");
                Console.WriteLine("Enter (3) to remove names from the list");
                Console.WriteLine("Enter (4) to query how many people are on the list");

                int answer = int.Parse(Console.ReadLine());
                // display
                if(answer == 1)
                {
                    foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }
                }
                // add
                else if(answer == 2)
                {
                    Console.WriteLine("Please enter a name you would like to add");
                    string newName = Console.ReadLine();
                    if(names.Contains(newName) == false)
                    {
                        names.Add(newName);
                    }
                }
                // remove
                else if (answer == 3)
                {
                    Console.WriteLine("Please enter a name you would like to remove");
                    string name = Console.ReadLine();
                    names.Remove(name);
                }
                // count/query
                else if(answer == 4)
                {
                    Console.WriteLine("There are " + names.Count + " people on the list");
                }
            }
        }
        public static void essential2()
        {
            Dictionary<string, string> words = new Dictionary<string, string>();

            words.Add("yes", "si");
            words.Add("hello", "ciao");
            words.Add("cat", "gatta");
            words.Add("dog", "cagna");

            while (true)
            {
                Console.WriteLine("Please enter a English word");
                string engWord = Console.ReadLine().ToLower();
                if (words.ContainsKey(engWord))
                {
                    Console.WriteLine("In italia that " + words[engWord]);
                }
                else
                {
                    Console.WriteLine("Sorry i dont know that word in italian enter (y) for yes if you would like to add it and (n) for no if you would not");
                    string choice = Console.ReadLine().ToLower();
                    if(choice == "y")
                    {
                        Console.WriteLine("what is that word in italia??");
                        string italianWord = Console.ReadLine();
                        words.Add(engWord, italianWord);
                    }
                    else
                    {
                        Console.WriteLine("Thank you for using the program");
                    }
                }
            }

        }
        public static void essential3()
        {
            List<int> a = new List<int> { 1, 2, 3, 4, 5 };
            List<int> b = new List<int> { 1, 2, 3, 4, 5 };
            List<int> c = new List<int> { 2, 3, 4, 5, 6 };

            Console.WriteLine(a.SequenceEqual(b));
            Console.WriteLine(a.SequenceEqual(c));
            Console.WriteLine(b.SequenceEqual(c));

            bool AreTheSame(List<int> first, List<int> second)
            {
                if (first.Count != second.Count) return false;

                for (int i = 0; i < first.Count; i += 1)
                {
                    if (first[i] != second[i]) return false;
                }

                return true;
            }
        }
        public static void essential4()
        {

        }

    }
}
