using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeApps
{
    public partial class frmViagem : Form
    {
        public frmViagem()
        {
            InitializeComponent();
        }

        private void frmViagem_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtbAutonomia;
            txtbAutonomia.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbAutonomia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtbPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtbDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double preco, autonomia, distancia, combustivel, gasto;
            preco = Convert.ToDouble(txtbPreco.Text);
            autonomia = Convert.ToDouble(txtbAutonomia.Text);
            distancia = Convert.ToDouble(txtbDistancia.Text);
            combustivel = distancia / autonomia;
            gasto = combustivel * preco;
            lblMostrarLitros.Text = combustivel.ToString("F") + "litros gasto.";
            lblGastos.Text = "R$ " + gasto.ToString("F");

        }
    }
}
