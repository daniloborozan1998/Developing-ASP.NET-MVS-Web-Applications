using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void Update(T entity);
        void DeleteById(int id);
    }
}
