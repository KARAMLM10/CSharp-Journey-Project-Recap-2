using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Journey_Project_Recap_2.If
{
    public class IFStatements
    {
        public IFStatements() 
        {
            IF();
        }
        public void IF()
        {
            // IF statements = a basic form of decision making 


             
            //Console.WriteLine("please enter your age : ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 18 && age <=100)
            //{
            //    Console.WriteLine("you are now signed up! ");
            //}
            //else if (age > 100) { Console.WriteLine("you are too old to sign up "); }
            //else if (age < 0 ) { Console.WriteLine("you havent been born yet! "); }
            //else 
            //{
            //    Console.WriteLine("you must be 18+ to sign up! ");    
            //}
            Console.WriteLine("PLease enter your name: ");
            string name = Console.ReadLine();
            //if (name == "")
            //{
            //    Console.WriteLine("you didnt enter your name : ");
            //}
            //else { Console.WriteLine("hello  " + name); }
            if (name != "")
            {
                Console.WriteLine("hello  " + name); 
            }
            else { 
                Console.WriteLine("you didnt enter your name : ");
            }


        }

    }
}
