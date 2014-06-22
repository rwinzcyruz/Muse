using System;
using System.Collections.Generic;

namespace Muse.Model
{
    public class Customer
    {
        public Customer()
        {
            this.Bills = new List<Bill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual List<Bill> Bills { get; set; }
    }
}
