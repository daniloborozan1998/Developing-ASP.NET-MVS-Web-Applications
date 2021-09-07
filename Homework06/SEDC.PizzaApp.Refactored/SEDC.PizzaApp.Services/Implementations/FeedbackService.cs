using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.FeedbackViewModel;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class FeedbackService : IFeedbackService
    {
        private IFeedbackRepository _feedbackRepository;

        public FeedbackService(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public List<FeedbackListViewModel> GetAllFeedbacks()
        {
            List<Feedback> feedbacks = _feedbackRepository.GetAll();
            return feedbacks.Select(x => x.FeedbackToFeedbackListViewModel()).ToList();
        }

        public FeedbackDetailsViewModel GetFeedbackDetails(int id)
        {
            Feedback feedback = _feedbackRepository.GetById(id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }
            return feedback.ToFeedbackDetailsViewModel();
        }

        public void CreateFeedback(FeedbackViewModel feedbackViewModel)
        {
            List<Feedback> feedbacks = _feedbackRepository.GetAll().Where(x => x.Email == (feedbackViewModel.ToFeedback()).Email).ToList();
            if (feedbacks.Count == 3)
            {
                throw new Exception("Can't post anymore feedbacks you have already posted three");
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(feedbackViewModel.Email);
            if (!match.Success)
            {
                throw new Exception("Email is not in correct format");
            }
            Feedback feedback = feedbackViewModel.ToFeedback();
            int newFeedbackId = _feedbackRepository.Insert(feedback);
            if (newFeedbackId <= 0)
            {
                throw new Exception("An error occured while saving to db");
            }
        }

        public FeedbackViewModel GetFeedbackForEditing(int id)
        {
            Feedback feedback = _feedbackRepository.GetById(id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }

            return feedback.ToFeedbackViewModel();
        }

        public void EditFeedback(FeedbackViewModel feedbackViewModel)
        {
            Feedback feedbacks = _feedbackRepository.GetById(feedbackViewModel.Id);
            if (feedbacks == null)
            {
                throw new Exception($"Feedback with id {feedbackViewModel.Id} was not found");
            }

            List<Feedback> feedbackss = _feedbackRepository.GetAll().Where(x => x.Email == (FeedbackMapper.ToFeedback(feedbackViewModel)).Email).ToList();
            if (feedbackss.Count == 3)
            {
                throw new Exception("Can't post anymore feedbacks you have already posted three");
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(feedbackViewModel.Email);
            if (!match.Success)
            {
                throw new Exception("Email is not in correct format");
            }
            Feedback editFeedback = FeedbackMapper.ToFeedback(feedbackViewModel);
            editFeedback.Id = feedbackViewModel.Id;
            _feedbackRepository.Update(editFeedback);
        }

        public void DeleteFeedback(int id)
        {
            Feedback feedback = _feedbackRepository.GetById(id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }
            _feedbackRepository.DeleteById(id);
        }
    }
}
