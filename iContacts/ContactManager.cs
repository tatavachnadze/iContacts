using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iContacts
{
    internal class ContactManager
    {
        private List<Contact> _contacts = new List<Contact>();
        public ContactManager()
        {
            _contacts = new List<Contact>();
        }

        public static int Count { get; set; }

        

        public void View()
        {

        }

        public void Edit(Contact contact)
        {
            if (contact == null) throw new ArgumentNullException(nameof(contact));
            for (int i = 0; i < _contacts.Count; i++)
            {
                if (_contacts[i].ID.Equals(contact.ID))
                {
                    _contacts[i] = contact;
                }
            }
        }

        public void Remove(int id)
        {
            _contacts.Remove(_contacts[id - 1]);
        }
    }
}
