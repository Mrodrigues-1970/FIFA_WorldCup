namespace FIFA_WorldCup.Forms
{
    partial class frmCidadeDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCidadeDetalhe));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomePais = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNomeIngles = new System.Windows.Forms.Label();
            this.txtNomeIngles = new System.Windows.Forms.TextBox();
            this.picSalvar = new System.Windows.Forms.PictureBox();
            this.picCancelar = new System.Windows.Forms.PictureBox();
            this.lblCopiar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(366, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(245, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Detalhe  da Cidade";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(284, 277);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(412, 30);
            this.txtNome.TabIndex = 2;
            // 
            // lblNomePais
            // 
            this.lblNomePais.AutoSize = true;
            this.lblNomePais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePais.Location = new System.Drawing.Point(418, 202);
            this.lblNomePais.Name = "lblNomePais";
            this.lblNomePais.Size = new System.Drawing.Size(27, 25);
            this.lblNomePais.TabIndex = 3;
            this.lblNomePais.Text = "...";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(420, 180);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 17);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "País:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(281, 257);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // lblNomeIngles
            // 
            this.lblNomeIngles.AutoSize = true;
            this.lblNomeIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeIngles.Location = new System.Drawing.Point(281, 353);
            this.lblNomeIngles.Name = "lblNomeIngles";
            this.lblNomeIngles.Size = new System.Drawing.Size(113, 17);
            this.lblNomeIngles.TabIndex = 7;
            this.lblNomeIngles.Text = "Nome em Inglês:";
            // 
            // txtNomeIngles
            // 
            this.txtNomeIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeIngles.Location = new System.Drawing.Point(284, 373);
            this.txtNomeIngles.Name = "txtNomeIngles";
            this.txtNomeIngles.Size = new System.Drawing.Size(412, 30);
            this.txtNomeIngles.TabIndex = 6;
            // 
            // picSalvar
            // 
            this.picSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picSalvar.BackColor = System.Drawing.Color.Transparent;
            this.picSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSalvar.Image = ((System.Drawing.Image)(resources.GetObject("picSalvar.Image")));
            this.picSalvar.Location = new System.Drawing.Point(284, 513);
            this.picSalvar.Name = "picSalvar";
            this.picSalvar.Size = new System.Drawing.Size(64, 64);
            this.picSalvar.TabIndex = 8;
            this.picSalvar.TabStop = false;
            this.picSalvar.Click += new System.EventHandler(this.picSalvar_Click);
            // 
            // picCancelar
            // 
            this.picCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picCancelar.BackColor = System.Drawing.Color.Transparent;
            this.picCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCancelar.Image = ((System.Drawing.Image)(resources.GetObject("picCancelar.Image")));
            this.picCancelar.Location = new System.Drawing.Point(632, 513);
            this.picCancelar.Name = "picCancelar";
            this.picCancelar.Size = new System.Drawing.Size(64, 64);
            this.picCancelar.TabIndex = 9;
            this.picCancelar.TabStop = false;
            this.picCancelar.Click += new System.EventHandler(this.picCancelar_Click);
            // 
            // lblCopiar
            // 
            this.lblCopiar.AutoSize = true;
            this.lblCopiar.BackColor = System.Drawing.Color.Transparent;
            this.lblCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopiar.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopiar.Location = new System.Drawing.Point(489, 320);
            this.lblCopiar.Name = "lblCopiar";
            this.lblCopiar.Size = new System.Drawing.Size(35, 38);
            this.lblCopiar.TabIndex = 10;
            this.lblCopiar.Text = "=";
            this.lblCopiar.Click += new System.EventHandler(this.lblCopiar_Click);
            // 
            // frmCidadeDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 707);
            this.Controls.Add(this.lblCopiar);
            this.Controls.Add(this.picCancelar);
            this.Controls.Add(this.picSalvar);
            this.Controls.Add(this.lblNomeIngles);
            this.Controls.Add(this.txtNomeIngles);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblNomePais);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCidadeDetalhe";
            this.Text = "Detalhe da Cidade";
            ((System.ComponentModel.ISupportInitialize)(this.picSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomePais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomeIngles;
        private System.Windows.Forms.TextBox txtNomeIngles;
        private System.Windows.Forms.PictureBox picSalvar;
        private System.Windows.Forms.PictureBox picCancelar;
        private System.Windows.Forms.Label lblCopiar;
    }
}