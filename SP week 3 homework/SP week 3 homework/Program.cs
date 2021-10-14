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

            // let user chose what they want to sort by maybe lenght aswell as underscores 

            // The question is : given a list of usernames use the where functionto filter it gto create a collection containing only usernames that contain_an_underscore.

            List<string> userNames = new List<string>(); // create a list to store the usernames 

            // hardcode some random usernames into the list some of which have under_scores -  this can be improved later on 

            userNames.Add("Ali_Malik");
            userNames.Add("BigMan");
            userNames.Add("fezpunch");
            userNames.Add("whackmuumuu");
            userNames.Add("reevesalesman");
            userNames.Add("lecturersnappy");
            userNames.Add("food_eat");
            userNames.Add("tractor_trac");
            userNames.Add("playerkikllal");
            userNames.Add("ManGracie");

            // now we are going to ask the user what they want to do this can be an extra feature

            List<string> guests = new List<string>();



            guests.Add("Jackie");
            guests.Add("Chris");
            guests.Add("Jet");
            guests.Add("Steve");

            while (true)
            {
                Console.WriteLine("press (1) to display all the usernames");
                Console.WriteLine("2) Add to guest list");
                Console.WriteLine("3) Remove from guest list");
                Console.WriteLine("4) Display number of guests");
                Console.WriteLine("Q) Quit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "q") break;

                if (choice == "1") Display();
                else if (choice == "2") Add();
                else if (choice == "3") Remove();
                else if (choice == "4") Count();
                else Console.WriteLine("Unknown option.");

            }

        }
}
