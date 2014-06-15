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
    public partial class FormContainer : Form
    {
        Dictionary<string, Form> _forms;

        public FormContainer()
        {
            InitializeComponent();

            _forms = new Dictionary<string, Form> {
                {"bill", new FormBillList()},
                {"order", new FormOrderList()},
                {"product", new FormProductList()},
                {"customer", new FormCustomerList()},
                {"user", new FormUserList()}
            };

            foreach (var form in _forms)
            {
                form.Value.WindowState = FormWindowState.Maximized;
                form.Value.MdiParent = this;
            }

            _forms["bill"].Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            string tag = (sender as ToolStripMenuItem).Tag.ToString();
            _forms[tag].Show();
        }
    }
}
