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
    public partial class frmAgua : Form
    {
        public frmAgua()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Pega o peso inserido no TextBox e converte para número
                double peso = Convert.ToDouble(txtPeso.Text);

                // Verifica se o peso é válido
                if (peso <= 0)
                {
                    MessageBox.Show("Por favor, insira um peso válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calcula a quantidade de água recomendada (peso * 30 ml)
                double quantidadeAgua = peso * 30;

                // Exibe o resultado no Label
                lblResultado.Text = $"Você deve tomar {quantidadeAgua} ml/s de água por dia.";
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, insira um valor numérico válido para o peso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
