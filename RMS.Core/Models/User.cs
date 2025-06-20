using Microsoft.AspNetCore.Identity;
using RMS.Core.Enum;
using RMS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Models
{
    public class User : IdentityUser ,IBaseEntity
    {
        public string? Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? ProfilePicture { get; set; }
        public StaffPosition? StaffPosition { get; set; } //Chef, Waiter, Manager

        // Ibase props
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? DeletedBy { get; set; }

        //Navigation properties for staff
        public virtual ICollection<Order>? OrdersAssignedToStaff { get; set; } = new List<Order>();
        public virtual ICollection<Reservation>? ReservationsHandledByStaff { get; set; } = new List<Reservation>();

        // Navigation properties for customer
        public virtual ICollection<Reservation>? ReservationsMadeByCustomer { get; set; } = new List<Reservation>();
        public virtual ICollection<Order>? OrdersPlacedByCustomer { get; set; } = new List<Order>();

        public User()
        {
            CreatedAt = DateTime.UtcNow;
            IsDeleted = false;
        }


    }
}
