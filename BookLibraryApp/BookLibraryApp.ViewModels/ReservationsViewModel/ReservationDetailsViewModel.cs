using BookLibraryApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookLibraryApp.ViewModels.ReservationsViewModel
{
    public class ReservationDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Payment Method")]
        public PaymentMethodEnums PaymentMethod { get; set; }
        [Display(Name = "Member")]
        public string MemberFullName { get; set; }
        [Display(Name = "Reservation Name")]
        public string ReservationName { get; set; }
        [Display(Name = "Price")]
        public int Price { get; set; }
        [Display(Name = "Reservation date time")]
        public string DateTime { get; set; }
        [Display(Name = "Book Name")]
        public List<string> BookNames { get; set; }
    }
}
