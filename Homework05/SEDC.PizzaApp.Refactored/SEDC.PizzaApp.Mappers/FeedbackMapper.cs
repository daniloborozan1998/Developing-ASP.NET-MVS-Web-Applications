using System;
using System.Collections.Generic;
using System.Text;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public static  class FeedbackMapper
    {
        public static FeedbackListViewModel FeedbackToFeedbackListViewModel(this Feedback feedback)
        {
            return new FeedbackListViewModel()
            {
                Id = feedback.Id,
                Name = feedback.Name,
                Email = feedback.Email
            };
        }

        public static FeedbackDetailsViewModel FeedbackToDetailsViewModel(this Feedback feedback)
        {
            return new FeedbackDetailsViewModel()
            {
                Id = feedback.Id,
                Name = feedback.Name,
                Email = feedback.Email,
                Message = feedback.Message
            };
        }

        public static Feedback ToFeedback(this FeedbackViewModel feedback)
        {
            return new Feedback
            {
                Id = feedback.Id,
                Name = feedback.Name,
                Email = feedback.Email,
                Message = feedback.Message
            };
        }

        public static FeedbackViewModel FeedbackToFeedbackViewModel(this Feedback feedback)
        {
            return new FeedbackViewModel
            {
                Id = feedback.Id,
                Email = feedback.Email,
                Name = feedback.Name,
                Message = feedback.Message
            };
        }
    }
}
