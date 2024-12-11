using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Journey_Project_Recap_2.LogicalOperators
{
    public class LogicalOperators
    {
        public LogicalOperators() { LogicalOperatorsMethod(); }
        public void LogicalOperatorsMethod() 
        {
            // logical operators = can be used to check if more than 1 condition is true/false
            // && (AND)
            // || (OR)

            Console.WriteLine("Whats tempererture outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());
            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("its warm outside ");
            }
            else if (temp <= -50 || temp >= 50) 
            {
                Console.WriteLine("do not go outside! ");
            }


        }
    }
}
