using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class RegularExpression
    
    {
        public void name(string name)
        {
            const string NAME = "^[A-Z]{1}[a-z]{2,}$";

            if (Regex.IsMatch(name, NAME))
            {
                Console.WriteLine(name + " is a valid Name");
                return;
            }
            Console.WriteLine(name + " is a invalid Name");
            return;
        }
        public void LastName(string name)
        {
            const string NAME = "^[A-Z]{1}[a-z]{2,}$";

            if (Regex.IsMatch(name, NAME))
            {
                Console.WriteLine(name + " is a valid Name");
                return;
            }
            Console.WriteLine(name + " is a invalid Name");
            return;
        }
        public void ValidateMailId(string id)
        {
            const string IdRegex = "^[a-zA-Z0-9]+[.]{1}[a-zA-Z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";

            if (Regex.IsMatch(id, IdRegex))
                {
                
                Console.WriteLine(id + " Is a valid Mail Id");
                return;
                 
                }
                Console.WriteLine(id + " Is a Invalid Mail Id");
               return;
        }
        }
    }



