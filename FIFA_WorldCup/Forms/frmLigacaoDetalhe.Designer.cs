namespace FIFA_WorldCup.Forms
{
    partial class frmLigacaoDetalhe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPaisesFilhos = new System.Windows.Forms.ListBox();
            this.ddlTipoLigacao = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomePais = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstPaisesFilhos);
            this.groupBox1.Controls.Add(this.ddlTipoLigacao);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtNomePais);
            this.groupBox1.Location = new System.Drawing.Point(39, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 521);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lstPaisesFilhos
            // 
            this.lstPaisesFilhos.FormattingEnabled = true;
            this.lstPaisesFilhos.Location = new System.Drawing.Point(201, 160);
            this.lstPaisesFilhos.Name = "lstPaisesFilhos";
            this.lstPaisesFilhos.Size = new System.Drawing.Size(405, 329);
            this.lstPaisesFilhos.TabIndex = 13;
            // 
            // ddlTipoLigacao
            // 
            this.ddlTipoLigacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoLigacao.FormattingEnabled = true;
            this.ddlTipoLigacao.Location = new System.Drawing.Point(201, 89);
            this.ddlTipoLigacao.Name = "ddlTipoLigacao";
            this.ddlTipoLigacao.Size = new System.Drawing.Size(241, 21);
            this.ddlTipoLigacao.TabIndex = 12;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(140, 97);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(140, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(27, 13);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Pais";
            // 
            // txtNomePais
            // 
            this.txtNomePais.Location = new System.Drawing.Point(201, 41);
            this.txtNomePais.Name = "txtNomePais";
            this.txtNomePais.ReadOnly = true;
            this.txtNomePais.Size = new System.Drawing.Size(320, 20);
            this.txtNomePais.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(235, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(173, 25);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Edição de Ligação";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(406, 610);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(182, 610);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 12;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // frmLigacaoDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 685);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Name = "frmLigacaoDetalhe";
            this.Text = "frmLigacaoDetalhe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomePais;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ComboBox ddlTipoLigacao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ListBox lstPaisesFilhos;
    }
}