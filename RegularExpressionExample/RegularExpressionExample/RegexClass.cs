using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionExample
{
    public class RegexClass
    {
        public void FirstName(string name)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("{0} is valid", name);
            }
            else
            {
                Console.WriteLine("{0}is invalid", name);
            }
        
        }
      public void LastName(string lastname)
       {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(lastname, pattern))
            {
                Console.WriteLine("{0} is valid", lastname);
            }
            else
            {
                Console.WriteLine("{0}is invalid", lastname);
            }
        }
        public void PhoneNumber(string phonenum)
        {
            string pattern = "^[+][9-0]{2}[0-9]{3,}$";
            if (Regex.IsMatch(phonenum, pattern))
            {
                Console.WriteLine("{0} is valid", phonenum);
            }
            else
            {
                Console.WriteLine("{0}is invalid", phonenum);
            }
        }
    }
}
