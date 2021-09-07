using System;
using System.Collections.Generic;
using System.Text;
using SEDC.PizzaApp.ViewModels.FeedbackViewModel;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IFeedbackService
    {
        List<FeedbackListViewModel> GetAllFeedbacks();
        FeedbackDetailsViewModel GetFeedbackDetails(int id);
        void CreateFeedback(FeedbackViewModel feedbackViewModel);
        FeedbackViewModel GetFeedbackForEditing(int id);
        void EditFeedback(FeedbackViewModel feedbackViewModel);
        void DeleteFeedback(int id);
    }
}
