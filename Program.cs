using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuggets.Demos._98_361._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name below:");
            string yourName = Console.ReadLine();

            Console.WriteLine("{1}Hello {0}. Welcome to 98-361 Software Fundamentals{1}", yourName, Environment.NewLine);

            Console.WriteLine("Enter your age below:");
            int yourAge = Convert.ToInt16(Console.ReadLine());

            TimeSpan ageData = new TimeSpan(yourAge * 365, 0, 0, 0);

            Console.WriteLine();
            Console.WriteLine("You have been alive for:");
            Console.WriteLine(" {0} seconds", ageData.TotalSeconds);
            Console.WriteLine(" {0} minutes", ageData.TotalMinutes);
            Console.WriteLine(" {0} hours", ageData.TotalHours);
            Console.WriteLine(" {0} days", ageData.TotalDays);
            Console.WriteLine();

            Console.WriteLine("Enter your favourite colours below");
            char[] delimeters = { ',', ':', ';', ' ' };
            string[] colours = Console.ReadLine().Split(delimeters);

            Console.WriteLine();
            Console.WriteLine("You have {0} favourite colours.", colours.Length);
            Console.WriteLine();
        }
    }
}
