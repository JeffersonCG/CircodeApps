namespace CircodeApps
{
    partial class frmData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmData));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbl1Data = new System.Windows.Forms.Label();
            this.lbl2Data = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.mtbData1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbData2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(318, 62);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 59);
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
            this.btnSair.Location = new System.Drawing.Point(318, 379);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(91, 59);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbl1Data
            // 
            this.lbl1Data.AutoSize = true;
            this.lbl1Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Data.Location = new System.Drawing.Point(12, 44);
            this.lbl1Data.Name = "lbl1Data";
            this.lbl1Data.Size = new System.Drawing.Size(145, 20);
            this.lbl1Data.TabIndex = 2;
            this.lbl1Data.Text = "Insira a 1° Data:";
            // 
            // lbl2Data
            // 
            this.lbl2Data.AutoSize = true;
            this.lbl2Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Data.Location = new System.Drawing.Point(12, 101);
            this.lbl2Data.Name = "lbl2Data";
            this.lbl2Data.Size = new System.Drawing.Size(150, 20);
            this.lbl2Data.TabIndex = 3;
            this.lbl2Data.Text = "Insira a 2° Data: ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 259);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(131, 25);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado: ";
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.Location = new System.Drawing.Point(12, 318);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(0, 36);
            this.lblMostrar.TabIndex = 5;
            // 
            // mtbData1
            // 
            this.mtbData1.Location = new System.Drawing.Point(12, 63);
            this.mtbData1.Mask = "00/00/0000";
            this.mtbData1.Name = "mtbData1";
            this.mtbData1.Size = new System.Drawing.Size(167, 22);
            this.mtbData1.TabIndex = 6;
            this.mtbData1.ValidatingType = typeof(System.DateTime);
            // 
            // mtbData2
            // 
            this.mtbData2.Location = new System.Drawing.Point(12, 120);
            this.mtbData2.Mask = "00/00/0000";
            this.mtbData2.Name = "mtbData2";
            this.mtbData2.Size = new System.Drawing.Size(167, 22);
            this.mtbData2.TabIndex = 7;
            this.mtbData2.ValidatingType = typeof(System.DateTime);
            // 
            // frmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(437, 470);
            this.Controls.Add(this.mtbData2);
            this.Controls.Add(this.mtbData1);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lbl2Data);
            this.Controls.Add(this.lbl1Data);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo entre datas";
            this.Load += new System.EventHandler(this.frmData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbl1Data;
        private System.Windows.Forms.Label lbl2Data;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.MaskedTextBox mtbData1;
        private System.Windows.Forms.MaskedTextBox mtbData2;
    }
}