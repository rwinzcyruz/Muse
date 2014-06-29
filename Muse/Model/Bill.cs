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

        public int Total {
            get {
                var sum = 0;
                foreach (var order in Orders) {
                    sum += order.Total;
                }
                return sum;
            }
        }

        public int TaxFee { get { return Convert.ToInt32(Tax * Total); } }

        public int TotalFee { get { return Total + TaxFee; } }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ObservableListSource<Order> Orders { get { return _orders; } }
    }
}