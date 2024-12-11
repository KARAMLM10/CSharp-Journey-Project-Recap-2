using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Journey_Project_Recap_2.Switches
{
    public class Switches
    {

        public Switches()
        {
            Switch();
        }

        // switch = an efficient alternative to many if statements
        public void Switch()
        {
            Console.WriteLine("whate day is today ?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Its monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("Its tusday");
                    break;
                case "Wednesday":
                    Console.WriteLine("Its wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("Its thursday");
                    break;
                case "Friday":
                    Console.WriteLine("Its friday");
                    break;
                case "Saturday":
                    Console.WriteLine("Its saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("Its sunday");
                    break;

                    default:
                    Console.WriteLine(day + " is not a day");
                    break;
            }
        
                Console.ReadLine();
        }
    }
}
