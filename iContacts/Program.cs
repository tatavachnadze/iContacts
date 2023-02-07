
namespace iContacts;
class Program
{
    static void Main()
    {

    }

    private static string ReadInput()
    {
        ContactManager manager = new ContactManager();

        string inputResult = string.Empty;
        while (true)
        {
            Console.WriteLine("Please Enter Action: ");
            string answer = Console.ReadLine();

            if (answer.ToUpper() == "N")
            {
                Console.WriteLine("Enter First Name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                string age = Console.ReadLine();
                Console.WriteLine("Enter Phone: ");
                string phone = Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                string email = Console.ReadLine();


                Contact contact = new Contact(0, firstName, lastName, age, phone, email);
            }

        }

    }
}