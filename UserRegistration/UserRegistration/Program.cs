// See https://aka.ms/new-console-template for more information
UserRegistration.RegularExpression regex = new UserRegistration.RegularExpression();
Console.WriteLine("1 - Enter First Name");
Console.WriteLine("2 - Enter Last Name");
Console.WriteLine("3 - Enter Mail Id");
Console.WriteLine("4 - Mobile Number");
Console.WriteLine("5 - Enter Password");
Console.WriteLine("6 - Rule1 Passord");
Console.WriteLine("7 - Rule2 Add Numeric Value in Passord");
Console.WriteLine("8 - Rule3 Add Special Character in Passord");




int select = Convert.ToInt32(Console.ReadLine());
switch (select)
{
    case 1:
        Console.WriteLine("Enter First Name");
        string fName = Console.ReadLine();
        regex.Name(fName);
        break;
    
    case 2:
        Console.WriteLine("Enter Last Name Name");
        string LName = Console.ReadLine();
        regex.Name(LName);
        break;

    case 3:
        Console.WriteLine("Enter Maild Id");
        string MailId= Console.ReadLine();
        regex.email(MailId);
        break;

    case 4:
        Console.WriteLine("Enter Mobile Number");
        string ContactNo = Console.ReadLine();
        regex.CheckMobileNo(ContactNo);
        break;

    case 5:
        Console.WriteLine("Enter Password");
        string inputPassword = Console.ReadLine();
        regex.Password(inputPassword);
        break;

    case 6:
        Console.WriteLine("Enter Password");
        string InputRule1 = Console.ReadLine();
        regex.Rule1UpperCase(InputRule1);
        break;

    case 7:
        Console.WriteLine("Enter Password");
        string InputRule2 = Console.ReadLine();
        regex.Rule2AddNumeric(InputRule2);
        break;

    case 8:
        Console.WriteLine("Enter Password");
        string InputRule3 = Console.ReadLine();
        regex.Rule3SpecialChar(InputRule3);
        break;
}

