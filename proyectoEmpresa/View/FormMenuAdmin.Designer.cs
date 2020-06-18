namespace proyectoEmpresa
{
    partial class FormMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAdmin));
            this.btChangeProducts = new System.Windows.Forms.Button();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.btStock = new System.Windows.Forms.Button();
            this.pbChange = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btChangeProducts
            // 
            this.btChangeProducts.AutoSize = true;
            this.btChangeProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChangeProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChangeProducts.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangeProducts.Location = new System.Drawing.Point(299, 68);
            this.btChangeProducts.Name = "btChangeProducts";
            this.btChangeProducts.Size = new System.Drawing.Size(186, 70);
            this.btChangeProducts.TabIndex = 0;
            this.btChangeProducts.Text = "Modificar";
            this.btChangeProducts.UseVisualStyleBackColor = true;
            this.btChangeProducts.Click += new System.EventHandler(this.btChangeProducts_Click);
            this.btChangeProducts.MouseHover += new System.EventHandler(this.btChangeProducts_MouseHover);
            // 
            // btAddProduct
            // 
            this.btAddProduct.AutoSize = true;
            this.btAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddProduct.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProduct.Location = new System.Drawing.Point(267, 195);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(250, 70);
            this.btAddProduct.TabIndex = 1;
            this.btAddProduct.Text = "Agregar producto";
            this.btAddProduct.UseVisualStyleBackColor = true;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            this.btAddProduct.MouseHover += new System.EventHandler(this.btAddProduct_MouseHover);
            // 
            // btStock
            // 
            this.btStock.AutoSize = true;
            this.btStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStock.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStock.Location = new System.Drawing.Point(299, 341);
            this.btStock.Name = "btStock";
            this.btStock.Size = new System.Drawing.Size(186, 70);
            this.btStock.TabIndex = 2;
            this.btStock.Text = "Inventario";
            this.btStock.UseVisualStyleBackColor = true;
            this.btStock.Click += new System.EventHandler(this.btStock_Click);
            this.btStock.MouseHover += new System.EventHandler(this.btStock_MouseHover);
            // 
            // pbChange
            // 
            this.pbChange.Image = ((System.Drawing.Image)(resources.GetObject("pbChange.Image")));
            this.pbChange.Location = new System.Drawing.Point(-1, -2);
            this.pbChange.Name = "pbChange";
            this.pbChange.Size = new System.Drawing.Size(806, 455);
            this.pbChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChange.TabIndex = 3;
            this.pbChange.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(804, 454);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btBack
            // 
            this.btBack.AutoSize = true;
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(717, 418);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(86, 34);
            this.btBack.TabIndex = 6;
            this.btBack.Text = "Volver";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btStock);
            this.Controls.Add(this.btAddProduct);
            this.Controls.Add(this.btChangeProducts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbChange);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormMenuAdmin";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChangeProducts;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Button btStock;
        private System.Windows.Forms.PictureBox pbChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btBack;
    }
}