using System;
using System.ComponentModel.DataAnnotations;

namespace Muse.Model {

    public class Product {
        private readonly ObservableListSource<Order> _orders = new ObservableListSource<Order>();

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

        public virtual ObservableListSource<Order> Orders { get { return _orders; } }
    }
}