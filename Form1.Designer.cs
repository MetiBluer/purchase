namespace Code_Tolentino_Francesz_Inv
{
    partial class frmMain
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnPurchh = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblQuant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(65, 47);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(123, 20);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // btnPurchh
            // 
            this.btnPurchh.Location = new System.Drawing.Point(65, 73);
            this.btnPurchh.Name = "btnPurchh";
            this.btnPurchh.Size = new System.Drawing.Size(75, 23);
            this.btnPurchh.TabIndex = 2;
            this.btnPurchh.Text = "Purchase";
            this.btnPurchh.UseVisualStyleBackColor = true;
            this.btnPurchh.Click += new System.EventHandler(this.btnPurchh_Click);
            // 
            // btnProd
            // 
            this.btnProd.Location = new System.Drawing.Point(169, 73);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(75, 23);
            this.btnProd.TabIndex = 3;
            this.btnProd.Text = "Product";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(53, 120);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(475, 211);
            this.dgvProducts.TabIndex = 4;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(62, 31);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(46, 13);
            this.lblQuant.TabIndex = 6;
            this.lblQuant.Text = "Quantity";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 395);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.btnPurchh);
            this.Controls.Add(this.txtQuantity);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnPurchh;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblQuant;
    }
}

