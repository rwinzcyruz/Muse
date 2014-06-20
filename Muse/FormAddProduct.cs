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
        private Action<Product> _saveModel;

        public FormAddProduct(Action<Product> saveModel)
        {
            InitializeComponent();
            _saveModel = saveModel;
        }

        private void _clearForm()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtDesc.Clear();
            txtName.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var price = int.Parse(txtPrice.Text);
            var desc = txtName.Text.Trim();
            var now = DateTime.Now;

            _saveModel(new Product
            {
                Name = name,
                Price = price,
                Description = desc,
                CreatedAt = now,
                UpdatedAt = now
            });

            _clearForm();
        }
    }
}
