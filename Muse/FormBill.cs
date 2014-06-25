using Muse.Model;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Muse
{
    public partial class FormBill : Form
    {
        private RestoContext _db;
        private int _rowIndex;

        public FormBill()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dgv.AutoGenerateColumns = true;
            
            _db = new RestoContext();
            _Reload();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._db.Dispose();
        }

        # region Event Handler

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            var result = new FormAddBill().ShowDialog();

            if (result == DialogResult.OK)
            {
                _Reload();
            }
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dgv.Rows[_rowIndex].Cells["id"].Value.ToString());
            _UpdateBill(id);
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e) {
            _rowIndex = e.RowIndex;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            var id = int.Parse(dgv.Rows[e.RowIndex].Cells["id"].Value.ToString());
            _UpdateBill(id);
        }

        private void btnDeleteBill_Click(object sender, EventArgs e) {
            if (Utility.ConfirmDelete()) {
                var id = int.Parse(dgv.Rows[_rowIndex].Cells["id"].Value.ToString());
                _db.Bills.Remove(_db.Bills.Find(id));
                _db.SaveChanges();
                _Reload();
            }
        }

        # endregion

        # region Private Method

        private void _UpdateBill(int id) {
            var result = new FormAddBill(_db.Bills.Find(id)).ShowDialog();

            if (result == DialogResult.OK) {
                _Reload();
            }
        }

        private void _Reload() {
            _db.Bills.Where(x => x.Paid == false).Load();
            bindingSource.DataSource = _db.Bills.Local
                .Select(x => new { x.Id, x.Customer.Name, x.Paid, x.Total, x.TaxFee, x.TotalFee, x.CreatedAt, x.UpdatedAt })
                .OrderByDescending(x => x.UpdatedAt).ToList();
        }

        # endregion
    }
}