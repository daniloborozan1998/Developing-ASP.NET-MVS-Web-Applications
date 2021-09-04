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
            return StaticDb.Feedback;
        }

        public Feedback GetById(int id)
        {
            Feedback feedback = StaticDb.Feedback.FirstOrDefault(x => x.Id == id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }

            return feedback;
        }

        public int Insert(Feedback entity)
        {
            entity.Id = ++StaticDb.FeedbackId;
            StaticDb.Feedback.Add(entity);
            return entity.Id;
        }

        public void Update(Feedback entity)
        {
            Feedback feedbackDb = StaticDb.Feedback.FirstOrDefault(x => x.Id == entity.Id);
            int index = StaticDb.Feedback.IndexOf(feedbackDb);
            StaticDb.Feedback[index] = entity;
        }

        public void DeleteById(int id)
        {
            Feedback feedbackDb = StaticDb.Feedback.FirstOrDefault(x => x.Id == id);
            if (feedbackDb == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }
            StaticDb.Feedback.Remove(feedbackDb);
        }
    }
}
