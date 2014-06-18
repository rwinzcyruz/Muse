using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Muse
{
    public partial class FormProductList : Form
    {
        public FormProductList()
        {
            InitializeComponent();
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
            using (var context = new RestoContext())
            {
                productBindingSource.DataSource = context.Products.ToList();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var form = new FormAddProduct();
            var result = form.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    using (var context = new RestoContext())
                    {
                        productBindingSource.DataSource = context.Products.ToList();
                    }
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }
    }
}
