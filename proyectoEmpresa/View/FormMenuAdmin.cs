using proyectoEmpresa.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEmpresa
{
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void btChangeProducts_Click(object sender, EventArgs e)
        {
            FormChangeProducts formChangeProducts = new FormChangeProducts();
            formChangeProducts.Show();
            this.Hide();
        
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct();
            formAddProduct.Show();
            this.Hide();
        }

        private void btStock_Click(object sender, EventArgs e)
        {
            FormStock formStock = new FormStock();
            formStock.Show();
            this.Hide();
        }

        private void btChangeProducts_MouseHover(object sender, EventArgs e)
        {
            pbChange.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btAddProduct_MouseHover(object sender, EventArgs e)
        {
            pbChange.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void btStock_MouseHover(object sender, EventArgs e)
        {
            pbChange.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            FormLog formLog = new FormLog();
            formLog.Show();
        }
    }
}
