using Muse.Model;
using Muse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Muse.ViewModel {

    class BillViewModel {
        public int BillId { get; set; }

        public string CustomerName { get; set; }

        public decimal Total { get; set; }

        public decimal TaxFee { get; set; }

        public decimal TotalFee { get; set; }
    }
}
