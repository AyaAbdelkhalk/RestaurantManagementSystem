using RMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services.Reservation
{
    public class ReservationServices : IReservationServices
    {
        private readonly IReservationRepository _reservationRepository;
        public ReservationServices(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }
    }
}
