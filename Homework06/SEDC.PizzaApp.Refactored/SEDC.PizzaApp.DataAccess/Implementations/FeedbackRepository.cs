using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.DataAccess.Implementations
{
    public class FeedbackRepository : IFeedbackRepository
    {
        public List<Feedback> GetAll()
        {
            return StaticDb.Feedbacks;
        }

        public Feedback GetById(int id)
        {
            Feedback feedbackDb = StaticDb.Feedbacks.FirstOrDefault(x => x.Id == id);
            if (feedbackDb == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }
            return feedbackDb;
        }

        public int Insert(Feedback entity)
        {
            entity.Id = ++StaticDb.FeeedBackId;
            StaticDb.Feedbacks.Add(entity);
            return entity.Id;
        }

        public void Update(Feedback entity)
        {
            Feedback feedbackDb = StaticDb.Feedbacks.FirstOrDefault(x => x.Id == entity.Id);
            int index = StaticDb.Feedbacks.IndexOf(feedbackDb);
            StaticDb.Feedbacks[index] = entity;
        }

        public void DeleteById(int id)
        {
            Feedback feedbackDb = StaticDb.Feedbacks.FirstOrDefault(x => x.Id == id);
            if (feedbackDb == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }
            StaticDb.Feedbacks.Remove(feedbackDb);
        }
    }
}
