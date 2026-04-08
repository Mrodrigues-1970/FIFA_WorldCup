namespace FIFA_WorldCup.Forms
{
    partial class frmVagasLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.CopaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confederacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VagasDiretas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VagasRepescagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VagasTotais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCandidatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidatosPorVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(245, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lista de Vagas";
            // 
            // grdMain
            // 
            this.grdMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CopaID,
            this.Confederacao,
            this.VagasDiretas,
            this.VagasRepescagem,
            this.VagasTotais,
            this.TotalCandidatos,
            this.CandidatosPorVaga});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMain.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdMain.Location = new System.Drawing.Point(80, 126);
            this.grdMain.Name = "grdMain";
            this.grdMain.ReadOnly = true;
            this.grdMain.RowTemplate.Height = 25;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMain.Size = new System.Drawing.Size(863, 336);
            this.grdMain.TabIndex = 1;
            // 
            // btIncluir
            // 
            this.btIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btIncluir.Location = new System.Drawing.Point(141, 551);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.TabIndex = 2;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAlterar.Location = new System.Drawing.Point(359, 551);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // CopaID
            // 
            this.CopaID.DataPropertyName = "CopaID";
            this.CopaID.HeaderText = "CopaID";
            this.CopaID.Name = "CopaID";
            this.CopaID.ReadOnly = true;
            this.CopaID.Visible = false;
            // 
            // Confederacao
            // 
            this.Confederacao.DataPropertyName = "Confederacao";
            this.Confederacao.HeaderText = "Confederação";
            this.Confederacao.Name = "Confederacao";
            this.Confederacao.ReadOnly = true;
            this.Confederacao.Width = 150;
            // 
            // VagasDiretas
            // 
            this.VagasDiretas.DataPropertyName = "VagasDiretas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VagasDiretas.DefaultCellStyle = dataGridViewCellStyle2;
            this.VagasDiretas.HeaderText = "Vagas Diretas";
            this.VagasDiretas.Name = "VagasDiretas";
            this.VagasDiretas.ReadOnly = true;
            // 
            // VagasRepescagem
            // 
            this.VagasRepescagem.DataPropertyName = "VagasRepescagem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VagasRepescagem.DefaultCellStyle = dataGridViewCellStyle3;
            this.VagasRepescagem.HeaderText = "Vagas Repescagem";
            this.VagasRepescagem.Name = "VagasRepescagem";
            this.VagasRepescagem.ReadOnly = true;
            this.VagasRepescagem.Width = 130;
            // 
            // VagasTotais
            // 
            this.VagasTotais.DataPropertyName = "VagasTotais";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VagasTotais.DefaultCellStyle = dataGridViewCellStyle4;
            this.VagasTotais.HeaderText = "Vagas Totais";
            this.VagasTotais.Name = "VagasTotais";
            this.VagasTotais.ReadOnly = true;
            // 
            // TotalCandidatos
            // 
            this.TotalCandidatos.DataPropertyName = "TotalCandidatos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TotalCandidatos.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalCandidatos.HeaderText = "Total Candidatos";
            this.TotalCandidatos.Name = "TotalCandidatos";
            this.TotalCandidatos.ReadOnly = true;
            this.TotalCandidatos.Width = 130;
            // 
            // CandidatosPorVaga
            // 
            this.CandidatosPorVaga.DataPropertyName = "CandidatosPorVaga";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.CandidatosPorVaga.DefaultCellStyle = dataGridViewCellStyle6;
            this.CandidatosPorVaga.HeaderText = "Candidatos / Vaga";
            this.CandidatosPorVaga.Name = "CandidatosPorVaga";
            this.CandidatosPorVaga.ReadOnly = true;
            this.CandidatosPorVaga.Width = 130;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(627, 551);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // frmVagasLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 690);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.grdMain);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmVagasLista";
            this.Text = "Lista de Vagas";
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdMain;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Confederacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn VagasDiretas;
        private System.Windows.Forms.DataGridViewTextBoxColumn VagasRepescagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn VagasTotais;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCandidatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidatosPorVaga;
        private System.Windows.Forms.Button btCancelar;
    }
}