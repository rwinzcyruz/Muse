using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Muse
{
    public partial class FormContainer : Form
    {
        private FormBill _billList;
        private FormListing _customerList;
        private FormListing _userList;
        private FormListing _productList;

        public FormContainer()
        {
            InitializeComponent();
        }

        # region event handler

        private void FormContainer_Load(object sender, EventArgs e)
        {
            _Login();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            Hide();
            _CloseAll();
            _Login();
        }

        private void menuBillList_Click(object sender, EventArgs e)
        {
            _Init();
        }

        private void menuWindowsCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuWindowsTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuWindowsTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuWindowsCloseAll_Click(object sender, EventArgs e)
        {
            _CloseAll();
        }

        private void menuProduct_Click(object sender, EventArgs e)
        {
            _ActivateListing(ref _productList, Contract.Product);
        }

        private void menuCustomer_Click(object sender, EventArgs e)
        {
            _ActivateListing(ref _customerList, Contract.Customer);
        }

        private void menuUser_Click(object sender, EventArgs e)
        {
            _ActivateListing(ref _userList, Contract.User);
        }

        # endregion

        # region private method

        private void _Init()
        {
            if (_billList == null || _billList.IsDisposed)
            {
                _billList = new FormBill();
                _billList.MdiParent = this;
            }

            _billList.WindowState = FormWindowState.Maximized;
            _billList.Show();
            _billList.Focus();
        }

        private void _CloseAll()
        {
            foreach (var form in MdiChildren)
            {
                form.Close();
            }
        }

        private void _Login()
        {
            var result = new FormLogin().ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    Show();
                    _Init();
                    break;
                case DialogResult.Cancel:
                    Close();
                    break;
            }
        }

        private void _ActivateListing(ref FormListing form, Contract contract)
        {
            if (form == null || form.IsDisposed)
            {
                form = new FormListing(contract);
                form.MdiParent = this;
            }

            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.Focus();
        }

        # endregion
    }
}
