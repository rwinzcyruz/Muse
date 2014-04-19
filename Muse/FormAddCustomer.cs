using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Muse
{
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nama " + txtName.Text + " Alamat " + txtAddress.Text +
                " Telepon " + txtPhone.Text + " Gender " + cboGender.Text + " Email " + txtEmail.Text);
            SqlConnection myConnection = new SqlConnection("user id=andri;" +
                                       "password=andri;server=WINDOWS7-PC;" +
                                       "Trusted_Connection=yes;" +
                                       "database=irestaurant; " +
                                       "connection timeout=30");
            MessageBox.Show(myConnection.ToString());
            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            SqlCommand myCommand = new SqlCommand("INSERT INTO customer (name,created_at,updated_at)" +
                                     "Values ('Erwin',2014-4-6,2014-4-6)", myConnection);
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();

        }

        private void cboGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
