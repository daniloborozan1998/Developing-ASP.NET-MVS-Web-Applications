using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Implementations
{
    public class PizzaRepository : IRepository<Pizza>
    {
        public PizzaRepository()
        {

        }
        public void DeleteById(int id)
        {
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                throw new Exception($"Pizza with id {id} not found");
            }
            StaticDb.Pizzas.Remove(pizza);
        }

        public List<Pizza> GetAll()
        {
            return StaticDb.Pizzas;
        }

        public Pizza GetById(int id)
        {
            return StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Pizza entity)
        {
            entity.Id = ++StaticDb.PizzaId;
            StaticDb.Pizzas.Add(entity);
            return entity.Id;
        }

        public void Update(Pizza entity)
        {
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == entity.Id);
            if (pizza == null)
            {
                throw new Exception($"Pizza with id {entity.Id} does not exists");
            }
            int index = StaticDb.Pizzas.IndexOf(pizza);
            StaticDb.Pizzas[index] = entity;
        }
    }
}