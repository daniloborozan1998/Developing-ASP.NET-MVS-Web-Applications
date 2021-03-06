using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.EFImplementations
{
    public class UserEFRepository : IRepository<User>
    {
        private PizzaAppDbContext _pizzaAppDbContext;
        public UserEFRepository(PizzaAppDbContext pizzaAppDbContext)
        {
            _pizzaAppDbContext = pizzaAppDbContext;
        }
        public void DeleteById(int id)
        {
            User userDb = _pizzaAppDbContext.Users.FirstOrDefault(x => x.Id == id);
            if (userDb == null)
            {
                throw new Exception($"The user with id {id} was not found");
            }
            _pizzaAppDbContext.Users.Remove(userDb);
            _pizzaAppDbContext.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _pizzaAppDbContext.Users.ToList(); // select * from Users
        }

        public User GetById(int id)
        {
            return _pizzaAppDbContext.Users.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(User entity)
        {
            _pizzaAppDbContext.Users.Add(entity);
            return _pizzaAppDbContext.SaveChanges();
        }

        public void Update(User entity)
        {
            _pizzaAppDbContext.Users.Update(entity);
            _pizzaAppDbContext.SaveChanges();
        }
    }
}
