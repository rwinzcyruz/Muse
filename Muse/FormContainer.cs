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
        private FormLogin _formLogin = new FormLogin();

        public FormContainer()
        {
            InitializeComponent();
        }

        private void FormContainer_Load(object sender, EventArgs e)
        {
            _Login();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (var form in this.MdiChildren)
            {
                form.Close();
            }
            _formLogin.ClearForm();
            _Login();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            string tag = (sender as ToolStripMenuItem).Tag.ToString();
            _ActivateForm(tag);
        }

        private void _Login()
        {
            var result = _formLogin.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    this.Show();
                    this.Focus();
                    _ActivateForm("FormBillList");
                    break;
                case DialogResult.Cancel:
                    this.Close();
                    break;
            }
        }

        private void _ActivateForm(string className)
        {
            var form = Application.OpenForms[className];
            if (form == null)
            {
                var asm = Assembly.GetExecutingAssembly();
                form = asm.CreateInstance(typeof(Program).Namespace + "." + className) as Form;
                form.MdiParent = this;
            }
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.Focus();
        }
    }
}
