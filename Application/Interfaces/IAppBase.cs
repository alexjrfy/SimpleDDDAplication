using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IAppBase<T> where T : class
    {
        void Add(T Object);
        void Update(T Object);
        void Delete(T Object);
        IList<T> GetAll();
        T getById(int Id);
    }
}
