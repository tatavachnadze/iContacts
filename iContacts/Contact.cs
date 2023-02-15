using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iContacts
{
    public class Contact
    {
        public Contact(string firstName, string lastName, DateOnly birthdate, string email, string phone)
        {
           
            FirstName = firstName;
            LastName = lastName;            
            BirthDate = birthdate;
            Email = email;
            Phone = phone;
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Contact))
            {
                throw new ArgumentException(nameof(obj));
            }
           
            if ((obj as Contact).Id == this.Id
                && (obj as Contact).FirstName == this.FirstName
                && (obj as Contact).LastName == this.LastName
                && (obj as Contact).BirthDate == this.BirthDate
                && (obj as Contact).Email == this.Email
                && (obj as Contact).Phone == this.Phone
                )
            {
                return true;
            }

            return false;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return "FirstName: "+FirstName+"\nLastName: " +LastName+"\nBirthDate: "+ BirthDate+"\nEmail: " + Email+"\nPhone: " + Phone;
        }
    }
}
