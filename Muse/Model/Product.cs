using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Muse.Model
{
    public class Product
    {
        public Product()
        {
            this.Orders = new List<Order>();
        }

        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}