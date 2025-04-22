namespace CircodeApps
{
    partial class frmMoeda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoeda));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblReal = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblResultadoDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblResultadoEuro = new System.Windows.Forms.Label();
            this.lblLibra = new System.Windows.Forms.Label();
            this.lblResultadoLibra = new System.Windows.Forms.Label();
            this.lblYen = new System.Windows.Forms.Label();
            this.lblResultadoYen = new System.Windows.Forms.Label();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(677, 45);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 47);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(677, 391);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 47);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal.Location = new System.Drawing.Point(12, 31);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(208, 20);
            this.lblReal.TabIndex = 2;
            this.lblReal.Text = "Digite o valor em Real:";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(12, 102);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(171, 20);
            this.lblDolar.TabIndex = 3;
            this.lblDolar.Text = "Valor em Dolar ($):";
            // 
            // lblResultadoDolar
            // 
            this.lblResultadoDolar.AutoSize = true;
            this.lblResultadoDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDolar.Location = new System.Drawing.Point(12, 118);
            this.lblResultadoDolar.Name = "lblResultadoDolar";
            this.lblResultadoDolar.Size = new System.Drawing.Size(0, 31);
            this.lblResultadoDolar.TabIndex = 4;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(12, 162);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(164, 20);
            this.lblEuro.TabIndex = 5;
            this.lblEuro.Text = "Valor em Euro (€):";
            // 
            // lblResultadoEuro
            // 
            this.lblResultadoEuro.AutoSize = true;
            this.lblResultadoEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoEuro.Location = new System.Drawing.Point(12, 178);
            this.lblResultadoEuro.Name = "lblResultadoEuro";
            this.lblResultadoEuro.Size = new System.Drawing.Size(0, 31);
            this.lblResultadoEuro.TabIndex = 6;
            // 
            // lblLibra
            // 
            this.lblLibra.AutoSize = true;
            this.lblLibra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibra.Location = new System.Drawing.Point(12, 223);
            this.lblLibra.Name = "lblLibra";
            this.lblLibra.Size = new System.Drawing.Size(163, 20);
            this.lblLibra.TabIndex = 7;
            this.lblLibra.Text = "Valor em Libra(£):";
            // 
            // lblResultadoLibra
            // 
            this.lblResultadoLibra.AutoSize = true;
            this.lblResultadoLibra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoLibra.Location = new System.Drawing.Point(12, 239);
            this.lblResultadoLibra.Name = "lblResultadoLibra";
            this.lblResultadoLibra.Size = new System.Drawing.Size(0, 31);
            this.lblResultadoLibra.TabIndex = 8;
            // 
            // lblYen
            // 
            this.lblYen.AutoSize = true;
            this.lblYen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYen.Location = new System.Drawing.Point(12, 294);
            this.lblYen.Name = "lblYen";
            this.lblYen.Size = new System.Drawing.Size(161, 20);
            this.lblYen.TabIndex = 9;
            this.lblYen.Text = "Valor em Iene (¥):";
            // 
            // lblResultadoYen
            // 
            this.lblResultadoYen.AutoSize = true;
            this.lblResultadoYen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoYen.Location = new System.Drawing.Point(12, 310);
            this.lblResultadoYen.Name = "lblResultadoYen";
            this.lblResultadoYen.Size = new System.Drawing.Size(0, 31);
            this.lblResultadoYen.TabIndex = 10;
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(12, 54);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(194, 22);
            this.txtReal.TabIndex = 11;
            // 
            // frmMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReal);
            this.Controls.Add(this.lblResultadoYen);
            this.Controls.Add(this.lblYen);
            this.Controls.Add(this.lblResultadoLibra);
            this.Controls.Add(this.lblLibra);
            this.Controls.Add(this.lblResultadoEuro);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblResultadoDolar);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblReal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMoeda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de moeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblResultadoDolar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblResultadoEuro;
        private System.Windows.Forms.Label lblLibra;
        private System.Windows.Forms.Label lblResultadoLibra;
        private System.Windows.Forms.Label lblYen;
        private System.Windows.Forms.Label lblResultadoYen;
        private System.Windows.Forms.TextBox txtReal;
    }
}