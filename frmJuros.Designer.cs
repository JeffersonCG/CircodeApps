namespace CircodeApps
{
    partial class frmJuros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJuros));
            this.lblMontante = new System.Windows.Forms.Label();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.ltBParcelas = new System.Windows.Forms.ListBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMontante
            // 
            this.lblMontante.AutoSize = true;
            this.lblMontante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontante.Location = new System.Drawing.Point(12, 35);
            this.lblMontante.Name = "lblMontante";
            this.lblMontante.Size = new System.Drawing.Size(145, 20);
            this.lblMontante.TabIndex = 0;
            this.lblMontante.Text = "Valor principal: ";
            // 
            // txtMontante
            // 
            this.txtMontante.Location = new System.Drawing.Point(12, 54);
            this.txtMontante.Name = "txtMontante";
            this.txtMontante.Size = new System.Drawing.Size(136, 22);
            this.txtMontante.TabIndex = 1;
            this.txtMontante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontante_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(766, 35);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 41);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ltBParcelas
            // 
            this.ltBParcelas.FormattingEnabled = true;
            this.ltBParcelas.ItemHeight = 16;
            this.ltBParcelas.Location = new System.Drawing.Point(179, 54);
            this.ltBParcelas.Name = "ltBParcelas";
            this.ltBParcelas.Size = new System.Drawing.Size(554, 324);
            this.ltBParcelas.TabIndex = 3;
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(12, 115);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(136, 22);
            this.txtTaxa.TabIndex = 5;
            this.txtTaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxa_KeyPress);
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(12, 96);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(91, 20);
            this.lblTaxa.TabIndex = 4;
            this.lblTaxa.Text = "Taxa (%):";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(12, 183);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(136, 22);
            this.txtTempo.TabIndex = 7;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(12, 164);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(75, 20);
            this.lblTempo.TabIndex = 6;
            this.lblTempo.Text = "Tempo:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(766, 512);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 44);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelas.Location = new System.Drawing.Point(176, 35);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(91, 20);
            this.lblParcelas.TabIndex = 9;
            this.lblParcelas.Text = "Parcelas:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(176, 388);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 16);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.Location = new System.Drawing.Point(176, 440);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(0, 25);
            this.lblMostrar.TabIndex = 11;
            // 
            // frmJuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(868, 568);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.ltBParcelas);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMontante);
            this.Controls.Add(this.lblMontante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJuros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juros composto";
            this.Load += new System.EventHandler(this.frmJuros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontante;
        private System.Windows.Forms.TextBox txtMontante;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox ltBParcelas;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMostrar;
    }
}