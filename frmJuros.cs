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
    public partial class frmJuros : Form
    {
        public frmJuros()
        {
            InitializeComponent();
        }

        private void frmJuros_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtMontante;
            txtMontante.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMontante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                    {
                        e.Handled = true;
                    }
        }

        private void txtTaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double principal, taxa, montante, jurosMensal, totalJuros = 0;
            int meses;

            if (string.IsNullOrWhiteSpace(txtMontante.Text) ||
                string.IsNullOrWhiteSpace(txtTaxa.Text) ||
                string.IsNullOrWhiteSpace(txtTempo.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                principal = Convert.ToDouble(txtMontante.Text.Replace(',', '.'));
                taxa = Convert.ToDouble(txtTaxa.Text.Replace(',', '.')) / 100;
                meses = Convert.ToInt32(txtTempo.Text);

                if (principal <= 0 || taxa <= 0 || meses <= 0)
                {
                    MessageBox.Show("Todos os valores devem ser maiores que zero.", "Valores inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ltBParcelas.Items.Clear();
                ltBParcelas.BeginUpdate();

                for (int i = 1; i <= meses; i++)
                {
                    montante = principal * Math.Pow((1 + taxa), i);
                    jurosMensal = montante - (principal * Math.Pow((1 + taxa), i - 1));
                    totalJuros += jurosMensal;

                    ltBParcelas.Items.Add($"Mês: {i} - Montante: {montante.ToString("C")} - Juros do mês: {jurosMensal.ToString("C")}");
                }

                ltBParcelas.EndUpdate();

                double montanteFinal = principal * Math.Pow((1 + taxa), meses);
                lblMostrar.Text = $"Montante final: {montanteFinal.ToString("C")} | Juros total: {totalJuros.ToString("C")}";

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira apenas números válidos. Use vírgula como separador decimal.", "Erro de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
