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
            //essential2();
            //essential3();
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

            foreach (car cr in cars.OrderBy(element => element.yearofman)) // order by sorts in asscending order
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
            public car(string make, string model, string reg, int yearofman)
            {
                this.make = make;
                this.model = model;
                this.reg = reg;
                this.yearofman = yearofman;
            }
        }
        public static void essential4()
        {

        }
    }
}
