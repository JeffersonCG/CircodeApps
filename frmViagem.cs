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

            // Verifica se os campos estão vazios
            if (string.IsNullOrWhiteSpace(txtbPreco.Text) ||
                string.IsNullOrWhiteSpace(txtbAutonomia.Text) ||
                string.IsNullOrWhiteSpace(txtbDistancia.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                preco = Convert.ToDouble(txtbPreco.Text.Replace(',', '.'));
                autonomia = Convert.ToDouble(txtbAutonomia.Text.Replace(',', '.'));
                distancia = Convert.ToDouble(txtbDistancia.Text.Replace(',', '.'));

                if (autonomia == 0)
                {
                    MessageBox.Show("A autonomia não pode ser zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                combustivel = distancia / autonomia;
                gasto = combustivel * preco;

                lblMostrarLitros.Text = $"Serão {combustivel:F} litros gastos.";
                lblGastos.Text = $"Totalizando R$ {gasto:F} reais.";

                // Limpa os campos
                txtbPreco.Text = "";
                txtbAutonomia.Text = "";
                txtbDistancia.Text = "";

                this.ActiveControl = txtbAutonomia;
                txtbAutonomia.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira apenas valores numéricos válidos (use vírgula como separador decimal).", "Erro de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
