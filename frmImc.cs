﻿using System;
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
    public partial class frmImc : Form
    {
        public frmImc()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmImc_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtPeso;
            txtPeso.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, resultado;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            resultado = (peso / (altura * altura));
            lblMostrar.Text = resultado.ToString("F");
            txtPeso.Text = "";
            txtAltura.Text = "";

            if (resultado < 18.5)
            {
                MessageBox.Show("Magreza", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado <= 24.9)
            {
                MessageBox.Show("Normal", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado <= 29.9)
            {
                MessageBox.Show("Sobrepeso", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado <= 34.9)
            {
                MessageBox.Show("Obesidade grau I", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado <= 39.9)
            {
                MessageBox.Show("Obesidade grau II", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Obesidade grau III", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44) 
            {
                e.Handled = true;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }

        }
    }
}
