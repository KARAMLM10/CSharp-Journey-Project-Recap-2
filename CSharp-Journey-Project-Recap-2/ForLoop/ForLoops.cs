using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Journey_Project_Recap_2.ForLoop
{
    public class ForLoops
    {
        public ForLoops() { ForLoopMethod(); }
        public void ForLoopMethod()
        {
            // for loop  =reapets some code a finite amount of times


            //for (int i = 0; i <10; i++ ) 
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < 10; i+= 2)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i <= 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("happy new year");




        }
    }
}
