namespace CircodeApps
{
    partial class frmViagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViagem));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblAutonomia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblMostrarLitros = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtbAutonomia = new System.Windows.Forms.TextBox();
            this.txtbPreco = new System.Windows.Forms.TextBox();
            this.txtbDistancia = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(522, 77);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 29);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblAutonomia
            // 
            this.lblAutonomia.AutoSize = true;
            this.lblAutonomia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutonomia.Location = new System.Drawing.Point(16, 56);
            this.lblAutonomia.Name = "lblAutonomia";
            this.lblAutonomia.Size = new System.Drawing.Size(173, 20);
            this.lblAutonomia.TabIndex = 2;
            this.lblAutonomia.Text = "Autonomia (Km/LT)";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 8;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(16, 225);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(235, 20);
            this.lblDistancia.TabIndex = 4;
            this.lblDistancia.Text = "Distancia a percorrer (Km)";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(16, 344);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(103, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblMostrarLitros
            // 
            this.lblMostrarLitros.AutoSize = true;
            this.lblMostrarLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarLitros.Location = new System.Drawing.Point(16, 405);
            this.lblMostrarLitros.Name = "lblMostrarLitros";
            this.lblMostrarLitros.Size = new System.Drawing.Size(0, 36);
            this.lblMostrarLitros.TabIndex = 6;
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.Location = new System.Drawing.Point(16, 473);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(0, 36);
            this.lblGastos.TabIndex = 7;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(16, 145);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(266, 20);
            this.lblPreco.TabIndex = 9;
            this.lblPreco.Text = "Preço do combustivel (R$/LT)";
            // 
            // txtbAutonomia
            // 
            this.txtbAutonomia.Location = new System.Drawing.Point(19, 80);
            this.txtbAutonomia.Name = "txtbAutonomia";
            this.txtbAutonomia.Size = new System.Drawing.Size(346, 22);
            this.txtbAutonomia.TabIndex = 10;
            this.txtbAutonomia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbAutonomia_KeyPress);
            // 
            // txtbPreco
            // 
            this.txtbPreco.Location = new System.Drawing.Point(19, 169);
            this.txtbPreco.Name = "txtbPreco";
            this.txtbPreco.Size = new System.Drawing.Size(346, 22);
            this.txtbPreco.TabIndex = 11;
            this.txtbPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPreco_KeyPress);
            // 
            // txtbDistancia
            // 
            this.txtbDistancia.Location = new System.Drawing.Point(19, 249);
            this.txtbDistancia.Name = "txtbDistancia";
            this.txtbDistancia.Size = new System.Drawing.Size(346, 22);
            this.txtbDistancia.TabIndex = 12;
            this.txtbDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbDistancia_KeyPress);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(540, 460);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 29);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 523);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtbDistancia);
            this.Controls.Add(this.txtbPreco);
            this.Controls.Add(this.txtbAutonomia);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblGastos);
            this.Controls.Add(this.lblMostrarLitros);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAutonomia);
            this.Controls.Add(this.btnCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViagem";
            this.Text = "Calculo de viagem";
            this.Load += new System.EventHandler(this.frmViagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblAutonomia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblMostrarLitros;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtbAutonomia;
        private System.Windows.Forms.TextBox txtbPreco;
        private System.Windows.Forms.TextBox txtbDistancia;
        private System.Windows.Forms.Button btnSair;
    }
}