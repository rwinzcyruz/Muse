namespace Muse
{
    partial class FormContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuBillList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBillList,
            this.menuOrder,
            this.menuProductList,
            this.menuCustomerList,
            this.menuUserList,
            this.menuLogout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuBillList
            // 
            this.menuBillList.Name = "menuBillList";
            this.menuBillList.Size = new System.Drawing.Size(109, 20);
            this.menuBillList.Tag = "FormBillList";
            this.menuBillList.Text = "Lihat Daftar Nota";
            this.menuBillList.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuOrder
            // 
            this.menuOrder.Name = "menuOrder";
            this.menuOrder.Size = new System.Drawing.Size(127, 20);
            this.menuOrder.Tag = "FormOrderList";
            this.menuOrder.Text = "Lihat Daftar Pesanan";
            this.menuOrder.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuProductList
            // 
            this.menuProductList.Name = "menuProductList";
            this.menuProductList.Size = new System.Drawing.Size(121, 20);
            this.menuProductList.Tag = "FormProductList";
            this.menuProductList.Text = "Lihat Daftar Produk";
            this.menuProductList.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuCustomerList
            // 
            this.menuCustomerList.Name = "menuCustomerList";
            this.menuCustomerList.Size = new System.Drawing.Size(139, 20);
            this.menuCustomerList.Tag = "FormCustomerList";
            this.menuCustomerList.Text = "Lihat Daftar Pelanggan";
            this.menuCustomerList.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuUserList
            // 
            this.menuUserList.Name = "menuUserList";
            this.menuUserList.Size = new System.Drawing.Size(137, 20);
            this.menuUserList.Tag = "FormUserList";
            this.menuUserList.Text = "Lihat Daftar Pengguna";
            this.menuUserList.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(52, 20);
            this.menuLogout.Text = "Keluar";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // FormContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Managemen Restoran";
            this.Load += new System.EventHandler(this.FormContainer_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuProductList;
        private System.Windows.Forms.ToolStripMenuItem menuCustomerList;
        private System.Windows.Forms.ToolStripMenuItem menuUserList;
        private System.Windows.Forms.ToolStripMenuItem menuBillList;
        private System.Windows.Forms.ToolStripMenuItem menuOrder;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;




    }
}