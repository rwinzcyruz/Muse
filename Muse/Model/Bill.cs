using System;
using System.ComponentModel.DataAnnotations;

namespace Muse.Model {

    public class Bill {
        private readonly ObservableListSource<Order> _orders = new ObservableListSource<Order>();

        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public double Tax { get; set; }

        [Required]
        public bool Paid { get; set; }

        public decimal Total {
            get {
                var sum = 0m;
                foreach (var order in Orders) {
                    sum += order.Total;
                }
                return sum;
            }
        }

        public decimal TaxFee { get { return Convert.ToDecimal((decimal)Tax * Total); } }

        public decimal TotalFee { get { return Total + TaxFee; } }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ObservableListSource<Order> Orders { get { return _orders; } }
    }
}