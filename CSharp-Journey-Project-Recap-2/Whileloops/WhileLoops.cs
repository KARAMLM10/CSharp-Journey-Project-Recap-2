using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Journey_Project_Recap_2.Whileloops
{
    public class WhileLoops
    {
        public WhileLoops() { WhileLoopsMethod(); }
        public void WhileLoopsMethod()
        {
            // while loops = repeats some while som conditions remains true

            //Console.WriteLine("Enter Your Name: ");
            //String name = Console.ReadLine();
            //while (name == "") 
            //{
            //    Console.WriteLine("Enter a name pleas: ");
            //    name = Console.ReadLine();
            //}

            //Console.WriteLine("hello " + name);

            //Console.ReadLine();
            
            // Version-2

            String name = "";
            while (name == "")
            {
                Console.WriteLine("Enter a name pleas: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("hello " + name);

            Console.ReadLine();


        }
    }
}
