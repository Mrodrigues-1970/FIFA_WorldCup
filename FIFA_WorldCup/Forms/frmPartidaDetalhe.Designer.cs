namespace FIFA_WorldCup.Forms
{
    partial class frmPartidaDetalhe
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpHoraEvento = new System.Windows.Forms.DateTimePicker();
            this.imgTeamB = new System.Windows.Forms.PictureBox();
            this.imgTeamA = new System.Windows.Forms.PictureBox();
            this.chkDesempate = new System.Windows.Forms.CheckBox();
            this.grpDesempate = new System.Windows.Forms.GroupBox();
            this.lblSelecaoDesempateB = new System.Windows.Forms.Label();
            this.lblSelecaoDesempateA = new System.Windows.Forms.Label();
            this.lblTipoDesempate = new System.Windows.Forms.Label();
            this.ScoreDesempateB = new System.Windows.Forms.NumericUpDown();
            this.ScoreDesempateA = new System.Windows.Forms.NumericUpDown();
            this.ddlTipoDesempate = new System.Windows.Forms.ComboBox();
            this.ddlSelecaoB = new System.Windows.Forms.ComboBox();
            this.scoreB = new System.Windows.Forms.NumericUpDown();
            this.scoreA = new System.Windows.Forms.NumericUpDown();
            this.ddlSelecaoA = new System.Windows.Forms.ComboBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.dtpDataEvento = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.ddlLocal = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeamB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeamA)).BeginInit();
            this.grpDesempate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDesempateB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDesempateA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreA)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancelar.Location = new System.Drawing.Point(317, 614);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 19;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtpHoraEvento);
            this.groupBox1.Controls.Add(this.imgTeamB);
            this.groupBox1.Controls.Add(this.imgTeamA);
            this.groupBox1.Controls.Add(this.chkDesempate);
            this.groupBox1.Controls.Add(this.grpDesempate);
            this.groupBox1.Controls.Add(this.ddlSelecaoB);
            this.groupBox1.Controls.Add(this.scoreB);
            this.groupBox1.Controls.Add(this.scoreA);
            this.groupBox1.Controls.Add(this.ddlSelecaoA);
            this.groupBox1.Controls.Add(this.lblLocal);
            this.groupBox1.Controls.Add(this.lblGrupo);
            this.groupBox1.Controls.Add(this.txtGrupo);
            this.groupBox1.Controls.Add(this.dtpDataEvento);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.ddlLocal);
            this.groupBox1.Location = new System.Drawing.Point(44, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 482);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // dtpHoraEvento
            // 
            this.dtpHoraEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEvento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEvento.Location = new System.Drawing.Point(230, 32);
            this.dtpHoraEvento.Name = "dtpHoraEvento";
            this.dtpHoraEvento.Size = new System.Drawing.Size(96, 23);
            this.dtpHoraEvento.TabIndex = 27;
            // 
            // imgTeamB
            // 
            this.imgTeamB.Location = new System.Drawing.Point(637, 199);
            this.imgTeamB.Name = "imgTeamB";
            this.imgTeamB.Size = new System.Drawing.Size(200, 134);
            this.imgTeamB.TabIndex = 26;
            this.imgTeamB.TabStop = false;
            // 
            // imgTeamA
            // 
            this.imgTeamA.Location = new System.Drawing.Point(46, 199);
            this.imgTeamA.Name = "imgTeamA";
            this.imgTeamA.Size = new System.Drawing.Size(200, 134);
            this.imgTeamA.TabIndex = 25;
            this.imgTeamA.TabStop = false;
            // 
            // chkDesempate
            // 
            this.chkDesempate.AutoSize = true;
            this.chkDesempate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDesempate.Location = new System.Drawing.Point(391, 297);
            this.chkDesempate.Name = "chkDesempate";
            this.chkDesempate.Size = new System.Drawing.Size(103, 22);
            this.chkDesempate.TabIndex = 24;
            this.chkDesempate.Text = "Desempate";
            this.chkDesempate.UseVisualStyleBackColor = true;
            this.chkDesempate.Click += new System.EventHandler(this.chkDesempate_Click);
            // 
            // grpDesempate
            // 
            this.grpDesempate.Controls.Add(this.lblSelecaoDesempateB);
            this.grpDesempate.Controls.Add(this.lblSelecaoDesempateA);
            this.grpDesempate.Controls.Add(this.lblTipoDesempate);
            this.grpDesempate.Controls.Add(this.ScoreDesempateB);
            this.grpDesempate.Controls.Add(this.ScoreDesempateA);
            this.grpDesempate.Controls.Add(this.ddlTipoDesempate);
            this.grpDesempate.Enabled = false;
            this.grpDesempate.Location = new System.Drawing.Point(36, 350);
            this.grpDesempate.Name = "grpDesempate";
            this.grpDesempate.Size = new System.Drawing.Size(801, 105);
            this.grpDesempate.TabIndex = 23;
            this.grpDesempate.TabStop = false;
            this.grpDesempate.Text = "Desempate";
            // 
            // lblSelecaoDesempateB
            // 
            this.lblSelecaoDesempateB.AutoSize = true;
            this.lblSelecaoDesempateB.Location = new System.Drawing.Point(567, 29);
            this.lblSelecaoDesempateB.Name = "lblSelecaoDesempateB";
            this.lblSelecaoDesempateB.Size = new System.Drawing.Size(14, 13);
            this.lblSelecaoDesempateB.TabIndex = 26;
            this.lblSelecaoDesempateB.Text = "B";
            // 
            // lblSelecaoDesempateA
            // 
            this.lblSelecaoDesempateA.AutoSize = true;
            this.lblSelecaoDesempateA.Location = new System.Drawing.Point(392, 29);
            this.lblSelecaoDesempateA.Name = "lblSelecaoDesempateA";
            this.lblSelecaoDesempateA.Size = new System.Drawing.Size(14, 13);
            this.lblSelecaoDesempateA.TabIndex = 25;
            this.lblSelecaoDesempateA.Text = "A";
            // 
            // lblTipoDesempate
            // 
            this.lblTipoDesempate.AutoSize = true;
            this.lblTipoDesempate.Location = new System.Drawing.Point(92, 38);
            this.lblTipoDesempate.Name = "lblTipoDesempate";
            this.lblTipoDesempate.Size = new System.Drawing.Size(28, 13);
            this.lblTipoDesempate.TabIndex = 24;
            this.lblTipoDesempate.Text = "Tipo";
            // 
            // ScoreDesempateB
            // 
            this.ScoreDesempateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreDesempateB.Location = new System.Drawing.Point(570, 45);
            this.ScoreDesempateB.Name = "ScoreDesempateB";
            this.ScoreDesempateB.Size = new System.Drawing.Size(63, 30);
            this.ScoreDesempateB.TabIndex = 23;
            // 
            // ScoreDesempateA
            // 
            this.ScoreDesempateA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreDesempateA.Location = new System.Drawing.Point(395, 45);
            this.ScoreDesempateA.Name = "ScoreDesempateA";
            this.ScoreDesempateA.Size = new System.Drawing.Size(63, 30);
            this.ScoreDesempateA.TabIndex = 22;
            // 
            // ddlTipoDesempate
            // 
            this.ddlTipoDesempate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoDesempate.FormattingEnabled = true;
            this.ddlTipoDesempate.Location = new System.Drawing.Point(95, 54);
            this.ddlTipoDesempate.Name = "ddlTipoDesempate";
            this.ddlTipoDesempate.Size = new System.Drawing.Size(195, 21);
            this.ddlTipoDesempate.TabIndex = 1;
            // 
            // ddlSelecaoB
            // 
            this.ddlSelecaoB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSelecaoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSelecaoB.FormattingEnabled = true;
            this.ddlSelecaoB.Location = new System.Drawing.Point(557, 138);
            this.ddlSelecaoB.Name = "ddlSelecaoB";
            this.ddlSelecaoB.Size = new System.Drawing.Size(280, 26);
            this.ddlSelecaoB.TabIndex = 22;
            this.ddlSelecaoB.SelectedValueChanged += new System.EventHandler(this.ddlSelecaoB_SelectedValueChanged);
            // 
            // scoreB
            // 
            this.scoreB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreB.Location = new System.Drawing.Point(478, 138);
            this.scoreB.Name = "scoreB";
            this.scoreB.Size = new System.Drawing.Size(63, 30);
            this.scoreB.TabIndex = 21;
            // 
            // scoreA
            // 
            this.scoreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreA.Location = new System.Drawing.Point(345, 138);
            this.scoreA.Name = "scoreA";
            this.scoreA.Size = new System.Drawing.Size(60, 30);
            this.scoreA.TabIndex = 20;
            // 
            // ddlSelecaoA
            // 
            this.ddlSelecaoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSelecaoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSelecaoA.FormattingEnabled = true;
            this.ddlSelecaoA.Location = new System.Drawing.Point(46, 138);
            this.ddlSelecaoA.Name = "ddlSelecaoA";
            this.ddlSelecaoA.Size = new System.Drawing.Size(280, 26);
            this.ddlSelecaoA.TabIndex = 19;
            this.ddlSelecaoA.SelectedValueChanged += new System.EventHandler(this.ddlSelecaoA_SelectedValueChanged);
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(224, 94);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(33, 13);
            this.lblLocal.TabIndex = 18;
            this.lblLocal.Text = "Local";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(533, 43);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 17;
            this.lblGrupo.Text = "Grupo";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupo.Location = new System.Drawing.Point(585, 33);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.ReadOnly = true;
            this.txtGrupo.Size = new System.Drawing.Size(252, 24);
            this.txtGrupo.TabIndex = 16;
            // 
            // dtpDataEvento
            // 
            this.dtpDataEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEvento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEvento.Location = new System.Drawing.Point(89, 33);
            this.dtpDataEvento.Name = "dtpDataEvento";
            this.dtpDataEvento.Size = new System.Drawing.Size(118, 23);
            this.dtpDataEvento.TabIndex = 15;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(50, 39);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "Data";
            // 
            // ddlLocal
            // 
            this.ddlLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlLocal.FormattingEnabled = true;
            this.ddlLocal.Location = new System.Drawing.Point(263, 81);
            this.ddlLocal.Name = "ddlLocal";
            this.ddlLocal.Size = new System.Drawing.Size(497, 26);
            this.ddlLocal.TabIndex = 0;
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvar.Location = new System.Drawing.Point(160, 614);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 18;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(182, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 25);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Edição de Partida da Copa de ";
            // 
            // frmPartidaDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 687);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPartidaDetalhe";
            this.Text = "frmPartidaDetalhe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeamB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeamA)).EndInit();
            this.grpDesempate.ResumeLayout(false);
            this.grpDesempate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDesempateB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDesempateA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ddlLocal;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox ddlSelecaoA;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.DateTimePicker dtpDataEvento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox ddlSelecaoB;
        private System.Windows.Forms.NumericUpDown scoreB;
        private System.Windows.Forms.NumericUpDown scoreA;
        private System.Windows.Forms.CheckBox chkDesempate;
        private System.Windows.Forms.GroupBox grpDesempate;
        private System.Windows.Forms.Label lblTipoDesempate;
        private System.Windows.Forms.NumericUpDown ScoreDesempateB;
        private System.Windows.Forms.NumericUpDown ScoreDesempateA;
        private System.Windows.Forms.ComboBox ddlTipoDesempate;
        private System.Windows.Forms.Label lblSelecaoDesempateB;
        private System.Windows.Forms.Label lblSelecaoDesempateA;
        private System.Windows.Forms.PictureBox imgTeamA;
        private System.Windows.Forms.PictureBox imgTeamB;
        private System.Windows.Forms.DateTimePicker dtpHoraEvento;
    }
}