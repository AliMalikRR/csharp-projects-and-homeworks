﻿using System;
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
            userNames.Add("reevesalesman");
            userNames.Add("lecturersnappy");
            userNames.Add("food_eat");
            userNames.Add("tractor_trac");
            userNames.Add("playerkikllal");
            userNames.Add("ManGracie");

            while (true)
            {
                Console.WriteLine("press (1) to display all the usernames");
                Console.WriteLine("press (2) to see which username is the longest");
                Console.WriteLine("press (3) to see which usernames have under_scores");
                Console.WriteLine("press (4) to see the first 3 usernames we have stored");
                Console.WriteLine("press (5) to ");

                int answer = int.Parse(Console.ReadLine());

                // filter 1
                if (answer == 1)
                {
                    foreach (string usernm in userNames)
                    {
                        Console.WriteLine("These are all the usernames we currently have stored " + usernm);
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
                    Console.WriteLine(first3);
                }

            }


    
    }   }

}