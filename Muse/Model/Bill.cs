using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Muse.Model
{
    public class Bill
    {
        public Bill()
        {
            this.Orders = new List<Order>();
        }

        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public double Tax { get; set; }

        [Required]
        public bool Paid { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}