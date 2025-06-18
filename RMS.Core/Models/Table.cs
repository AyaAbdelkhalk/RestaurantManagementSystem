using RMS.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Models
{
    public class Table : BaseEntity
    {
        public int TableId { get; set; }
        [Range(1, int.MaxValue)]
        public int TableNumber { get; set; }
        [Range(1, int.MaxValue)]
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; } = true;
        public virtual ICollection<Reservation>? Reservations { get; set; } = new List<Reservation>();

        //public bool IsReserved(DateTime startTime, DateTime endTime)
        //{
        //    return Reservations?.Any(r =>
        //        (r.StartTime < endTime && r.EndTime > startTime) &&
        //        r.ReservationStatus != Core.Enum.ReservationStatus.Cancelled) ?? false;
        //}

    }
}
