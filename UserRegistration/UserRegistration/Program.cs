// See https://aka.ms/new-console-template for more information
UserRegistration.RegularExpression regex = new UserRegistration.RegularExpression();
Console.WriteLine("1 - Enter First Name");
Console.WriteLine("2 - Enter Last Name");
Console.WriteLine("3 - Enter Mail Id");
int select = Convert.ToInt32(Console.ReadLine());
switch (select)
{
    case 1:
        Console.WriteLine("Enter First Name");
        string fName = Console.ReadLine();
        regex.name(fName);
        break;
    
    case 2:
        Console.WriteLine("Enter Last Name Name");
        string LName = Console.ReadLine();
        regex.name(LName);
        break;

    case 3:
        Console.WriteLine("Enter Maild Id");
        string MailId= Console.ReadLine();
        regex.ValidateMailId(MailId);
        break;


}
