using System;
using System.Collections.Generic;
using System.Linq;

namespace SP_week_3_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "W3 Homework";

            // The question is : given a list of usernames use the where functionto filter it to create a collection containing only usernames that contain_an_underscore.

            // Essential task 1

            List<string> userNames = new List<string>();

            userNames.Add("Ali_Malik");
            userNames.Add("BigMan");
            userNames.Add("fezpunch");
            userNames.Add("whackmuumuuwrretdg");
            userNames.Add("reevesalesm2323an");
            userNames.Add("lecturersnappy");
            userNames.Add("food_eat");
            userNames.Add("tractor_trac");
            userNames.Add("playerkikllal");
            userNames.Add("ManGracie");
            userNames.Add("shheh734231");
            userNames.Add("bldbj4");
            userNames.Add("wegureerth8");
            userNames.Add("afsgsgsgsgg");
            userNames.Add("hgjn");
            userNames.Add("fwtw4y");

            while (true)
            {
                Console.WriteLine("press (1) to display all the usernames");
                Console.WriteLine("press (2) to see which username is the longest");
                Console.WriteLine("press (3) to see which usernames have under_scores");
                Console.WriteLine("press (4) to see the first 3 usernames");
                Console.WriteLine("press (5) to see the last 3 usernames");
                Console.WriteLine("press (6) to reverse all the usernames");


                int answer = int.Parse(Console.ReadLine());

                // filter 1
                if (answer == 1)
                {
                    foreach (string usernm in userNames)
                    {
                        Console.WriteLine(usernm);
                    }
                }
                 // Filter 2 
                 if(answer == 2)
                {
                    string longest = userNames.OrderByDescending(l => l.Length).First();
                    Console.WriteLine("The longest username we could find was " + longest);
                }
                 // Filter 3
                 if(answer == 3)
                {
                    string subString = "_";
                    foreach (string u in userNames)
                    {
                        if (u.Contains(subString))
                        {
                            Console.WriteLine(u);
                        }
                    }
                }
                 if(answer == 4)
                {
                    IEnumerable<string> first3 = userNames.Take(3);
                    foreach (string s in first3)
                    {
                        Console.WriteLine(s);
                    }
                }
                 if(answer == 5)
                {
                    IEnumerable<string> last3 = userNames.TakeLast(3);
                    foreach (string s in last3)
                    {
                        Console.WriteLine(s);
                    }
                }
                 if(answer == 6)
                {
                    Console.WriteLine(reverse("Ali_Malik"));
                    Console.WriteLine(reverse("BigMan"));
                    Console.WriteLine(reverse("fezpunch"));
                    Console.WriteLine(reverse("whackmuumuuwrretdg"));
                    Console.WriteLine(reverse("reevesalesm2323an"));
                    Console.WriteLine(reverse("lecturersnappy"));
                    Console.WriteLine(reverse("food_eat"));
                    Console.WriteLine(reverse("tractor_trac"));
                    Console.WriteLine(reverse("playerkikllal"));
                    Console.WriteLine(reverse("ManGracie"));
                    Console.WriteLine(reverse("shheh734231"));
                    Console.WriteLine(reverse("bldbj4"));
                    Console.WriteLine(reverse("wegureerth8"));
                    Console.WriteLine(reverse("afsgsgsgsgg"));
                    Console.WriteLine(reverse("bldbj4"));
                    Console.WriteLine(reverse("hgjn"));
                    Console.WriteLine(reverse("fwtw4y"));
                }
            }
            static string reverse(string input)
            {
                if (string.IsNullOrEmpty(input))
                {
                    return input;
                }
                char[] arr = input.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }

        }   }

}