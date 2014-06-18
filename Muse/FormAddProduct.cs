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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var price = int.Parse(txtPrice.Text);
            var desc = txtName.Text.Trim();
            var now = DateTime.Now;

            using (var db = new RestoContext())
            {
                var product = new Product
                {
                    Name = name,
                    Price = price,
                    Description = desc,
                    CreatedAt = now,
                    UpdatedAt = now
                };

                db.Products.Add(product);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
