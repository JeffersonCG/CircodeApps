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
    public partial class frmData : Form
    {
        public frmData()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime data1 = dateTimePicker1.Value.Date;
            DateTime data2 = dateTimePicker2.Value.Date;

            TimeSpan diferenca = data1 - data2;
            int dias = Math.Abs(diferenca.Days);

            lblMostrar.Text = $"Diferença de {dias} dias";
        }
    }
}
