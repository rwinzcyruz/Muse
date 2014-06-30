using Muse.Model;
using Muse.ViewModel;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Muse {

    public partial class FormBill : Form {
        private RestoContext _db;
        private int _rowIndex;

        public FormBill() {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            dgvUnpaid.AutoGenerateColumns = true;
            dgvPaid.AutoGenerateColumns = true;

            _db = new RestoContext();
            _Reload();
        }

        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            this._db.Dispose();
        }

        # region Event Handler

        private void btnCreateBill_Click(object sender, EventArgs e) {
            var result = new FormAddBill().ShowDialog();

            if (result == DialogResult.OK) {
                _Reload();
                dgvUnpaid.Refresh();
            }
        }

        private void btnUpdateBill_Click(object sender, EventArgs e) {
            var id = int.Parse(dgvUnpaid.Rows[_rowIndex].Cells["BillId"].Value.ToString());
            _UpdateBill(id);
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e) {
            _rowIndex = e.RowIndex;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            var id = int.Parse(dgvUnpaid.Rows[e.RowIndex].Cells["BillId"].Value.ToString());
            _UpdateBill(id);
        }

        private void btnDeleteBill_Click(object sender, EventArgs e) {
            if (Utility.ConfirmDelete()) {
                var id = int.Parse(dgvUnpaid.Rows[_rowIndex].Cells["BillId"].Value.ToString());
                _db.Bills.Remove(_db.Bills.Find(id));
                _db.SaveChanges();
                _Reload();
            }
        }

        # endregion

        # region Private Method

        private void _UpdateBill(int id) {
            var result = new FormAddBill(id).ShowDialog();

            if (result == DialogResult.OK) {
                _Reload();
            }
        }

        private void _Reload() {
            _db.Bills.Load();
            unpaidBindingSource.DataSource = _db.Bills.Local
                .Where(x => x.Paid == false)
                .OrderByDescending(x => x.UpdatedAt)
                .Select(x => new BillViewModel {
                    BillId = x.Id,
                    CustomerName = x.Customer.Name,
                    Total = x.Total,
                    TaxFee = x.TaxFee,
                    TotalFee = x.TotalFee
                }).ToList();
            paidBindingSource.DataSource = _db.Bills.Local
                .Where(x => x.Paid == true)
                .OrderByDescending(x => x.UpdatedAt)
                .Select(x => new BillViewModel {
                    BillId = x.Id,
                    CustomerName = x.Customer.Name,
                    Total = x.Total,
                    TaxFee = x.TaxFee,
                    TotalFee = x.TotalFee
                }).ToList();
            dgvUnpaid.Refresh();
        }

        # endregion
    }
}