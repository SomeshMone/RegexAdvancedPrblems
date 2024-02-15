using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAdvancedProblems
{
    public static class EmailValidation
    {
        public static void EmailValid()
        {
            Console.WriteLine("Enter the email");
            string email = Console.ReadLine();
            string Epattern = @"^[a-zA-Z0-9.%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex r = new Regex(Epattern);
            bool result = r.IsMatch(email);
            if (result)
            {
                Console.WriteLine("Valid Email");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }

        }
    }
}
