using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public class UserMapper
    {
        public static UserDetailsViewModel UserToUserDetailsViewModel(User user)
        {
            return new UserDetailsViewModel()
            {
                FullName = $"{user.FirstName} {user.LastName}"
            };
        }
    }
}
