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
    public partial class frmMoeda : Form
    {
        public frmMoeda()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double taxaDolar = 5.73;
            double taxaEuro = 6.54;
            double taxaLibra = 7.63;
            double taxaIene = 25;

            if (double.TryParse(txtReal.Text, out double valorReal))
            {
                double valorDolar = valorReal / taxaDolar;
                double valorEuro = valorReal / taxaEuro;
                double valorLibra = valorReal / taxaLibra;
                double valorIene = valorReal * taxaIene;

                lblResultadoDolar.Text = $"{valorDolar:F2}";
                lblResultadoEuro.Text = $"{valorEuro:F2}";
                lblResultadoLibra.Text = $"{valorLibra:F2}";
                lblResultadoYen.Text = $"{valorIene:F2}";
            }
            else
            {
                MessageBox.Show("Digite um valor válido em Reais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
