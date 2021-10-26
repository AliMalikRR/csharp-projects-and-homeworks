using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weel_3_worksheet_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            // essential2();
            // essential3();
            essential4();
        }
        public static void essential2()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 345, 24, 757, 424, 134, -10, -45 };

            if(nums.All(element => element >= 0 && element < 256))
            {
                Console.WriteLine("All the numbers in this list are less than 256 and positive");
            }
            else
            {
                Console.WriteLine("Some of these numbers are negative and greater than 256");
                foreach (int number in nums)
                {
                    Console.WriteLine(number);
                }
            }
        }
        public static void essential3()
        {
            List<car> cars = new List<car>();

            cars.Add(new car("ford", "focus", "abc123", 2010));
            cars.Add(new car("bmw", "m3", "abc1234", 2017));
            cars.Add(new car("audi", "r8", "abc1235", 2002));
            cars.Add(new car("range rover", "evoke", "abc123456", 2006));
            cars.Add(new car("merc", "g wagon", "abc1234567", 1994));
            cars.Add(new car("toyota", "yaris", "abc12345678", 1957));

            foreach (car cr in cars.OrderBy(element => element.yearofman)) // OrderBy sorts in asscending order
            {
                Console.WriteLine(cr.yearofman);
            }
        }
        public class car
        {
            public string make;
            public string model;
            public string reg;
            public int yearofman;
            public car(string make, string model, string reg, int yearofman) // constructior 
            {
                this.make = make;
                this.model = model;
                this.reg = reg;
                this.yearofman = yearofman;
            }
        }
        public static void essential4()
        {
            List<react> reacts = new List<react>();
            // use the max function to find out the max width, then use the max function to find the max height then use a variant of the sum function to find the area.
            reacts.Add(new react(5, 10));
            reacts.Add(new react(6, 11));
            reacts.Add(new react(5.8, 15.6));
            reacts.Add(new react(6.7, 18.5));
            reacts.Add(new react(124.5, 12.4));
            reacts.Add(new react(325.3, 33));
            reacts.Add(new react(95, 45.2));
            reacts.Add(new react(23.6, 1224.66));
            reacts.Add(new react(4633.3, 12.4));

            double biggestheight = reacts.Max(element => element.height);
            Console.WriteLine("The biggest height is " + biggestheight);

            double biggestwidth = reacts.Max(element => element.width);
            Console.WriteLine("The biggest width is " + biggestwidth);
        }
        public class react
        {
            public double width;
            public double height;

            public react(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
        }
    }
}
