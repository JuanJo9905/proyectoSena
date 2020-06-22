namespace proyectoEmpresa.View
{
    partial class FormLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLog));
            this.tbNickAdmin = new System.Windows.Forms.TextBox();
            this.tbPassAdmin = new System.Windows.Forms.TextBox();
            this.tbPassUser = new System.Windows.Forms.TextBox();
            this.tbNickUser = new System.Windows.Forms.TextBox();
            this.btLogAdmin = new System.Windows.Forms.Button();
            this.btRegisterAdmin = new System.Windows.Forms.Button();
            this.btLogClient = new System.Windows.Forms.Button();
            this.btRegisterClient = new System.Windows.Forms.Button();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.lbClient = new System.Windows.Forms.Label();
            this.lbIdUser = new System.Windows.Forms.Label();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.pbClient = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNickAdmin
            // 
            this.tbNickAdmin.BackColor = System.Drawing.Color.Silver;
            this.tbNickAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNickAdmin.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNickAdmin.Location = new System.Drawing.Point(164, 128);
            this.tbNickAdmin.Name = "tbNickAdmin";
            this.tbNickAdmin.Size = new System.Drawing.Size(100, 25);
            this.tbNickAdmin.TabIndex = 0;
            this.tbNickAdmin.Text = "Usuario";
            this.tbNickAdmin.Enter += new System.EventHandler(this.tbNickAdmin_Enter);
            this.tbNickAdmin.Leave += new System.EventHandler(this.tbNickAdmin_Leave);
            // 
            // tbPassAdmin
            // 
            this.tbPassAdmin.BackColor = System.Drawing.Color.Silver;
            this.tbPassAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassAdmin.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassAdmin.Location = new System.Drawing.Point(164, 173);
            this.tbPassAdmin.Name = "tbPassAdmin";
            this.tbPassAdmin.Size = new System.Drawing.Size(100, 25);
            this.tbPassAdmin.TabIndex = 1;
            this.tbPassAdmin.Text = "Contraseña";
            this.tbPassAdmin.Enter += new System.EventHandler(this.tbPassAdmin_Enter);
            this.tbPassAdmin.Leave += new System.EventHandler(this.tbPassAdmin_Leave);
            // 
            // tbPassUser
            // 
            this.tbPassUser.BackColor = System.Drawing.Color.Silver;
            this.tbPassUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassUser.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassUser.Location = new System.Drawing.Point(556, 173);
            this.tbPassUser.Name = "tbPassUser";
            this.tbPassUser.Size = new System.Drawing.Size(100, 25);
            this.tbPassUser.TabIndex = 3;
            this.tbPassUser.Text = "Contraseña";
            this.tbPassUser.Enter += new System.EventHandler(this.tbPassUser_Enter);
            this.tbPassUser.Leave += new System.EventHandler(this.tbPassUser_Leave);
            // 
            // tbNickUser
            // 
            this.tbNickUser.BackColor = System.Drawing.Color.Silver;
            this.tbNickUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNickUser.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNickUser.Location = new System.Drawing.Point(556, 128);
            this.tbNickUser.Name = "tbNickUser";
            this.tbNickUser.Size = new System.Drawing.Size(100, 25);
            this.tbNickUser.TabIndex = 2;
            this.tbNickUser.Text = "Usuario";
            this.tbNickUser.Enter += new System.EventHandler(this.tbNickUser_Enter);
            this.tbNickUser.Leave += new System.EventHandler(this.tbNickUser_Leave);
            // 
            // btLogAdmin
            // 
            this.btLogAdmin.AutoSize = true;
            this.btLogAdmin.BackColor = System.Drawing.Color.Silver;
            this.btLogAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogAdmin.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogAdmin.Location = new System.Drawing.Point(99, 220);
            this.btLogAdmin.Name = "btLogAdmin";
            this.btLogAdmin.Size = new System.Drawing.Size(95, 29);
            this.btLogAdmin.TabIndex = 4;
            this.btLogAdmin.Text = "Ingresar";
            this.btLogAdmin.UseVisualStyleBackColor = false;
            this.btLogAdmin.Click += new System.EventHandler(this.btLogAdmin_Click);
            // 
            // btRegisterAdmin
            // 
            this.btRegisterAdmin.AutoSize = true;
            this.btRegisterAdmin.BackColor = System.Drawing.Color.Silver;
            this.btRegisterAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegisterAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegisterAdmin.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegisterAdmin.Location = new System.Drawing.Point(225, 220);
            this.btRegisterAdmin.Name = "btRegisterAdmin";
            this.btRegisterAdmin.Size = new System.Drawing.Size(93, 29);
            this.btRegisterAdmin.TabIndex = 5;
            this.btRegisterAdmin.Text = "Registrarse";
            this.btRegisterAdmin.UseVisualStyleBackColor = false;
            this.btRegisterAdmin.Click += new System.EventHandler(this.btRegisterAdmin_Click);
            // 
            // btLogClient
            // 
            this.btLogClient.AutoSize = true;
            this.btLogClient.BackColor = System.Drawing.Color.Silver;
            this.btLogClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogClient.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogClient.Location = new System.Drawing.Point(508, 220);
            this.btLogClient.Name = "btLogClient";
            this.btLogClient.Size = new System.Drawing.Size(88, 29);
            this.btLogClient.TabIndex = 6;
            this.btLogClient.Text = "Ingresar";
            this.btLogClient.UseVisualStyleBackColor = false;
            this.btLogClient.Click += new System.EventHandler(this.btLogClient_Click);
            // 
            // btRegisterClient
            // 
            this.btRegisterClient.AutoSize = true;
            this.btRegisterClient.BackColor = System.Drawing.Color.Silver;
            this.btRegisterClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegisterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegisterClient.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegisterClient.Location = new System.Drawing.Point(619, 220);
            this.btRegisterClient.Name = "btRegisterClient";
            this.btRegisterClient.Size = new System.Drawing.Size(93, 29);
            this.btRegisterClient.TabIndex = 7;
            this.btRegisterClient.Text = "Registrarse";
            this.btRegisterClient.UseVisualStyleBackColor = false;
            this.btRegisterClient.Click += new System.EventHandler(this.btRegisterClient_Click);
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Location = new System.Drawing.Point(0, 1);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(13, 13);
            this.lbAdmin.TabIndex = 8;
            this.lbAdmin.Text = "0";
            this.lbAdmin.Visible = false;
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(740, 1);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(13, 13);
            this.lbClient.TabIndex = 9;
            this.lbClient.Text = "1";
            this.lbClient.Visible = false;
            // 
            // lbIdUser
            // 
            this.lbIdUser.AutoSize = true;
            this.lbIdUser.Location = new System.Drawing.Point(760, 1);
            this.lbIdUser.Name = "lbIdUser";
            this.lbIdUser.Size = new System.Drawing.Size(15, 13);
            this.lbIdUser.TabIndex = 10;
            this.lbIdUser.Text = "id";
            this.lbIdUser.Visible = false;
            // 
            // pbAdmin
            // 
            this.pbAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbAdmin.Image")));
            this.pbAdmin.Location = new System.Drawing.Point(3, 1);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(401, 456);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdmin.TabIndex = 11;
            this.pbAdmin.TabStop = false;
            // 
            // pbClient
            // 
            this.pbClient.Image = ((System.Drawing.Image)(resources.GetObject("pbClient.Image")));
            this.pbClient.Location = new System.Drawing.Point(401, 1);
            this.pbClient.Name = "pbClient";
            this.pbClient.Size = new System.Drawing.Size(401, 456);
            this.pbClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClient.TabIndex = 12;
            this.pbClient.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 59);
            this.label1.TabIndex = 13;
            this.label1.Text = "Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 59);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cliente";
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRegisterClient);
            this.Controls.Add(this.btLogClient);
            this.Controls.Add(this.tbPassUser);
            this.Controls.Add(this.tbNickUser);
            this.Controls.Add(this.pbClient);
            this.Controls.Add(this.btRegisterAdmin);
            this.Controls.Add(this.btLogAdmin);
            this.Controls.Add(this.tbPassAdmin);
            this.Controls.Add(this.tbNickAdmin);
            this.Controls.Add(this.pbAdmin);
            this.Controls.Add(this.lbIdUser);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.lbAdmin);
            this.Name = "FormLog";
            this.Text = "FormLog";
            this.Load += new System.EventHandler(this.FormLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNickAdmin;
        private System.Windows.Forms.TextBox tbPassAdmin;
        private System.Windows.Forms.TextBox tbPassUser;
        private System.Windows.Forms.TextBox tbNickUser;
        private System.Windows.Forms.Button btLogAdmin;
        private System.Windows.Forms.Button btRegisterAdmin;
        private System.Windows.Forms.Button btLogClient;
        private System.Windows.Forms.Button btRegisterClient;
        public System.Windows.Forms.Label lbAdmin;
        public System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.Label lbIdUser;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.PictureBox pbClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}