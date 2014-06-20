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
            this.menuBill = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBill,
            this.menuProduct,
            this.menuCustomer,
            this.menuUser,
            this.menuLogout,
            this.menuWindows});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.menuWindows;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuBill
            // 
            this.menuBill.Name = "menuBill";
            this.menuBill.Size = new System.Drawing.Size(109, 20);
            this.menuBill.Tag = "";
            this.menuBill.Text = "Lihat Daftar Nota";
            this.menuBill.Click += new System.EventHandler(this.menuBillList_Click);
            // 
            // menuProduct
            // 
            this.menuProduct.Name = "menuProduct";
            this.menuProduct.Size = new System.Drawing.Size(121, 20);
            this.menuProduct.Tag = "";
            this.menuProduct.Text = "Lihat Daftar Produk";
            this.menuProduct.Click += new System.EventHandler(this.menuProduct_Click);
            // 
            // menuCustomer
            // 
            this.menuCustomer.Name = "menuCustomer";
            this.menuCustomer.Size = new System.Drawing.Size(139, 20);
            this.menuCustomer.Tag = "";
            this.menuCustomer.Text = "Lihat Daftar Pelanggan";
            this.menuCustomer.Click += new System.EventHandler(this.menuCustomer_Click);
            // 
            // menuUser
            // 
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(137, 20);
            this.menuUser.Tag = "";
            this.menuUser.Text = "Lihat Daftar Pengguna";
            this.menuUser.Click += new System.EventHandler(this.menuUser_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(52, 20);
            this.menuLogout.Text = "Keluar";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuWindows
            // 
            this.menuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindowsCascade,
            this.menuWindowsTileVertical,
            this.menuWindowsTileHorizontal,
            this.menuWindowsCloseAll});
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.Size = new System.Drawing.Size(68, 20);
            this.menuWindows.Text = "Windows";
            // 
            // menuWindowsCascade
            // 
            this.menuWindowsCascade.Name = "menuWindowsCascade";
            this.menuWindowsCascade.Size = new System.Drawing.Size(151, 22);
            this.menuWindowsCascade.Text = "Cascade";
            this.menuWindowsCascade.Click += new System.EventHandler(this.menuWindowsCascade_Click);
            // 
            // menuWindowsTileVertical
            // 
            this.menuWindowsTileVertical.Name = "menuWindowsTileVertical";
            this.menuWindowsTileVertical.Size = new System.Drawing.Size(151, 22);
            this.menuWindowsTileVertical.Text = "Tile Vertical";
            this.menuWindowsTileVertical.Click += new System.EventHandler(this.menuWindowsTileVertical_Click);
            // 
            // menuWindowsTileHorizontal
            // 
            this.menuWindowsTileHorizontal.Name = "menuWindowsTileHorizontal";
            this.menuWindowsTileHorizontal.Size = new System.Drawing.Size(151, 22);
            this.menuWindowsTileHorizontal.Text = "Tile Horizontal";
            this.menuWindowsTileHorizontal.Click += new System.EventHandler(this.menuWindowsTileHorizontal_Click);
            // 
            // menuWindowsCloseAll
            // 
            this.menuWindowsCloseAll.Name = "menuWindowsCloseAll";
            this.menuWindowsCloseAll.Size = new System.Drawing.Size(151, 22);
            this.menuWindowsCloseAll.Text = "Close All";
            this.menuWindowsCloseAll.Click += new System.EventHandler(this.menuWindowsCloseAll_Click);
            // 
            // FormContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1024, 576);
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
        private System.Windows.Forms.ToolStripMenuItem menuProduct;
        private System.Windows.Forms.ToolStripMenuItem menuCustomer;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
        private System.Windows.Forms.ToolStripMenuItem menuBill;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuWindows;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsCascade;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsTileVertical;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsCloseAll;




    }
}