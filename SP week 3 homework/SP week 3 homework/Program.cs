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

            // now we need to filter these usernames using the where function 
        }
    }
}
