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
    public partial class frmLitro : Form
    {
        public frmLitro()
        {
            InitializeComponent();
            AdicionarLinha(); 
            AdicionarLinha();
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            AdicionarLinha();
        }

        private void AdicionarLinha()
        {
            FlowLayoutPanel linha = new FlowLayoutPanel();
            linha.Width = pnlProdutos.Width - 25;
            linha.Height = 30;
            linha.AutoSize = true;
            linha.WrapContents = false;
            linha.Margin = new Padding(3);

            // Label "Nome:"
            Label lblNome = new Label();
            lblNome.Text = "Nome:";
            lblNome.AutoSize = true;

            // TextBox nome
            TextBox txtNome = new TextBox();
            txtNome.Width = 100;

            // Label "ml/L:"
            Label lblMls = new Label();
            lblMls.Text = "ml/L:";
            lblMls.AutoSize = true;

            // TextBox quantidade
            TextBox txtMls = new TextBox();
            txtMls.Width = 60;

            // Label "Preço:"
            Label lblPreco = new Label();
            lblPreco.Text = "Preço:";
            lblPreco.AutoSize = true;

            // TextBox preço
            TextBox txtPreco = new TextBox();
            txtPreco.Width = 60;

            linha.Controls.Add(lblNome);
            linha.Controls.Add(txtNome);
            linha.Controls.Add(lblMls);
            linha.Controls.Add(txtMls);
            linha.Controls.Add(lblPreco);
            linha.Controls.Add(txtPreco);

            pnlProdutos.Controls.Add(linha);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double menorPrecoPorLitro = double.MaxValue;
            string nomeMelhorProduto = "";
            StringBuilder resultados = new StringBuilder();

            foreach (Control ctrl in pnlProdutos.Controls)
            {
                if (ctrl is FlowLayoutPanel linha && linha.Controls.Count >= 6)
                {
                    TextBox txtNome = linha.Controls[1] as TextBox;
                    TextBox txtMls = linha.Controls[3] as TextBox;
                    TextBox txtPreco = linha.Controls[5] as TextBox;

                    try
                    {
                        string nome = txtNome.Text.Trim();
                        double mls = double.Parse(txtMls.Text);
                        double preco = double.Parse(txtPreco.Text);

                        if (mls > 0)
                        {
                            double litros = mls >= 10 ? mls / 1000.0 : mls;
                            double precoPorLitro = preco / litros;

                            resultados.AppendLine($"{(string.IsNullOrEmpty(nome) ? "Produto" : nome)}: R$ {precoPorLitro:F2}/litro");

                            if (precoPorLitro < menorPrecoPorLitro)
                            {
                                menorPrecoPorLitro = precoPorLitro;
                                nomeMelhorProduto = string.IsNullOrEmpty(nome) ? "Produto" : nome;
                            }
                        }
                    }
                    catch
                    {
                        resultados.AppendLine("Erro ao processar linha. Verifique os valores.");
                    }
                }
            }

            resultados.AppendLine();

            if (!string.IsNullOrEmpty(nomeMelhorProduto))
            {
                resultados.AppendLine($"Produto mais vantajoso: {nomeMelhorProduto} (R$ {menorPrecoPorLitro:F2}/litro)");
            }
            else
            {
                resultados.AppendLine("Não foi possível calcular. Verifique os valores.");
            }

            lblResultado.Text = resultados.ToString();
        }
    }
}