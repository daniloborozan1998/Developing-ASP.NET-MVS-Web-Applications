using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;

namespace BookLibraryApp.DataAccess.Implementations
{
    public class ReservationRepository : IRepository<Reservation>
    {
        public ReservationRepository()
        {

        }
        public List<Reservation> GetAll()
        {
            return StaticDb.Reservations;
        }

        public Reservation GetById(int id)
        {
            return StaticDb.Reservations.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Reservation entity)
        {
            entity.Id = ++StaticDb.ReservationId;
            StaticDb.Reservations.Add(entity);
            return entity.Id;
        }

        public void Update(Reservation entity)
        {
            Reservation reservationDb = StaticDb.Reservations.FirstOrDefault(x => x.Id == entity.Id);
            int index = StaticDb.Reservations.IndexOf(reservationDb);
            StaticDb.Reservations[index] = entity;
        }

        public void DeleteById(int id)
        {
            Reservation reservationDb = StaticDb.Reservations.FirstOrDefault(x => x.Id == id);
            StaticDb.Reservations.Remove(reservationDb);
        }
    }
}
