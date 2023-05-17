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
        // abc.100@abc.com.au
        public void Email(string mail)
        {
            string pattern = "^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$";
            if (Regex.IsMatch(mail, pattern))
            {
                Console.WriteLine("{0} is valid", mail);
            }
            else
            {
                Console.WriteLine("{0}is invalid", mail);
            }
        }
        //abc@1.com
        public void EmailType(string mail)
        {
            string pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,4}$";
            if (Regex.IsMatch(mail, pattern))
            {
                Console.WriteLine("{0} is valid", mail);
            }
            else
            {
                Console.WriteLine("{0}is invalid", mail);
            }
        }
        public void Password(string password)
        {
            string pattern = "^[A-Z]{1}[a-z0-9]+[$#%&*!@][0-9]";
            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("{0} is valid", password);
            }
            else
            {
                Console.WriteLine("{0}is invalid", password);
            }
        }
    }
}
