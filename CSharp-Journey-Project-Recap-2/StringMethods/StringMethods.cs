using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Journey_Project_Recap_2.StringMethods
{
    public class StringMethods
    {
        public StringMethods() 
        {
            Methods();
        }
        public void Methods()
        {

            String fullName = "zoro";
            ////fullName = fullName.ToUpper();
            ////fullName = fullName.ToLower();

            //String phoneNumber = "123-456-789";

            //phoneNumber= phoneNumber.Replace("-", "");

            //Console.WriteLine(phoneNumber);
            //String userName = fullName.Insert(0,"Mr.");
            String firstName = fullName.Substring(0, 3);

            Console.WriteLine(firstName);



        }
    }
}
