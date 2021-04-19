using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Apps
{
    public class ApplicationContact : IAppContact
    {
        IContact _IContact;

        public ApplicationContact(IContact IContact)
        {
            _IContact = IContact;
        }

        public void Add(Contact Object)
        {
            throw new NotImplementedException();
        }

        public void Delete(Contact Object)
        {
            throw new NotImplementedException();
        }

        public IList<Contact> GetAll()
        {
            var contacts = _IContact.GetAll();
            return contacts;
        }

        public Contact getById(int Id)
        {
            var contact = _IContact.getById(1);
            return contact;
        }

        public void Update(Contact Object)
        {
            throw new NotImplementedException();
        }
    }
}
