using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Muse.ViewModel {
    
    class OrderViewModel {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int ProductPrice { get; set; }

        public int Quantity { get; set; }
 
        public int Total { get; set; }
    }
}
