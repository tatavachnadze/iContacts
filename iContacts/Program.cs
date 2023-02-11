
namespace iContacts;
class Program
{
    static void Main()
    {
        var contactService = new ContactService();
        Contact contact = new("Tata", "Vachnadze", new DateOnly(1994,4,27), "tata@gmail.com", "+995");
        contactService.New(contact);
        var contact1 = contactService.View(0);
        Contact contact2 = new("Tata", "Vachnadze", new DateOnly(1994, 4, 27), "tata@gmail.com", "+995599158606");
        contactService.Update(0, contact2);
        Console.WriteLine(contact1);
    }

    //private static string ReadInput()
    //{
    //    ContactService contactService = new ContactService();

    //    string inputResult = string.Empty;
    //    while (true)
    //    {
    //        Console.WriteLine("Please Enter Action: ");
    //        string answer = Console.ReadLine();

    //        if (answer.ToUpper() == "N")
    //        {
    //            Console.WriteLine("Enter First Name: ");
    //            string firstName = Console.ReadLine();
    //            Console.WriteLine("Enter Last Name: ");
    //            string lastName = Console.ReadLine();
    //            Console.WriteLine("Enter Age: ");
    //            string age = Console.ReadLine();
    //            Console.WriteLine("Enter Phone: ");
    //            string phone = Console.ReadLine();
    //            Console.WriteLine("Enter Email: ");
    //            string email = Console.ReadLine();


    //            Contact contact = new Contact(0, firstName, lastName, age, phone, email);
    //        }

    //    }

    //}
}