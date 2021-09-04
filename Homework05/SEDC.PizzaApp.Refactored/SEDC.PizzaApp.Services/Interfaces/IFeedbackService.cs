using System;
using System.Collections.Generic;
using System.Text;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IFeedbackService
    {
        List<FeedbackListViewModel> GetAllFeedback();
        FeedbackDetailsViewModel GetDetails(int id);
        void CreateFeedback(FeedbackViewModel feedbackViewModel);
        FeedbackViewModel GetFeedbackEdit(int id);
        void EditFeedback(FeedbackViewModel feedback);
        void DeleteFeedback(int id);

    }
}
