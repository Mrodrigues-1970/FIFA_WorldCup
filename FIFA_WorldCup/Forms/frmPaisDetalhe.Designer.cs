namespace FIFA_WorldCup.Forms
{
    partial class frmPaisDetalhe
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgConfederacao = new System.Windows.Forms.PictureBox();
            this.imgBandeira = new System.Windows.Forms.PictureBox();
            this.lblNomeIngles = new System.Windows.Forms.Label();
            this.txtNomeIngles = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.lblNomePortugues = new System.Windows.Forms.Label();
            this.txtNomePortugues = new System.Windows.Forms.TextBox();
            this.lblConfederacao = new System.Windows.Forms.Label();
            this.cboConfederacao = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lblRank = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfederacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBandeira)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(234, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Edição de País";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRank);
            this.groupBox1.Controls.Add(this.lblRank);
            this.groupBox1.Controls.Add(this.imgConfederacao);
            this.groupBox1.Controls.Add(this.imgBandeira);
            this.groupBox1.Controls.Add(this.lblNomeIngles);
            this.groupBox1.Controls.Add(this.txtNomeIngles);
            this.groupBox1.Controls.Add(this.chkAtivo);
            this.groupBox1.Controls.Add(this.lblNomePortugues);
            this.groupBox1.Controls.Add(this.txtNomePortugues);
            this.groupBox1.Controls.Add(this.lblConfederacao);
            this.groupBox1.Controls.Add(this.cboConfederacao);
            this.groupBox1.Location = new System.Drawing.Point(38, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 521);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // imgConfederacao
            // 
            this.imgConfederacao.Location = new System.Drawing.Point(638, 223);
            this.imgConfederacao.Name = "imgConfederacao";
            this.imgConfederacao.Size = new System.Drawing.Size(200, 200);
            this.imgConfederacao.TabIndex = 16;
            this.imgConfederacao.TabStop = false;
            // 
            // imgBandeira
            // 
            this.imgBandeira.Location = new System.Drawing.Point(638, 52);
            this.imgBandeira.Name = "imgBandeira";
            this.imgBandeira.Size = new System.Drawing.Size(200, 134);
            this.imgBandeira.TabIndex = 15;
            this.imgBandeira.TabStop = false;
            // 
            // lblNomeIngles
            // 
            this.lblNomeIngles.AutoSize = true;
            this.lblNomeIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeIngles.Location = new System.Drawing.Point(58, 227);
            this.lblNomeIngles.Name = "lblNomeIngles";
            this.lblNomeIngles.Size = new System.Drawing.Size(116, 18);
            this.lblNomeIngles.TabIndex = 14;
            this.lblNomeIngles.Text = "Nome em Inglês";
            // 
            // txtNomeIngles
            // 
            this.txtNomeIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeIngles.Location = new System.Drawing.Point(222, 221);
            this.txtNomeIngles.Name = "txtNomeIngles";
            this.txtNomeIngles.Size = new System.Drawing.Size(320, 24);
            this.txtNomeIngles.TabIndex = 3;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.Location = new System.Drawing.Point(222, 424);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(59, 22);
            this.chkAtivo.TabIndex = 4;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lblNomePortugues
            // 
            this.lblNomePortugues.AutoSize = true;
            this.lblNomePortugues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePortugues.Location = new System.Drawing.Point(28, 155);
            this.lblNomePortugues.Name = "lblNomePortugues";
            this.lblNomePortugues.Size = new System.Drawing.Size(146, 18);
            this.lblNomePortugues.TabIndex = 10;
            this.lblNomePortugues.Text = "Nome em Português";
            // 
            // txtNomePortugues
            // 
            this.txtNomePortugues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePortugues.Location = new System.Drawing.Point(222, 149);
            this.txtNomePortugues.Name = "txtNomePortugues";
            this.txtNomePortugues.Size = new System.Drawing.Size(320, 24);
            this.txtNomePortugues.TabIndex = 2;
            // 
            // lblConfederacao
            // 
            this.lblConfederacao.AutoSize = true;
            this.lblConfederacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfederacao.Location = new System.Drawing.Point(72, 83);
            this.lblConfederacao.Name = "lblConfederacao";
            this.lblConfederacao.Size = new System.Drawing.Size(102, 18);
            this.lblConfederacao.TabIndex = 8;
            this.lblConfederacao.Text = "Confederação";
            // 
            // cboConfederacao
            // 
            this.cboConfederacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConfederacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConfederacao.FormattingEnabled = true;
            this.cboConfederacao.Location = new System.Drawing.Point(222, 75);
            this.cboConfederacao.Name = "cboConfederacao";
            this.cboConfederacao.Size = new System.Drawing.Size(199, 26);
            this.cboConfederacao.TabIndex = 1;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(181, 615);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 8;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(405, 615);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(127, 299);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(47, 18);
            this.lblRank.TabIndex = 17;
            this.lblRank.Text = "Rank:";
            // 
            // txtRank
            // 
            this.txtRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRank.Location = new System.Drawing.Point(222, 293);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(104, 24);
            this.txtRank.TabIndex = 18;
            // 
            // frmPaisDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 694);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPaisDetalhe";
            this.Text = "frmPaisDetalhe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfederacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBandeira)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label lblNomePortugues;
        private System.Windows.Forms.TextBox txtNomePortugues;
        private System.Windows.Forms.Label lblConfederacao;
        private System.Windows.Forms.ComboBox cboConfederacao;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lblNomeIngles;
        private System.Windows.Forms.TextBox txtNomeIngles;
        private System.Windows.Forms.PictureBox imgBandeira;
        private System.Windows.Forms.PictureBox imgConfederacao;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.Label lblRank;
    }
}