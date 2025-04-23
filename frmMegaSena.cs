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
    public partial class frmMegaSena : Form
    {
        public frmMegaSena()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            int quantidade = (int)numQuantidade.Value;

            if (quantidade <= 0)
            {
                MessageBox.Show("Escolha pelo menos um número para sortear.", "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantidade > 60)
            {
                MessageBox.Show("Você só pode sortear no máximo 60 números únicos.", "Limite excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Random rnd = new Random();
                HashSet<int> numerosSorteados = new HashSet<int>();

                while (numerosSorteados.Count < quantidade)
                {
                    numerosSorteados.Add(rnd.Next(1, 61));
                }

                var numerosOrdenados = numerosSorteados.OrderBy(n => n).ToList();
                txtResultado.Text = string.Join(" - ", numerosOrdenados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
