using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Fatec Araçatuba")
            {
                lblTitulo.Text = "Bem-vindo à programação para Windows!";
            }
            else
            {
                lblTitulo.Text = "Fatec Araçatuba";
            }
        }
    }
}
