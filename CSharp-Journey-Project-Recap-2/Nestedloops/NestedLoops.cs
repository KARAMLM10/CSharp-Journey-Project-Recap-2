using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Journey_Project_Recap_2.Nestedloops
{
    public class NestedLoops
    {
        public NestedLoops() { NestedloopsMethod(); }
        public void NestedloopsMethod()
        {
            // nested loops = loops inside of other loops 
            // uses very. used a lot in sorting algorithms
            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many Colomns?: ");
            int colomns = Convert.ToInt32(Console.ReadLine());
            Console.Write("What symbol?: ");
            String symbol = Console.ReadLine();

            
                for (int i = 0; i < rows; i++) 
                {
                    for (int j = 0; j < colomns; j++) 
                    {
                        Console.Write(symbol); 
                    }
                    Console.WriteLine();
                }
                


        }
    }
}
