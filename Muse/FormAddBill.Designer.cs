namespace Muse
{
    partial class FormAddBill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.MaskedTextBox();
            this.txtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.btnBrowseProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowseCustomer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.saveItem = new System.Windows.Forms.ToolStripButton();
            this.editItem = new System.Windows.Forms.ToolStripButton();
            this.deleteItem = new System.Windows.Forms.ToolStripButton();
            this.saveAllItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.btnBrowseProduct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Pesanan";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(330, 25);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 7;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(98, 25);
            this.txtProductCode.Mask = "00000";
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(100, 20);
            this.txtProductCode.TabIndex = 5;
            this.txtProductCode.ValidatingType = typeof(int);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(98, 51);
            this.txtQuantity.Mask = "00000";
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.ValidatingType = typeof(int);
            // 
            // btnBrowseProduct
            // 
            this.btnBrowseProduct.Location = new System.Drawing.Point(436, 23);
            this.btnBrowseProduct.Name = "btnBrowseProduct";
            this.btnBrowseProduct.Size = new System.Drawing.Size(34, 23);
            this.btnBrowseProduct.TabIndex = 3;
            this.btnBrowseProduct.Text = "•••";
            this.btnBrowseProduct.UseVisualStyleBackColor = true;
            this.btnBrowseProduct.Click += new System.EventHandler(this.btnBrowseProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kuantitas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Produk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Produk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kode Pelanggan";
            // 
            // btnBrowseCustomer
            // 
            this.btnBrowseCustomer.Location = new System.Drawing.Point(436, 22);
            this.btnBrowseCustomer.Name = "btnBrowseCustomer";
            this.btnBrowseCustomer.Size = new System.Drawing.Size(34, 23);
            this.btnBrowseCustomer.TabIndex = 3;
            this.btnBrowseCustomer.Text = "•••";
            this.btnBrowseCustomer.UseVisualStyleBackColor = true;
            this.btnBrowseCustomer.Click += new System.EventHandler(this.btnBrowseCustomer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nama Pelanggan";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(98, 24);
            this.txtCustomerCode.Mask = "00000";
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerCode.TabIndex = 5;
            this.txtCustomerCode.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCustomerCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnBrowseCustomer);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(920, 66);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Untuk Pelanggan";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(330, 24);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 7;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DataSource = this.bindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 178);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(920, 312);
            this.dgv.TabIndex = 7;
            this.dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.CountItem = null;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveItem,
            this.editItem,
            this.deleteItem,
            this.saveAllItem});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = null;
            this.bindingNavigator.MoveLastItem = null;
            this.bindingNavigator.MoveNextItem = null;
            this.bindingNavigator.MovePreviousItem = null;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = null;
            this.bindingNavigator.Size = new System.Drawing.Size(952, 25);
            this.bindingNavigator.TabIndex = 8;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // saveItem
            // 
            this.saveItem.Image = global::Muse.Properties.Resources.SaveIcon;
            this.saveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(67, 22);
            this.saveItem.Text = "Simpan";
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // editItem
            // 
            this.editItem.Image = global::Muse.Properties.Resources.EditIcon;
            this.editItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(68, 22);
            this.editItem.Text = "Sunting";
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Image = global::Muse.Properties.Resources.DeleteIcon;
            this.deleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(61, 22);
            this.deleteItem.Text = "Hapus";
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // saveAllItem
            // 
            this.saveAllItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveAllItem.Image = global::Muse.Properties.Resources.SaveIcon;
            this.saveAllItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAllItem.Name = "saveAllItem";
            this.saveAllItem.Size = new System.Drawing.Size(106, 22);
            this.saveAllItem.Text = "Simpan Semua";
            this.saveAllItem.Click += new System.EventHandler(this.saveAllItem_Click);
            // 
            // FormAddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 502);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FormAddBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form Tambah Pesanan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtProductCode;
        private System.Windows.Forms.MaskedTextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCustomerCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.Button btnBrowseCustomer;
        public System.Windows.Forms.Button btnBrowseProduct;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton saveItem;
        private System.Windows.Forms.ToolStripButton editItem;
        private System.Windows.Forms.ToolStripButton deleteItem;
        private System.Windows.Forms.ToolStripButton saveAllItem;
    }
}