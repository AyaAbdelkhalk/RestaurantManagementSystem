using RMS.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Models
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        [EmailAddress] 
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string HashedPassword { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public UserType UserType { get; set; } //Admin, Customer, Staff
        public StaffPosition? StaffPosition { get; set; } //Chef, Waiter, Manager
        public string? ProfilePicture { get; set; } // URL or path to the profile picture

        //Navigation properties for staff
        public virtual ICollection<Order>? AssignedOrders { get; set; } = new List<Order>();
        public virtual ICollection<Reservation>? AssignedReservations { get; set; } = new List<Reservation>();

        // Navigation properties for customer
        public virtual ICollection<Reservation>? CustomerReservations { get; set; } = new List<Reservation>();
        public virtual ICollection<Order>? CustomerOrders { get; set; } = new List<Order>();


    }
}
