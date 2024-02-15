using System.ComponentModel.DataAnnotations;
using System;

namespace RegexAdvancedProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Email validation
            EmailValidation.EmailValid();

            //Phone validation
            PhoneValidation.phoneValidation();

            //Password validation
            PassWordValidation.passwordValidation();

        }
    }
}