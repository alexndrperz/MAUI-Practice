using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    internal class ContactRepository
    {

        public static List<ContactInfo> _contacts = new List<ContactInfo>()
        {
            new ContactInfo() {Id=1, Name = "Juan",Email = "juan@gmail.com",Phone="8091231234", Direction="Villa Juana"},
            new ContactInfo() {Id=2,Name = "Maria",Email = "maria@gmail.com", Phone="8091231234", Direction="Villa Juana"},
            new ContactInfo() {Id = 3, Name = "Pedro",Email = "pedro@gmail.com", Phone="8091231234", Direction="Villa Juana"},
            new ContactInfo() {Id = 4, Name = "Martin",Email = "martin@gmail.com", Phone="8091231234", Direction="Villa Juana"}
        }; 


        public static List<ContactInfo> GetContacts() => _contacts;


        public static ContactInfo? GetContactById(int id)
        {
            return _contacts.FirstOrDefault(conc => conc.Id == id);
        }

        public static void UpdateContact(int contact_id, ContactInfo? contact)
        {
            if (contact_id != (contact?.Id ?? 0)) return;
            var contactUpdate = GetContactById(contact_id);
            if (contactUpdate != null && contact != null)
            {
                contactUpdate.Email = contact.Email;
                contactUpdate.Name = contact.Name;
                contactUpdate.Phone = contact.Phone;
                contactUpdate.Direction = contact.Direction;

            }
        }
    }
}
