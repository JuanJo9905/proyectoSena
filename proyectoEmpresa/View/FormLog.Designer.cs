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
            this.SuspendLayout();
            // 
            // tbNickAdmin
            // 
            this.tbNickAdmin.Location = new System.Drawing.Point(164, 128);
            this.tbNickAdmin.Name = "tbNickAdmin";
            this.tbNickAdmin.Size = new System.Drawing.Size(100, 20);
            this.tbNickAdmin.TabIndex = 0;
            this.tbNickAdmin.Enter += new System.EventHandler(this.tbNickAdmin_Enter);
            this.tbNickAdmin.Leave += new System.EventHandler(this.tbNickAdmin_Leave);
            // 
            // tbPassAdmin
            // 
            this.tbPassAdmin.Location = new System.Drawing.Point(164, 194);
            this.tbPassAdmin.Name = "tbPassAdmin";
            this.tbPassAdmin.Size = new System.Drawing.Size(100, 20);
            this.tbPassAdmin.TabIndex = 1;
            this.tbPassAdmin.Enter += new System.EventHandler(this.tbPassAdmin_Enter);
            this.tbPassAdmin.Leave += new System.EventHandler(this.tbPassAdmin_Leave);
            // 
            // tbPassUser
            // 
            this.tbPassUser.Location = new System.Drawing.Point(500, 194);
            this.tbPassUser.Name = "tbPassUser";
            this.tbPassUser.Size = new System.Drawing.Size(100, 20);
            this.tbPassUser.TabIndex = 3;
            this.tbPassUser.Enter += new System.EventHandler(this.tbPassUser_Enter);
            this.tbPassUser.Leave += new System.EventHandler(this.tbPassUser_Leave);
            // 
            // tbNickUser
            // 
            this.tbNickUser.Location = new System.Drawing.Point(500, 128);
            this.tbNickUser.Name = "tbNickUser";
            this.tbNickUser.Size = new System.Drawing.Size(100, 20);
            this.tbNickUser.TabIndex = 2;
            this.tbNickUser.Enter += new System.EventHandler(this.tbNickUser_Enter);
            this.tbNickUser.Leave += new System.EventHandler(this.tbNickUser_Leave);
            // 
            // btLogAdmin
            // 
            this.btLogAdmin.Location = new System.Drawing.Point(164, 221);
            this.btLogAdmin.Name = "btLogAdmin";
            this.btLogAdmin.Size = new System.Drawing.Size(75, 23);
            this.btLogAdmin.TabIndex = 4;
            this.btLogAdmin.Text = "Ingresar";
            this.btLogAdmin.UseVisualStyleBackColor = true;
            this.btLogAdmin.Click += new System.EventHandler(this.btLogAdmin_Click);
            // 
            // btRegisterAdmin
            // 
            this.btRegisterAdmin.Location = new System.Drawing.Point(245, 221);
            this.btRegisterAdmin.Name = "btRegisterAdmin";
            this.btRegisterAdmin.Size = new System.Drawing.Size(75, 23);
            this.btRegisterAdmin.TabIndex = 5;
            this.btRegisterAdmin.Text = "Registrarse";
            this.btRegisterAdmin.UseVisualStyleBackColor = true;
            this.btRegisterAdmin.Click += new System.EventHandler(this.btRegisterAdmin_Click);
            // 
            // btLogClient
            // 
            this.btLogClient.Location = new System.Drawing.Point(500, 220);
            this.btLogClient.Name = "btLogClient";
            this.btLogClient.Size = new System.Drawing.Size(75, 23);
            this.btLogClient.TabIndex = 6;
            this.btLogClient.Text = "Ingresar";
            this.btLogClient.UseVisualStyleBackColor = true;
            this.btLogClient.Click += new System.EventHandler(this.btLogClient_Click);
            // 
            // btRegisterClient
            // 
            this.btRegisterClient.Location = new System.Drawing.Point(581, 220);
            this.btRegisterClient.Name = "btRegisterClient";
            this.btRegisterClient.Size = new System.Drawing.Size(75, 23);
            this.btRegisterClient.TabIndex = 7;
            this.btRegisterClient.Text = "Registrarse";
            this.btRegisterClient.UseVisualStyleBackColor = true;
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
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(740, 1);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(13, 13);
            this.lbClient.TabIndex = 9;
            this.lbClient.Text = "1";
            // 
            // lbIdUser
            // 
            this.lbIdUser.AutoSize = true;
            this.lbIdUser.Location = new System.Drawing.Point(760, 1);
            this.lbIdUser.Name = "lbIdUser";
            this.lbIdUser.Size = new System.Drawing.Size(15, 13);
            this.lbIdUser.TabIndex = 10;
            this.lbIdUser.Text = "id";
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbIdUser);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.btRegisterClient);
            this.Controls.Add(this.btLogClient);
            this.Controls.Add(this.btRegisterAdmin);
            this.Controls.Add(this.btLogAdmin);
            this.Controls.Add(this.tbPassUser);
            this.Controls.Add(this.tbNickUser);
            this.Controls.Add(this.tbPassAdmin);
            this.Controls.Add(this.tbNickAdmin);
            this.Name = "FormLog";
            this.Text = "FormLog";
            this.Load += new System.EventHandler(this.FormLog_Load);
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
    }
}