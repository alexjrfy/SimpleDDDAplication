using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IBase<T> where T : class
    {
        private readonly DbContextOptions<ApplicationDbContext> _context;

        public BaseRepository()
        {
            _context = new DbContextOptions<ApplicationDbContext>();
        }

        public void Add(T Object)
        {
            throw new NotImplementedException();
        }

        public void Delete(T Object)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            using( var data = new ApplicationDbContext(_context))
            {
                var list = data.Set<T>().ToList();
                return list;
            }
        }

        public T getById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(T Object)
        {
            throw new NotImplementedException();
        }
    }
}
