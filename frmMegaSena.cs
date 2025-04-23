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

            Random rnd = new Random();
            HashSet<int> numerosSorteados = new HashSet<int>();

            while (numerosSorteados.Count < quantidade)
            {
                numerosSorteados.Add(rnd.Next(1, 61));
            }

            var numerosOrdenados = numerosSorteados.OrderBy(n => n).ToList();
            txtResultado.Text = string.Join(" - ", numerosOrdenados);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
