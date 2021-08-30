using System;
using System.Collections.Generic;
using System.Text;
using BookLibraryApp.Domain.Enums;

namespace BookLibraryApp.Domain.Models
{
    public class Reservation : BaseEntity
    {
        public string ReservationName { get; set; }
        public PaymentMethodEnums PaymentMethod { get; set; }
        public int Price { get; set; }
        public string DateTime { get; set; }
        public List<ReservationBook> ReservationBooks { get; set; }
        public Member Member { get; set; }
        public int MemberId { get; set; }
        
    }
}
