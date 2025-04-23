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

            // Converte valores de entrada
            principal = Convert.ToDouble(txtMontante.Text);
            taxa = Convert.ToDouble(txtTaxa.Text) / 100; // só divide UMA vez aqui
            meses = Convert.ToInt32(txtTempo.Text);

            // Limpa a listagem anterior
            ltBParcelas.Items.Clear();
            ltBParcelas.BeginUpdate();

            for (int i = 1; i <= meses; i++)
            {
                // Fórmula do montante para cada mês: M = P * (1 + i)^n
                montante = principal * Math.Pow((1 + taxa), i);
                jurosMensal = montante - (principal * Math.Pow((1 + taxa), i - 1));
                totalJuros += jurosMensal;

                ltBParcelas.Items.Add($"Mês: {i} - Montante: {montante.ToString("C")} - Juros do mês: {jurosMensal.ToString("C")}");
            }

            ltBParcelas.EndUpdate();

            double montanteFinal = principal * Math.Pow((1 + taxa), meses);
            lblMostrar.Text = $"Montante final: {montanteFinal.ToString("C")} | Juros total: {totalJuros.ToString("C")}";
        }
    }
}
