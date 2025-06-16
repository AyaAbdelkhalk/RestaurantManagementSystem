using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? HashedPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? CreatedAt { get; set; }
        public virtual ICollection<Order>? Orders { get; set; } = new List<Order>();
        public virtual ICollection<Reservation>? Reservations { get; set; } = new List<Reservation>();



    }
}
