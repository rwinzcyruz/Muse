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
            Hide();
            foreach (var form in MdiChildren)
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
            foreach (var form in MdiChildren)
            {
                form.Close();
            }
        }

        private void _Login()
        {
            var result = _formLogin.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    Show();
                    Focus();
                    _ActivateForm("FormBillList");
                    break;
                case DialogResult.Cancel:
                    Close();
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
