using RMS.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Models
{
    public class Reservation : BaseEntity
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public virtual User Customer { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Number of guests must be at least 1")]
        public int NumberOfGuests { get; set; }
        [StringLength(500)]
        public string? SpecialRequests { get; set; }
        [Required]
        public int TableId { get; set; }
        public virtual Table? Table { get; set; }
        public ReservationStatus ReservationStatus { get; set; } = ReservationStatus.Pending;
        public int? AssignedStaffId { get; set; } 
        public virtual User? AssignedStaff { get; set; } 
        // scheduling 
        public DateTime StartTime { get; set; }
        [Range(1, 180, ErrorMessage = "Duration must be between 1 minute and 3 hours (180 minutes)")]
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
