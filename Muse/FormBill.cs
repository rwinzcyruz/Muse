using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Muse.Model;

namespace Muse
{
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            var result = new FormAddBill().ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    _LoadData();
                    break;
            }
        }

        private void _LoadData()
        {
            using (var db = new RestoContext())
            {
                bindingSource.DataSource = db.Bills.ToList();
            }
        }
    }
}
