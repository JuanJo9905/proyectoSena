using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace proyectoEmpresa.View
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        private void btLogAdmin_Click(object sender, EventArgs e)
        {
            MySqlConnection conectaradmin = new MySqlConnection("server=localhost; database=datos_proyecto; UID=root; password=;");
            conectaradmin.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectaradmin;

            codigo.CommandText = ("Select * from clientes where Nombre ='" + tbNickAdmin.Text + "'and Contraseña = '" + tbPassAdmin.Text + "'and TipoPersona= '" + 0 + "'");

            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("bienvenido");
                FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
                formMenuAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
            conectaradmin.Close();

        }


        private void btLogClient_Click(object sender, EventArgs e)
        {
            MySqlConnection conectaruser = new MySqlConnection("server=localhost; database=datos_proyecto; UID=root; password=;");
            conectaruser.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectaruser;

            codigo.CommandText = ("Select *from clientes where nombre ='" + tbNickUser.Text + "'and contraseña = '" + tbPassUser.Text + "'and TipoPersona= '" + 1 + "'");

            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("bienvenido");
                Form register = new FormShop();
                register.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
            conectaruser.Close();
        }

        private void tbNickAdmin_Enter(object sender, EventArgs e)
        {
            if (tbNickAdmin.Text == "Usuario administrador")
            {
                tbNickAdmin.Text = "";
                tbNickAdmin.ForeColor = Color.Black;
            }
        }

        private void tbPassAdmin_Leave(object sender, EventArgs e)
        {
            if (tbPassAdmin.Text == "")
            {
                tbPassAdmin.Text = "Contraseña";
                tbPassAdmin.ForeColor = Color.Red;
                tbPassAdmin.UseSystemPasswordChar = false;
            }
        }

        private void tbPassAdmin_Enter(object sender, EventArgs e)
        {
            if (tbPassAdmin.Text == "Contraseña")
            {
                tbPassAdmin.Text = "";
                tbPassAdmin.ForeColor = Color.Black;
                tbPassAdmin.UseSystemPasswordChar = true;
                tbPassAdmin.UseSystemPasswordChar = true;
            }
        }

        private void tbNickUser_Leave(object sender, EventArgs e)
        {
            if (tbNickUser.Text == "")
            {
                tbNickUser.Text = "Usuario";
                tbNickUser.ForeColor = Color.Red;
            }
        }

        private void tbNickUser_Enter(object sender, EventArgs e)
        {
            if (tbNickUser.Text == "Usuario")
            {
                tbNickUser.Text = "";
                tbNickUser.ForeColor = Color.Black;
            }
        }

        private void tbPassUser_Enter(object sender, EventArgs e)
        {
            if (tbPassUser.Text == "Contraseña")
            {
                tbPassUser.Text = "";
                tbPassUser.ForeColor = Color.Black;
                tbPassUser.UseSystemPasswordChar = true;
            }
        }

        private void tbPassUser_Leave(object sender, EventArgs e)
        {
            if (tbPassUser.Text == "")
            {
                tbPassUser.Text = "Contraseña";
                tbPassUser.ForeColor = Color.Red;
                tbPassUser.UseSystemPasswordChar = false;
            }
        }

        private void btRegisterAdmin_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.lbUser.Text = lbAdmin.Text;
            register.Show();
        }

        private void btRegisterClient_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.lbUser.Text = lbClient.Text;
            register.Show();
        }
    }
}
