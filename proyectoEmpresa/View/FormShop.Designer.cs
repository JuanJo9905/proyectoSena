namespace proyectoEmpresa.View
{
    partial class FormShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShop));
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lbpruebaTotal = new System.Windows.Forms.Label();
            this.btAddToCar = new System.Windows.Forms.Button();
            this.btFact = new System.Windows.Forms.Button();
            this.lbTotFact = new System.Windows.Forms.Label();
            this.lbIdUser = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.btSearchProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btShowProducts = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(147)))), ((int)(((byte)(129)))));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(147)))), ((int)(((byte)(129)))));
            this.dgvProducts.Location = new System.Drawing.Point(202, 72);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(601, 304);
            this.dgvProducts.TabIndex = 0;
            // 
            // lbpruebaTotal
            // 
            this.lbpruebaTotal.AutoSize = true;
            this.lbpruebaTotal.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpruebaTotal.Location = new System.Drawing.Point(664, 423);
            this.lbpruebaTotal.Name = "lbpruebaTotal";
            this.lbpruebaTotal.Size = new System.Drawing.Size(63, 25);
            this.lbpruebaTotal.TabIndex = 26;
            this.lbpruebaTotal.Text = "Total:";
            this.lbpruebaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAddToCar
            // 
            this.btAddToCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(147)))), ((int)(((byte)(129)))));
            this.btAddToCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddToCar.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddToCar.Location = new System.Drawing.Point(659, 382);
            this.btAddToCar.Name = "btAddToCar";
            this.btAddToCar.Size = new System.Drawing.Size(129, 38);
            this.btAddToCar.TabIndex = 27;
            this.btAddToCar.Text = "Agregar";
            this.btAddToCar.UseVisualStyleBackColor = false;
            this.btAddToCar.Click += new System.EventHandler(this.btAddToCar_Click);
            // 
            // btFact
            // 
            this.btFact.AutoSize = true;
            this.btFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(147)))), ((int)(((byte)(129)))));
            this.btFact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFact.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFact.Location = new System.Drawing.Point(214, 382);
            this.btFact.Name = "btFact";
            this.btFact.Size = new System.Drawing.Size(117, 43);
            this.btFact.TabIndex = 28;
            this.btFact.Text = "Facturar";
            this.btFact.UseVisualStyleBackColor = false;
            this.btFact.Click += new System.EventHandler(this.btFact_Click);
            // 
            // lbTotFact
            // 
            this.lbTotFact.AutoSize = true;
            this.lbTotFact.Location = new System.Drawing.Point(219, 440);
            this.lbTotFact.Name = "lbTotFact";
            this.lbTotFact.Size = new System.Drawing.Size(70, 13);
            this.lbTotFact.TabIndex = 29;
            this.lbTotFact.Text = "Total Factura";
            this.lbTotFact.Visible = false;
            // 
            // lbIdUser
            // 
            this.lbIdUser.AutoSize = true;
            this.lbIdUser.Location = new System.Drawing.Point(3, 2);
            this.lbIdUser.Name = "lbIdUser";
            this.lbIdUser.Size = new System.Drawing.Size(13, 13);
            this.lbIdUser.TabIndex = 30;
            this.lbIdUser.Text = "0";
            this.lbIdUser.Visible = false;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(72, 2);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(37, 13);
            this.lbDate.TabIndex = 31;
            this.lbDate.Text = "Fecha";
            this.lbDate.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, -36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 489);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(179)))));
            this.lbTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTime.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.lbTime.Location = new System.Drawing.Point(202, -4);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(601, 83);
            this.lbTime.TabIndex = 34;
            this.lbTime.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(669, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectCategory.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Location = new System.Drawing.Point(32, 237);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(114, 26);
            this.cbSelectCategory.TabIndex = 13;
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchProduct.Location = new System.Drawing.Point(32, 129);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(130, 25);
            this.tbSearchProduct.TabIndex = 14;
            this.tbSearchProduct.Text = "Buscar Producto";
            this.tbSearchProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSearchProduct
            // 
            this.btSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchProduct.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchProduct.Location = new System.Drawing.Point(60, 160);
            this.btSearchProduct.Name = "btSearchProduct";
            this.btSearchProduct.Size = new System.Drawing.Size(75, 33);
            this.btSearchProduct.TabIndex = 21;
            this.btSearchProduct.Text = "Buscar";
            this.btSearchProduct.UseVisualStyleBackColor = true;
            this.btSearchProduct.Click += new System.EventHandler(this.btSearchProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Categorias";
            // 
            // btShowProducts
            // 
            this.btShowProducts.BackColor = System.Drawing.Color.Transparent;
            this.btShowProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btShowProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowProducts.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowProducts.Location = new System.Drawing.Point(51, 273);
            this.btShowProducts.Name = "btShowProducts";
            this.btShowProducts.Size = new System.Drawing.Size(74, 29);
            this.btShowProducts.TabIndex = 20;
            this.btShowProducts.Text = "Mostrar";
            this.btShowProducts.UseVisualStyleBackColor = false;
            this.btShowProducts.Click += new System.EventHandler(this.btShowProducts_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 456);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btShowProducts);
            this.Controls.Add(this.cbSelectCategory);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearchProduct);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbTotFact);
            this.Controls.Add(this.btFact);
            this.Controls.Add(this.btAddToCar);
            this.Controls.Add(this.lbpruebaTotal);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbIdUser);
            this.Name = "FormShop";
            this.Text = "FormShop";
            this.Load += new System.EventHandler(this.FormShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lbpruebaTotal;
        private System.Windows.Forms.Button btAddToCar;
        private System.Windows.Forms.Button btFact;
        public System.Windows.Forms.Label lbTotFact;
        public System.Windows.Forms.Label lbIdUser;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbSelectCategory;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.Button btSearchProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btShowProducts;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}