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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mtbData1.MaskFull || !mtbData2.MaskFull)
                {
                    MessageBox.Show("Por favor, preencha as duas datas corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool sucesso1 = DateTime.TryParse(mtbData1.Text, out DateTime data1);
                bool sucesso2 = DateTime.TryParse(mtbData2.Text, out DateTime data2);

                if (!sucesso1 || !sucesso2)
                {
                    MessageBox.Show("Uma ou ambas as datas são inválidas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TimeSpan diferenca = data1 - data2;
                int dias = Math.Abs(diferenca.Days);

                lblMostrar.Text = $"Diferença de {dias} dias";
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

        private void frmData_Load(object sender, EventArgs e)
        {
            this.ActiveControl = mtbData1;
            mtbData1.Focus();
        }
    }
}
