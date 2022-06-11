using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RegularExpression
    
    {
            //public void name(string name)
            public string Name(string name)

        {
            const string NAME = "^[A-Z]{1}[a-z]{2,}$";

            if (Regex.IsMatch(name, NAME))
            {
                Console.WriteLine(name + " is a valid Name");
                
                return name;
            }
            Console.WriteLine(name + " is a invalid Name");
            
            return null;
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
        public bool email(string id)
        {
            const string IdRegex = "^[a-zA-z0-9]+([.+-]?[a-zA-z0-9]+)@[a-z0-9]+[.]?(com|co|net)+((.in|.au|.us)*)$"; ;



            if (Regex.IsMatch(id, IdRegex))
                {
                
                Console.WriteLine(id + " Is a valid Mail Id");
                return true;
                 
                }
                Console.WriteLine(id + " Is a Invalid Mail Id");
               return false;
        }

       // public void CheckMobileNo(string number)
            public bool CheckMobileNo(string number)
        {
            const string numberRegex = "^(91 )[6-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(number, numberRegex))
            {
                Console.WriteLine(number + " is a valid Number");
                
                return true;
            }
            Console.WriteLine(number + " is a invalid Number");
            return false;
        }
        public bool Password(string password)
        {
            const string passwordRegex = "^[A-z]{8,}$";
            if (Regex.IsMatch(password, passwordRegex))
            {
                Console.WriteLine(password + " is a valid Password");
                return true;
            }
            Console.WriteLine(password + " is a invalid Password");
            return false;
        }
        public void Rule1UpperCase(string password)
        {
            const string passwordRegex = "^((?=.*[A-Z])(?=.*[a-z])).{8,}$";
            if (Regex.IsMatch(password, passwordRegex))
            {
                Console.WriteLine(password + " is a valid Password");
                return;
            }
            Console.WriteLine(password + " is a invalid Password");
            return;
        }
        public void Rule2AddNumeric(string password)
        {
            const string passwordRegex = "^((?=.*[1-9]{1})(?=.*[A-Z])(?=.*[a-z])).{8,}$";
            if (Regex.IsMatch(password, passwordRegex))
            {
                Console.WriteLine(password + " is a valid Password");
                return;
            }
            Console.WriteLine(password + " is a invalid Password");
            return;
        }
        public void Rule3SpecialChar(string password)
        {
            const string passwordRegex = "^((?=.*[@$!&]{1})(?=.*[1-9]{1})(?=.*[A-Z])(?=.*[a-z])).{8,}$";
            if (Regex.IsMatch(password, passwordRegex))
            {
                Console.WriteLine(password + " is a valid Password");
                return;
            }
            Console.WriteLine(password + " is a invalid Password");
            return;
        }
    }
    }



