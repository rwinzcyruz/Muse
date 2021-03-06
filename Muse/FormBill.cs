﻿using Muse.Model;
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
            _db.Bills.Load();
            _Reload();
        }

        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            this._db.Dispose();
        }

        # region Event Handler

        private void btnCreateBill_Click(object sender, EventArgs e) {
            var result = new FormAddBill(bill => _db.Bills.Add(bill)).ShowDialog();

            if (result == DialogResult.OK) {
                _db.SaveChanges();
                _Reload();
            }
        }

        private void btnUpdateBill_Click(object sender, EventArgs e) {
            _UpdateBill(_getRowId());
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e) {
            _rowIndex = e.RowIndex;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            _UpdateBill(_getRowId());
        }

        private void btnDeleteBill_Click(object sender, EventArgs e) {
            if (Utility.ConfirmDelete()) {
                _db.Bills.Remove(_db.Bills.Local.SingleOrDefault(x => x.Id == _getRowId()));
                _db.SaveChanges();
                _Reload();
            }
        }

        private void btnCheckoutBill_Click(object sender, EventArgs e) {
            _db.Bills.Local.SingleOrDefault(x => x.Id == _getRowId()).Paid = true;
            _db.SaveChanges();
            _Reload();
        }

        # endregion

        # region Private Method

        private int _getRowId() {
            return int.Parse(dgvUnpaid.Rows[_rowIndex].Cells["BillId"].Value.ToString());
        }

        private void _UpdateBill(int id) {
            var result = new FormAddBill(_db.Bills.Local.SingleOrDefault(x => x.Id == id)).ShowDialog();

            if (result == DialogResult.OK) {
                _db.SaveChanges();
                _Reload();
            }
        }

        private void _Reload() {
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
        }

        # endregion
    }
}