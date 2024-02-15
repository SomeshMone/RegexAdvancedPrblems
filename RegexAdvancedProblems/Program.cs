using System.ComponentModel.DataAnnotations;
using System;
using System.Text.Encodings.Web;

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

            //Html Validation

            Html.html();

        }
    }
}