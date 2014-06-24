using Muse.Model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Muse
{
    public partial class FormBill : Form
    {
        private RestoContext _db;

        public FormBill()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dgv.AutoGenerateColumns = true;
            _db = new RestoContext();

            _db.Bills.Load();
            bindingSource.DataSource = _db.Bills.Local.Select(x => new { x.Customer.Name, x.Paid, x.Tax, x.CreatedAt, x.UpdatedAt })
                .Where(x => x.Paid == false).OrderBy(x => x.UpdatedAt).ToList();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            var result = new FormAddBill().ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    break;
            }
        }
    }
}