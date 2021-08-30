using System;
using System.Collections.Generic;
using System.Text;
using BookLibraryApp.DataAccess.Implementations;
using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Services.Implementations;
using BookLibraryApp.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BookLibraryApp.Helpers
{
    public class DependencyInjectionHelper
    {
        public static void InjectServices(IServiceCollection service)
        {
            service.AddTransient<IReservationService, ReservationService>();
            service.AddTransient<IMemberService, MemberService>();
            service.AddTransient<IBookService, BookService>();
        }

        public static void InjectRepositories(IServiceCollection service)
        {
            service.AddTransient<IRepository<Reservation>, ReservationRepository>();
            service.AddTransient<IRepository<Member>, MemberRepository>();
            service.AddTransient<IBookRepository, BookRepository>();
        }
    }
}
