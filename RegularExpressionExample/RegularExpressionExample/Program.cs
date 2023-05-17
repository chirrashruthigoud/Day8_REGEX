using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexClass name = new RegexClass();
            Console.WriteLine("Select one:");
            Console.WriteLine("1.First Name \n2.Second Name \n3.PhoneNumbe\n4.CheckEmail"+ 
                "\n5.EmailType \n6.PassWord");
            int num=Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    name.FirstName("Sara");
                    break;
               case 2:

                     name.LastName("Gunt");
                     break;
               case 3:
                    name.PhoneNumber("+91658745960");
                    break;
                case 4:
                    name.Email("abc@gmail.com");
                    break;
                case 5:
                    name.EmailType("sara@2gmail.com");
                    break;
                case 6:
                    name.Password("Slkal2#8521");
                    break;

                default: 
                    Console.WriteLine("invalid");
                    break;
                        }
            Console.ReadLine();
        }
    }
}
