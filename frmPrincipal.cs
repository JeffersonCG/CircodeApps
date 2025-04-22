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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picbImc_Click(object sender, EventArgs e)
        {
            frmImc imc = new frmImc();
            imc.Show();
        }

        private void picbData_Click(object sender, EventArgs e)
        {
            frmData data = new frmData();
            data.Show();
        }

        private void picLitro_Click(object sender, EventArgs e)
        {
            frmLitro litro = new frmLitro();
            litro.Show();
        }

        private void picbAgua_Click(object sender, EventArgs e)
        {
            frmAgua agua = new frmAgua();
            agua.Show();
        }

        private void picbViagem_Click(object sender, EventArgs e)
        {
            frmViagem viagem = new frmViagem();
            viagem.Show();
        }
    }
}
