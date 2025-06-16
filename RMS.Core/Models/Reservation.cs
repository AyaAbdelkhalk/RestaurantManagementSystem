using RMS.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int NumberOfGuests { get; set; }
        public string? SpecialRequests { get; set; }
        public DateTime ReservationCreatedAt { get; set; }
        public int? TableId { get; set; }
        public virtual Table? Table { get; set; }
        public ReservationStatus ReservationStatus { get; set; } = ReservationStatus.Pending;
        public int? StaffId { get; set; } 
        public virtual Staff? Staff { get; set; } 
        // scheduling 
        public DateTime StartTime { get; set; }
        public int DurationInMinutes { get; set; } = 60; 
        public DateTime? EndTime
        {
            get
            {
                return StartTime.AddMinutes(DurationInMinutes);
            }
        }




    }
}
