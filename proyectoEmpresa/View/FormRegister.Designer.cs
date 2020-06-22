namespace proyectoEmpresa
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.Txt_2pass = new System.Windows.Forms.TextBox();
            this.Txt_pass = new System.Windows.Forms.TextBox();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.Txt_documents = new System.Windows.Forms.TextBox();
            this.Txt_Tell = new System.Windows.Forms.TextBox();
            this.Txt_direc = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.Txt_name = new System.Windows.Forms.TextBox();
            this.Btn_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.cbTipeDoc = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_2pass
            // 
            this.Txt_2pass.Location = new System.Drawing.Point(579, 171);
            this.Txt_2pass.Name = "Txt_2pass";
            this.Txt_2pass.Size = new System.Drawing.Size(95, 24);
            this.Txt_2pass.TabIndex = 20;
            // 
            // Txt_pass
            // 
            this.Txt_pass.Location = new System.Drawing.Point(473, 171);
            this.Txt_pass.Name = "Txt_pass";
            this.Txt_pass.Size = new System.Drawing.Size(100, 24);
            this.Txt_pass.TabIndex = 19;
            // 
            // Txt_correo
            // 
            this.Txt_correo.Location = new System.Drawing.Point(473, 133);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(100, 24);
            this.Txt_correo.TabIndex = 18;
            // 
            // Txt_documents
            // 
            this.Txt_documents.Location = new System.Drawing.Point(473, 49);
            this.Txt_documents.Name = "Txt_documents";
            this.Txt_documents.Size = new System.Drawing.Size(100, 24);
            this.Txt_documents.TabIndex = 16;
            // 
            // Txt_Tell
            // 
            this.Txt_Tell.Location = new System.Drawing.Point(107, 171);
            this.Txt_Tell.Name = "Txt_Tell";
            this.Txt_Tell.Size = new System.Drawing.Size(100, 24);
            this.Txt_Tell.TabIndex = 15;
            this.Txt_Tell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Tell_KeyPress);
            // 
            // Txt_direc
            // 
            this.Txt_direc.Location = new System.Drawing.Point(107, 133);
            this.Txt_direc.Name = "Txt_direc";
            this.Txt_direc.Size = new System.Drawing.Size(100, 24);
            this.Txt_direc.TabIndex = 14;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(107, 91);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(100, 24);
            this.txt_surname.TabIndex = 13;
            // 
            // Txt_name
            // 
            this.Txt_name.Location = new System.Drawing.Point(107, 49);
            this.Txt_name.Name = "Txt_name";
            this.Txt_name.Size = new System.Drawing.Size(100, 24);
            this.Txt_name.TabIndex = 12;
            // 
            // Btn_register
            // 
            this.Btn_register.AutoSize = true;
            this.Btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(154)))));
            this.Btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_register.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_register.Location = new System.Drawing.Point(236, 356);
            this.Btn_register.Name = "Btn_register";
            this.Btn_register.Size = new System.Drawing.Size(124, 54);
            this.Btn_register.TabIndex = 11;
            this.Btn_register.Text = "Registrarse";
            this.Btn_register.UseVisualStyleBackColor = false;
            this.Btn_register.Click += new System.EventHandler(this.Btn_registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tipo de documento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(154)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(479, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 54);
            this.button1.TabIndex = 30;
            this.button1.Text = "Iniciar sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(753, 434);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(35, 13);
            this.lbUser.TabIndex = 31;
            this.lbUser.Text = "label9";
            this.lbUser.Visible = false;
            // 
            // cbTipeDoc
            // 
            this.cbTipeDoc.FormattingEnabled = true;
            this.cbTipeDoc.Items.AddRange(new object[] {
            "CC",
            "TI"});
            this.cbTipeDoc.Location = new System.Drawing.Point(473, 91);
            this.cbTipeDoc.Name = "cbTipeDoc";
            this.cbTipeDoc.Size = new System.Drawing.Size(100, 25);
            this.cbTipeDoc.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(204)))));
            this.groupBox1.Controls.Add(this.cbTipeDoc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_2pass);
            this.groupBox1.Controls.Add(this.Txt_pass);
            this.groupBox1.Controls.Add(this.Txt_correo);
            this.groupBox1.Controls.Add(this.Txt_documents);
            this.groupBox1.Controls.Add(this.Txt_Tell);
            this.groupBox1.Controls.Add(this.Txt_direc);
            this.groupBox1.Controls.Add(this.txt_surname);
            this.groupBox1.Controls.Add(this.Txt_name);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 228);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // btExit
            // 
            this.btExit.AutoSize = true;
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(154)))));
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(0, 417);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(83, 30);
            this.btExit.TabIndex = 35;
            this.btExit.Text = "Salir";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_register);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbUser);
            this.Name = "FormRegister";
            this.Text = "Formregist";
            this.Load += new System.EventHandler(this.Formregist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox Txt_2pass;
    private System.Windows.Forms.TextBox Txt_pass;
    private System.Windows.Forms.TextBox Txt_correo;
    private System.Windows.Forms.TextBox Txt_documents;
    private System.Windows.Forms.TextBox Txt_Tell;
    private System.Windows.Forms.TextBox Txt_direc;
    private System.Windows.Forms.TextBox txt_surname;
    private System.Windows.Forms.TextBox Txt_name;
    private System.Windows.Forms.Button Btn_register;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.ComboBox cbTipeDoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btExit;
    }
}