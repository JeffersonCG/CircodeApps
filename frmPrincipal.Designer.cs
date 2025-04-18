namespace CircodeApps
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnSair = new System.Windows.Forms.Button();
            this.picbImc = new System.Windows.Forms.PictureBox();
            this.lblimc = new System.Windows.Forms.Label();
            this.picbData = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picLitro = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbImc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLitro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(842, 481);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(152, 82);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picbImc
            // 
            this.picbImc.Image = ((System.Drawing.Image)(resources.GetObject("picbImc.Image")));
            this.picbImc.Location = new System.Drawing.Point(25, 12);
            this.picbImc.Name = "picbImc";
            this.picbImc.Size = new System.Drawing.Size(128, 128);
            this.picbImc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbImc.TabIndex = 1;
            this.picbImc.TabStop = false;
            this.picbImc.Click += new System.EventHandler(this.picbImc_Click);
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimc.Location = new System.Drawing.Point(7, 143);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(161, 25);
            this.lblimc.TabIndex = 2;
            this.lblimc.Text = "Calculo do IMC";
            // 
            // picbData
            // 
            this.picbData.Image = ((System.Drawing.Image)(resources.GetObject("picbData.Image")));
            this.picbData.Location = new System.Drawing.Point(250, 12);
            this.picbData.Name = "picbData";
            this.picbData.Size = new System.Drawing.Size(128, 128);
            this.picbData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbData.TabIndex = 3;
            this.picbData.TabStop = false;
            this.picbData.Click += new System.EventHandler(this.picbData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculo entre datas";
            // 
            // picLitro
            // 
            this.picLitro.Image = ((System.Drawing.Image)(resources.GetObject("picLitro.Image")));
            this.picLitro.Location = new System.Drawing.Point(482, 12);
            this.picLitro.Name = "picLitro";
            this.picLitro.Size = new System.Drawing.Size(128, 128);
            this.picLitro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLitro.TabIndex = 5;
            this.picLitro.TabStop = false;
            this.picLitro.Click += new System.EventHandler(this.picLitro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Calculo por litro";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1006, 575);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picLitro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbData);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.picbImc);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circo de Apps";
            ((System.ComponentModel.ISupportInitialize)(this.picbImc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLitro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox picbImc;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.PictureBox picbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLitro;
        private System.Windows.Forms.Label label2;
    }
}

