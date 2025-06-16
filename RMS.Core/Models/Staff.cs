using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? Position { get; set; } // Chef, Waiter, Manager
        public string? HashedPassword { get; set; }

        //navigation properties
        public virtual ICollection<Order>? AssignedOrders { get; set; } = new List<Order>();
        public virtual ICollection<Reservation>? AssignedReservations { get; set; } = new List<Reservation>();
        //public virtual ICollection<Table>? AssignedTables { get; set; } = new List<Table>();
    }
}
