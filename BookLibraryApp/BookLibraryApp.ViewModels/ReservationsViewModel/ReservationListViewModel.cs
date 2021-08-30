using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.ViewModels.ReservationsViewModel
{
    public class ReservationListViewModel
    {
        public int Id { get; set; }
        public string MemberFullName { get; set; }
        public string ReservationName { get; set; }
        public int Price { get; set; }
        public string DateTime { get; set; }
        public List<string> BookNames { get; set; }
    }
}
