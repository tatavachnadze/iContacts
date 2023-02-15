namespace iContacts
{
    internal class Tests
    {

        public void TestViewMethod(Contact actual)
        {
            ContactService contacts = new ContactService();
            Contact contact1 = new("Tata", "Vachnadze", new DateOnly(1994, 4, 27), "tata@gmail.com", "+995");
            contacts.New(contact1);
            Contact expected = contacts.View(0);            
            Console.WriteLine(actual.Equals(expected));
        }

        public void TestUpdateMethod(Contact actual)
        {
            ContactService contacts = new ContactService();
            var contact1 = new Contact("Tata", "Vachnadze", new DateOnly(1994, 4, 27), "tata@gmail.com", "+995");
            contacts.New(contact1);
            contacts.Update(0, actual);
            var expected = contacts.View(0);
            Console.WriteLine(actual.Equals(expected));
        }

        public void TestRemoveMethod()
        {
            ContactService contacts = new ContactService();
            Contact contact1 = new("Tata", "Vachnadze", new DateOnly(1994, 4, 27), "tata@gmail.com", "+995");
            contacts.New(contact1);
            contacts.Remove(0);
            var actual = contacts.View(0);
            Contact expected = null;
            Console.WriteLine(expected == actual);
        }
    }
}