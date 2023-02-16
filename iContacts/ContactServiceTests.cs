namespace iContacts
{
    public class ContactServiceTests
    {
        public void Run()
        {
            Test_Contact_CreateRead_Method();
            
            Test_Contact_Update_Method();
            Test_Contact_Remove_Method();

        }

        public void Test_Contact_CreateRead_Method()
        {
            ContactService contacts = new ContactService();
            contacts.New("Tata", "Vachnadze", new DateOnly(1994, 4, 27), "tata@gmail.com", "+995");
            
            var actual = contacts.View(0);
            var expected = new Contact("Tata", "Vachnadze", new DateOnly(1994, 4, 27), "tata@gmail.com", "+995");
            Console.WriteLine($"Test_Contact_CreateRead_Method: {IsEqual(actual,expected)}");
        }

        public void Test_Contact_Update_Method() 
        {
            ContactService contacts = new ContactService();            
            contacts.New("Tata", "Vachnadze", new DateOnly(1994, 4, 27), "tata@gmail.com", "+995");
            Contact actual = new("Tata", "Vachnadze", new DateOnly(1994, 4, 27), "tata@gmail.com", "+995599158606");
            contacts.Update(0, actual);
            var expected = contacts.View(0);
            Console.WriteLine($"Test_Contact_Update_Method: {IsEqual(actual,expected)}");
        }

        public void Test_Contact_Remove_Method()
        {
            ContactService contacts = new ContactService();            
            contacts.New("Tata", "Vachnadze", new DateOnly(1994, 4, 27), "tata@gmail.com", "+995");
            contacts.Remove(0);
            var actual = contacts.View(0);
            Contact expected = null;
            Console.WriteLine($"Test_Contact_Remove_Method: {expected == actual}");
        }

        public bool IsEqual(object actual, object expected)
        {
   
            if ((actual as Contact).Id == (expected as Contact).Id
                && (actual as Contact).FirstName == (expected as Contact).FirstName
                && (actual as Contact).LastName == (expected as Contact).LastName
                && (actual as Contact).BirthDate == (expected as Contact).BirthDate
                && (actual as Contact).Email == (expected as Contact).Email
                && (actual as Contact).Phone == (expected as Contact).Phone
                )
            {
                return true;
            }

            return false;
        }
    }
}