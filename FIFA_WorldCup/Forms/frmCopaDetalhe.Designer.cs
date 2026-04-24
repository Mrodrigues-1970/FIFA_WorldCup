namespace FIFA_WorldCup.Forms
{
    partial class frmCopaDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCopaDetalhe));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNomeCopa = new System.Windows.Forms.TextBox();
            this.txtAnoCopa = new System.Windows.Forms.NumericUpDown();
            this.txtMascote = new System.Windows.Forms.TextBox();
            this.cboTipoCopa = new System.Windows.Forms.ComboBox();
            this.dataInicial = new System.Windows.Forms.DateTimePicker();
            this.dataFinal = new System.Windows.Forms.DateTimePicker();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblNomeCopa = new System.Windows.Forms.Label();
            this.lblAnoCopa = new System.Windows.Forms.Label();
            this.lblMascote = new System.Windows.Forms.Label();
            this.lblTipoCopa = new System.Windows.Forms.Label();
            this.lbldataInicial = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblStatusCopa = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnoCopa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Green;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(382, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(259, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Copa do Mundo";
            // 
            // txtNomeCopa
            // 
            this.txtNomeCopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCopa.Location = new System.Drawing.Point(257, 125);
            this.txtNomeCopa.Name = "txtNomeCopa";
            this.txtNomeCopa.Size = new System.Drawing.Size(515, 30);
            this.txtNomeCopa.TabIndex = 1;
            this.txtNomeCopa.Text = "Copa do Mundo";
            // 
            // txtAnoCopa
            // 
            this.txtAnoCopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoCopa.Location = new System.Drawing.Point(257, 228);
            this.txtAnoCopa.Maximum = new decimal(new int[] {
            2150,
            0,
            0,
            0});
            this.txtAnoCopa.Minimum = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            this.txtAnoCopa.Name = "txtAnoCopa";
            this.txtAnoCopa.Size = new System.Drawing.Size(120, 30);
            this.txtAnoCopa.TabIndex = 2;
            this.txtAnoCopa.Value = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            // 
            // txtMascote
            // 
            this.txtMascote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMascote.Location = new System.Drawing.Point(442, 227);
            this.txtMascote.Name = "txtMascote";
            this.txtMascote.Size = new System.Drawing.Size(330, 30);
            this.txtMascote.TabIndex = 3;
            this.txtMascote.Text = "Fuleko";
            // 
            // cboTipoCopa
            // 
            this.cboTipoCopa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoCopa.FormattingEnabled = true;
            this.cboTipoCopa.Location = new System.Drawing.Point(325, 328);
            this.cboTipoCopa.Name = "cboTipoCopa";
            this.cboTipoCopa.Size = new System.Drawing.Size(373, 33);
            this.cboTipoCopa.TabIndex = 4;
            // 
            // dataInicial
            // 
            this.dataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicial.Location = new System.Drawing.Point(325, 413);
            this.dataInicial.Name = "dataInicial";
            this.dataInicial.Size = new System.Drawing.Size(156, 30);
            this.dataInicial.TabIndex = 5;
            // 
            // dataFinal
            // 
            this.dataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFinal.Location = new System.Drawing.Point(542, 413);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.Size = new System.Drawing.Size(156, 30);
            this.dataFinal.TabIndex = 6;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(442, 488);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(156, 33);
            this.cboStatus.TabIndex = 7;
            // 
            // lblNomeCopa
            // 
            this.lblNomeCopa.AutoSize = true;
            this.lblNomeCopa.BackColor = System.Drawing.Color.Green;
            this.lblNomeCopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCopa.ForeColor = System.Drawing.Color.White;
            this.lblNomeCopa.Location = new System.Drawing.Point(254, 93);
            this.lblNomeCopa.Name = "lblNomeCopa";
            this.lblNomeCopa.Size = new System.Drawing.Size(102, 17);
            this.lblNomeCopa.TabIndex = 8;
            this.lblNomeCopa.Text = "Nome da Copa";
            // 
            // lblAnoCopa
            // 
            this.lblAnoCopa.AutoSize = true;
            this.lblAnoCopa.BackColor = System.Drawing.Color.Green;
            this.lblAnoCopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoCopa.ForeColor = System.Drawing.Color.White;
            this.lblAnoCopa.Location = new System.Drawing.Point(254, 198);
            this.lblAnoCopa.Name = "lblAnoCopa";
            this.lblAnoCopa.Size = new System.Drawing.Size(33, 17);
            this.lblAnoCopa.TabIndex = 9;
            this.lblAnoCopa.Text = "Ano";
            // 
            // lblMascote
            // 
            this.lblMascote.AutoSize = true;
            this.lblMascote.BackColor = System.Drawing.Color.Green;
            this.lblMascote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascote.ForeColor = System.Drawing.Color.White;
            this.lblMascote.Location = new System.Drawing.Point(439, 198);
            this.lblMascote.Name = "lblMascote";
            this.lblMascote.Size = new System.Drawing.Size(61, 17);
            this.lblMascote.TabIndex = 10;
            this.lblMascote.Text = "Mascote";
            // 
            // lblTipoCopa
            // 
            this.lblTipoCopa.AutoSize = true;
            this.lblTipoCopa.BackColor = System.Drawing.Color.Green;
            this.lblTipoCopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCopa.ForeColor = System.Drawing.Color.White;
            this.lblTipoCopa.Location = new System.Drawing.Point(322, 296);
            this.lblTipoCopa.Name = "lblTipoCopa";
            this.lblTipoCopa.Size = new System.Drawing.Size(93, 17);
            this.lblTipoCopa.TabIndex = 11;
            this.lblTipoCopa.Text = "Tipo de Copa";
            // 
            // lbldataInicial
            // 
            this.lbldataInicial.AutoSize = true;
            this.lbldataInicial.BackColor = System.Drawing.Color.Green;
            this.lbldataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldataInicial.ForeColor = System.Drawing.Color.White;
            this.lbldataInicial.Location = new System.Drawing.Point(322, 385);
            this.lbldataInicial.Name = "lbldataInicial";
            this.lbldataInicial.Size = new System.Drawing.Size(77, 17);
            this.lbldataInicial.TabIndex = 12;
            this.lbldataInicial.Text = "Data Inicial";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.BackColor = System.Drawing.Color.Green;
            this.lblDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.ForeColor = System.Drawing.Color.White;
            this.lblDataFinal.Location = new System.Drawing.Point(540, 385);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(72, 17);
            this.lblDataFinal.TabIndex = 13;
            this.lblDataFinal.Text = "Data Final";
            // 
            // lblStatusCopa
            // 
            this.lblStatusCopa.AutoSize = true;
            this.lblStatusCopa.BackColor = System.Drawing.Color.Green;
            this.lblStatusCopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCopa.ForeColor = System.Drawing.Color.White;
            this.lblStatusCopa.Location = new System.Drawing.Point(439, 468);
            this.lblStatusCopa.Name = "lblStatusCopa";
            this.lblStatusCopa.Size = new System.Drawing.Size(105, 17);
            this.lblStatusCopa.TabIndex = 14;
            this.lblStatusCopa.Text = "Status da Copa";
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvar.Location = new System.Drawing.Point(324, 623);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 15;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancelar.Location = new System.Drawing.Point(622, 623);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // frmCopaDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 700);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lblStatusCopa);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lbldataInicial);
            this.Controls.Add(this.lblTipoCopa);
            this.Controls.Add(this.lblMascote);
            this.Controls.Add(this.lblAnoCopa);
            this.Controls.Add(this.lblNomeCopa);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.dataFinal);
            this.Controls.Add(this.dataInicial);
            this.Controls.Add(this.cboTipoCopa);
            this.Controls.Add(this.txtMascote);
            this.Controls.Add(this.txtAnoCopa);
            this.Controls.Add(this.txtNomeCopa);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCopaDetalhe";
            this.Text = "Detalhe de Copa";
            ((System.ComponentModel.ISupportInitialize)(this.txtAnoCopa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNomeCopa;
        private System.Windows.Forms.NumericUpDown txtAnoCopa;
        private System.Windows.Forms.TextBox txtMascote;
        private System.Windows.Forms.ComboBox cboTipoCopa;
        private System.Windows.Forms.DateTimePicker dataInicial;
        private System.Windows.Forms.DateTimePicker dataFinal;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblNomeCopa;
        private System.Windows.Forms.Label lblAnoCopa;
        private System.Windows.Forms.Label lblMascote;
        private System.Windows.Forms.Label lblTipoCopa;
        private System.Windows.Forms.Label lbldataInicial;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblStatusCopa;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
    }
}