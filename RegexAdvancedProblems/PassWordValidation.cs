using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAdvancedProblems
{
    public static class PassWordValidation
    {
        public static void passwordValidation()
        {
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            string Pwdpattern = @"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[^\da-zA-Z]).{8,}$";
            Regex r = new Regex(Pwdpattern);
            bool result = r.IsMatch(password);
            if (result)
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }

        }
    }
}
