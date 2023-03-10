using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iContacts
{
    public class ContactService
    {
        private List<Contact> _contacts = new List<Contact>();
        public ContactService()
        {
            _contacts = new List<Contact>();
        }

       
        public void New(string firstName, string lastName, DateOnly birthdate, string email, string phone)
        {
            Contact contact = new(firstName, lastName, birthdate, email, phone);
            _contacts.Add(contact);
        }
        

        public Contact View(int id)
        {
            foreach (Contact contact in _contacts)
            {
                if (contact.Id == id)
                {
                    return contact;
                }              
            }
            return null;            
        }

        public void Update(int id, Contact contact)
        {
            
            for (int i = 0; i < _contacts.Count; i++)
            {
                if (i == id)
                {
                    _contacts[i] = contact;
                }
            }
        }

        public void Remove(int id)
        {
            _contacts.Remove(_contacts[id]);
        }
    }
}
