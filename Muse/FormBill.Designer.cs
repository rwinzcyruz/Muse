namespace Muse
{
    partial class FormBill
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
            this.components = new System.ComponentModel.Container();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnCheckoutBill = new System.Windows.Forms.Button();
            this.dgvUnpaid = new System.Windows.Forms.DataGridView();
            this.unpaidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPaid = new System.Windows.Forms.DataGridView();
            this.paidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaidBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.Location = new System.Drawing.Point(3, 3);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(75, 23);
            this.btnCreateBill.TabIndex = 1;
            this.btnCreateBill.Text = "Buat Nota";
            this.btnCreateBill.UseVisualStyleBackColor = true;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.Location = new System.Drawing.Point(84, 3);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBill.TabIndex = 2;
            this.btnUpdateBill.Text = "Ubah Nota";
            this.btnUpdateBill.UseVisualStyleBackColor = true;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Location = new System.Drawing.Point(165, 3);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBill.TabIndex = 2;
            this.btnDeleteBill.Text = "Hapus Nota";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnCheckoutBill
            // 
            this.btnCheckoutBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckoutBill.Location = new System.Drawing.Point(799, 3);
            this.btnCheckoutBill.Name = "btnCheckoutBill";
            this.btnCheckoutBill.Size = new System.Drawing.Size(118, 23);
            this.btnCheckoutBill.TabIndex = 3;
            this.btnCheckoutBill.Text = "Bayar Tagihan";
            this.btnCheckoutBill.UseVisualStyleBackColor = true;
            this.btnCheckoutBill.Click += new System.EventHandler(this.btnCheckoutBill_Click);
            // 
            // dgvUnpaid
            // 
            this.dgvUnpaid.AllowUserToAddRows = false;
            this.dgvUnpaid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnpaid.AutoGenerateColumns = false;
            this.dgvUnpaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnpaid.DataSource = this.unpaidBindingSource;
            this.dgvUnpaid.Location = new System.Drawing.Point(6, 6);
            this.dgvUnpaid.Name = "dgvUnpaid";
            this.dgvUnpaid.ReadOnly = true;
            this.dgvUnpaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnpaid.Size = new System.Drawing.Size(900, 404);
            this.dgvUnpaid.TabIndex = 4;
            this.dgvUnpaid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgvUnpaid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnCheckoutBill);
            this.panel1.Controls.Add(this.btnCreateBill);
            this.panel1.Controls.Add(this.btnUpdateBill);
            this.panel1.Controls.Add(this.btnDeleteBill);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 30);
            this.panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 442);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvUnpaid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(912, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Belum Lunas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPaid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(912, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sudah Lunas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPaid
            // 
            this.dgvPaid.AllowUserToAddRows = false;
            this.dgvPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaid.AutoGenerateColumns = false;
            this.dgvPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaid.DataSource = this.paidBindingSource;
            this.dgvPaid.Location = new System.Drawing.Point(6, 6);
            this.dgvPaid.Name = "dgvPaid";
            this.dgvPaid.ReadOnly = true;
            this.dgvPaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaid.Size = new System.Drawing.Size(900, 404);
            this.dgvPaid.TabIndex = 0;
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FormBill";
            this.Text = "Daftar Nota";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaidBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnCheckoutBill;
        private System.Windows.Forms.DataGridView dgvUnpaid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource unpaidBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPaid;
        private System.Windows.Forms.BindingSource paidBindingSource;

    }
}