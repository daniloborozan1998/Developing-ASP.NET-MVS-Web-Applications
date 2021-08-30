using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using BookLibraryApp.Domain.Enums;

namespace BookLibraryApp.ViewModels.ReservationsViewModel
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Payment Method")]
        public PaymentMethodEnums PaymentMethod { get; set; }
        [Display(Name = "Reservation Name")]
        public string ReservationName { get; set; }
        [Display(Name = "Member")]
        public int MemberId { get; set; }
        [Display(Name = "Reservation date time")]
        public string DateTime { get; set; }
        
    }
}
