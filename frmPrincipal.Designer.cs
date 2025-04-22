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
            this.picbAgua = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblViagem = new System.Windows.Forms.Label();
            this.picbViagem = new System.Windows.Forms.PictureBox();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.picbMoeda = new System.Windows.Forms.PictureBox();
            this.lblMegaSena = new System.Windows.Forms.Label();
            this.picbMegaSena = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbImc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLitro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbAgua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbViagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMegaSena)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(876, 481);
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
            this.picbData.Location = new System.Drawing.Point(277, 12);
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
            this.label1.Location = new System.Drawing.Point(233, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculo entre datas";
            // 
            // picLitro
            // 
            this.picLitro.Image = ((System.Drawing.Image)(resources.GetObject("picLitro.Image")));
            this.picLitro.Location = new System.Drawing.Point(530, 12);
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
            this.label2.Location = new System.Drawing.Point(511, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Calculo por litro";
            // 
            // picbAgua
            // 
            this.picbAgua.Image = ((System.Drawing.Image)(resources.GetObject("picbAgua.Image")));
            this.picbAgua.Location = new System.Drawing.Point(778, 12);
            this.picbAgua.Name = "picbAgua";
            this.picbAgua.Size = new System.Drawing.Size(128, 128);
            this.picbAgua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbAgua.TabIndex = 7;
            this.picbAgua.TabStop = false;
            this.picbAgua.Click += new System.EventHandler(this.picbAgua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(754, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Calculo de Agua";
            // 
            // lblViagem
            // 
            this.lblViagem.AutoSize = true;
            this.lblViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViagem.Location = new System.Drawing.Point(7, 378);
            this.lblViagem.Name = "lblViagem";
            this.lblViagem.Size = new System.Drawing.Size(190, 25);
            this.lblViagem.TabIndex = 10;
            this.lblViagem.Text = "Calculo de viagem";
            // 
            // picbViagem
            // 
            this.picbViagem.Image = ((System.Drawing.Image)(resources.GetObject("picbViagem.Image")));
            this.picbViagem.Location = new System.Drawing.Point(25, 247);
            this.picbViagem.Name = "picbViagem";
            this.picbViagem.Size = new System.Drawing.Size(128, 128);
            this.picbViagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbViagem.TabIndex = 9;
            this.picbViagem.TabStop = false;
            this.picbViagem.Click += new System.EventHandler(this.picbViagem_Click);
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoeda.Location = new System.Drawing.Point(232, 378);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(213, 25);
            this.lblMoeda.TabIndex = 12;
            this.lblMoeda.Text = "Conversor de moeda";
            this.lblMoeda.Click += new System.EventHandler(this.label4_Click);
            // 
            // picbMoeda
            // 
            this.picbMoeda.Image = ((System.Drawing.Image)(resources.GetObject("picbMoeda.Image")));
            this.picbMoeda.Location = new System.Drawing.Point(277, 247);
            this.picbMoeda.Name = "picbMoeda";
            this.picbMoeda.Size = new System.Drawing.Size(128, 128);
            this.picbMoeda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbMoeda.TabIndex = 11;
            this.picbMoeda.TabStop = false;
            this.picbMoeda.Click += new System.EventHandler(this.picbMoeda_Click);
            // 
            // lblMegaSena
            // 
            this.lblMegaSena.AutoSize = true;
            this.lblMegaSena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMegaSena.Location = new System.Drawing.Point(478, 378);
            this.lblMegaSena.Name = "lblMegaSena";
            this.lblMegaSena.Size = new System.Drawing.Size(247, 25);
            this.lblMegaSena.TabIndex = 14;
            this.lblMegaSena.Text = "Numeros da Mega-Sena";
            // 
            // picbMegaSena
            // 
            this.picbMegaSena.Image = ((System.Drawing.Image)(resources.GetObject("picbMegaSena.Image")));
            this.picbMegaSena.Location = new System.Drawing.Point(530, 247);
            this.picbMegaSena.Name = "picbMegaSena";
            this.picbMegaSena.Size = new System.Drawing.Size(128, 128);
            this.picbMegaSena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbMegaSena.TabIndex = 13;
            this.picbMegaSena.TabStop = false;
            this.picbMegaSena.Click += new System.EventHandler(this.picbMegaSena_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1040, 575);
            this.Controls.Add(this.lblMegaSena);
            this.Controls.Add(this.picbMegaSena);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.picbMoeda);
            this.Controls.Add(this.lblViagem);
            this.Controls.Add(this.picbViagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picbAgua);
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
            ((System.ComponentModel.ISupportInitialize)(this.picbAgua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbViagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMegaSena)).EndInit();
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
        private System.Windows.Forms.PictureBox picbAgua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblViagem;
        private System.Windows.Forms.PictureBox picbViagem;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.PictureBox picbMoeda;
        private System.Windows.Forms.Label lblMegaSena;
        private System.Windows.Forms.PictureBox picbMegaSena;
    }
}

