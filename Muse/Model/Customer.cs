using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Muse.Model
{
    public class Customer
    {
        public Customer()
        {
            this.Bills = new List<Bill>();
        }

        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string Name { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [MaxLength(250)]
        public string Address { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public virtual List<Bill> Bills { get; set; }
    }
}