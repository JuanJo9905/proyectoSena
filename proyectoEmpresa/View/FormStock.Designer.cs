namespace proyectoEmpresa.View
{
    partial class FormStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.btSearchProduct = new System.Windows.Forms.Button();
            this.btShowProducts = new System.Windows.Forms.Button();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btSaveChanges = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSearchProduct
            // 
            this.btSearchProduct.AutoSize = true;
            this.btSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.btSearchProduct.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchProduct.Location = new System.Drawing.Point(445, 20);
            this.btSearchProduct.Name = "btSearchProduct";
            this.btSearchProduct.Size = new System.Drawing.Size(75, 32);
            this.btSearchProduct.TabIndex = 15;
            this.btSearchProduct.Text = "Buscar";
            this.btSearchProduct.UseVisualStyleBackColor = false;
            this.btSearchProduct.Click += new System.EventHandler(this.btSearchProduct_Click);
            // 
            // btShowProducts
            // 
            this.btShowProducts.AutoSize = true;
            this.btShowProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.btShowProducts.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowProducts.Location = new System.Drawing.Point(672, 22);
            this.btShowProducts.Name = "btShowProducts";
            this.btShowProducts.Size = new System.Drawing.Size(116, 32);
            this.btShowProducts.TabIndex = 14;
            this.btShowProducts.Text = "Mostrar";
            this.btShowProducts.UseVisualStyleBackColor = false;
            this.btShowProducts.Click += new System.EventHandler(this.btShowProducts_Click);
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchProduct.Location = new System.Drawing.Point(296, 23);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(143, 29);
            this.tbSearchProduct.TabIndex = 13;
            this.tbSearchProduct.Text = "Buscar Producto";
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectCategory.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Location = new System.Drawing.Point(552, 22);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(114, 30);
            this.cbSelectCategory.TabIndex = 12;
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(125)))), ((int)(((byte)(103)))));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(-1, 56);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(801, 339);
            this.dgvProducts.TabIndex = 16;
            // 
            // btSaveChanges
            // 
            this.btSaveChanges.AutoSize = true;
            this.btSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.btSaveChanges.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveChanges.Location = new System.Drawing.Point(682, 402);
            this.btSaveChanges.Name = "btSaveChanges";
            this.btSaveChanges.Size = new System.Drawing.Size(118, 43);
            this.btSaveChanges.TabIndex = 17;
            this.btSaveChanges.Text = "Guardar ";
            this.btSaveChanges.UseVisualStyleBackColor = false;
            this.btSaveChanges.Click += new System.EventHandler(this.btSaveChanges_Click);
            // 
            // btReturn
            // 
            this.btReturn.AutoSize = true;
            this.btReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.btReturn.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.Location = new System.Drawing.Point(-1, 401);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(85, 43);
            this.btReturn.TabIndex = 18;
            this.btReturn.Text = "Menú";
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(105)))), ((int)(((byte)(85)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 56);
            this.label1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(157)))), ((int)(((byte)(141)))));
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(709, 70);
            this.label2.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btSaveChanges);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btSearchProduct);
            this.Controls.Add(this.btShowProducts);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.cbSelectCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormStock";
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSearchProduct;
        private System.Windows.Forms.Button btShowProducts;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.ComboBox cbSelectCategory;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btSaveChanges;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}