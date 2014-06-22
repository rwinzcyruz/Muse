using System;
using System.Collections.Generic;

namespace Muse.Model
{
    public class Bill
    {
        public Bill()
        {
            this.Orders = new List<Order>();
        }

        public int Id { get; set; }
        public double Tax { get; set; }
        public bool Paid { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
