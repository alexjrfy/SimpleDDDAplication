using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class ContactRepository : BaseRepository<Contact>, IContact
    {
    }
}
