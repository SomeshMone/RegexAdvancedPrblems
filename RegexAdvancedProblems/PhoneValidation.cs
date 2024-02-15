using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAdvancedProblems
{
    public static class PhoneValidation
    { 
        public static void phoneValidation()
        {
            string filepath = @"C:\Users\somesh\OneDrive\Desktop\data.csv";
            try
            {
                if(File.Exists(filepath))
                {
                    using(StreamReader sr = new StreamReader(filepath))
                    {
                        string phone;
                        string ppattern = @"^\d{2}-\d{4}-\d{3}-\d{3}$";
                        Regex r = new Regex(ppattern);
                        while (!sr.EndOfStream)
                        {
                            phone = sr.ReadLine();
                            Console.WriteLine(phone);
                            bool res = r.IsMatch(phone);
                            if (res)
                            {
                                Console.WriteLine("valid");
                            }
                            else
                            {
                                Console.WriteLine("invalid");
                            }

                        }
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
