using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nama " + txtName.Text + " Alamat " + txtAddress.Text + 
                " Telepon " + txtPhone.Text + " Gender " + cboGender.Text + " Email " + txtEmail.Text);
        }

        private void cboGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
