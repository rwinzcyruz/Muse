using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muse.Model {

    public class Order {

        [Key, Column(Order = 1), Required]
        public int BillId { get; set; }

        [Key, Column(Order = 2), Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int Total { get { return Product.Price * Quantity; } }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Product Product { get; set; }
    }
}