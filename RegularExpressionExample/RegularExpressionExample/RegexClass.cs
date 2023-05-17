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

    }
}
