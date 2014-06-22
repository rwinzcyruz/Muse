using System;

namespace Muse.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int BillId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int ProductId { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }
}
