using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.Domain.Models
{
    public class ReservationBook : BaseEntity
    {
        public Reservation Reservation { get; set; }
        public int IdReservation { get; set; }
        public Book Book { get; set; }
        public int IdBook { get; set; }
    }
}
