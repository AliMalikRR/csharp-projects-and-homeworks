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
            //essential4();
            essential5();
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
            List<int> numbers = new List<int> { 1, 324, 546, 345, 34, 5, 36, 35, 363 };

            // removes the lowest 3 values
            numbers.Remove(numbers.Min());
            numbers.Remove(numbers.Min());
            numbers.Remove(numbers.Min());

            // removes the highest 3 values
            numbers.Remove(numbers.Max());
            numbers.Remove(numbers.Max());
            numbers.Remove(numbers.Max());

            foreach (int number in numbers)
            {
                Console.WriteLine(number + " ");
            }
        }

        public static void essential5()
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            {
                Car c = new Car();
                c.reg = "AB01 QWE";
                c.make = "Ford";
                c.model = "Fiesta";
                cars.Add(c.reg, c);
            }
            {
                Car c = new Car();
                c.reg = "BC02 WER";
                c.make = "Nissan";
                c.model = "Leaf";
                cars.Add(c.reg, c);
            }

            Console.WriteLine("Enter registration");
            string reg = Console.ReadLine();

            if (cars.ContainsKey(reg))
            {
                Car c = cars[reg];
                Console.WriteLine("Details for " + reg);
                Console.WriteLine("Make:  " + c.make);
                Console.WriteLine("Model: " + c.model);
            }
            else
            {
                Console.WriteLine("Car not on record :( ");
            }
        }
        public class Car
        {
            public string reg;
            public string make;
            public string model;
        }
        public static void essential6()
        {
            Dictionary<string, int> votes = new Dictionary<string, int>();

            while (true)
            {
                Console.Clear();
                foreach (var pair in votes)
                {
                    Console.WriteLine(pair.Key + " has " + pair.Value + " votes");
                }

                Console.Write("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                if (votes.ContainsKey(choice))
                {
                    votes[choice] += 1;
                }
                else
                {
                    votes.Add(choice, 1);
                }
            }
        }
    }
}
