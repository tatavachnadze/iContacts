
namespace iContacts;
class Program : Tests
{
    static void Main()
    {
        Tests test1 = new Tests();
        
        var actual1 = new Contact("Tata", "Vachnadze", new DateOnly(1994, 4, 27), "tata@gmail.com", "+995");
        test1.TestViewMethod(actual1);
        var actual2 = new Contact("Tata", "Vachnadze", new DateOnly(1994, 4, 27), "tata@gmail.com", "+995599158606");
        test1.TestUpdateMethod(actual2);
        test1.TestRemoveMethod();
      
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