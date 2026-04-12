namespace FIFA_WorldCup.Forms
{
    partial class frmPaisLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaisLista));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Ingles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Confederacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bandeira = new System.Windows.Forms.DataGridViewImageColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboConfederacao = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnIncluir = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnLigacoes = new System.Windows.Forms.ToolStripButton();
            this.btnEstatisticas = new System.Windows.Forms.ToolStripButton();
            this.btnPerformance = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(389, 92);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(144, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Lista de Países";
            // 
            // grdMain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NomeRank,
            this.Nome,
            this.Nome_Ingles,
            this.Ativo,
            this.Confederacao,
            this.Bandeira,
            this.Rank});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMain.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdMain.Location = new System.Drawing.Point(215, 150);
            this.grdMain.Name = "grdMain";
            this.grdMain.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdMain.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdMain.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdMain.RowTemplate.Height = 25;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMain.Size = new System.Drawing.Size(502, 475);
            this.grdMain.TabIndex = 4;
            this.grdMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdMain_DataBindingComplete);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // NomeRank
            // 
            this.NomeRank.DataPropertyName = "NomeRank";
            this.NomeRank.HeaderText = "Nome (Rank)";
            this.NomeRank.Name = "NomeRank";
            this.NomeRank.ReadOnly = true;
            this.NomeRank.Width = 170;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Visible = false;
            this.Nome.Width = 200;
            // 
            // Nome_Ingles
            // 
            this.Nome_Ingles.DataPropertyName = "Nome_Ingles";
            this.Nome_Ingles.HeaderText = "Inglês";
            this.Nome_Ingles.Name = "Nome_Ingles";
            this.Nome_Ingles.ReadOnly = true;
            this.Nome_Ingles.Width = 170;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Width = 50;
            // 
            // Confederacao
            // 
            this.Confederacao.DataPropertyName = "Confederacao";
            this.Confederacao.HeaderText = "Confederação";
            this.Confederacao.Name = "Confederacao";
            this.Confederacao.ReadOnly = true;
            this.Confederacao.Visible = false;
            this.Confederacao.Width = 80;
            // 
            // Bandeira
            // 
            this.Bandeira.HeaderText = "";
            this.Bandeira.Name = "Bandeira";
            this.Bandeira.ReadOnly = true;
            this.Bandeira.Width = 50;
            // 
            // Rank
            // 
            this.Rank.DataPropertyName = "Rank";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Rank.DefaultCellStyle = dataGridViewCellStyle3;
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            this.Rank.Visible = false;
            this.Rank.Width = 50;
            // 
            // cboConfederacao
            // 
            this.cboConfederacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboConfederacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConfederacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConfederacao.FormattingEnabled = true;
            this.cboConfederacao.Location = new System.Drawing.Point(771, 150);
            this.cboConfederacao.Name = "cboConfederacao";
            this.cboConfederacao.Size = new System.Drawing.Size(101, 24);
            this.cboConfederacao.TabIndex = 6;
            this.cboConfederacao.SelectedIndexChanged += new System.EventHandler(this.cboConfederacao_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIncluir,
            this.btnAlterar,
            this.btnLigacoes,
            this.btnEstatisticas,
            this.btnPerformance});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(976, 41);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnIncluir
            // 
            this.btnIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(36, 38);
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(36, 38);
            this.btnAlterar.Text = "toolStripButton1";
            this.btnAlterar.ToolTipText = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLigacoes
            // 
            this.btnLigacoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLigacoes.Image = ((System.Drawing.Image)(resources.GetObject("btnLigacoes.Image")));
            this.btnLigacoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLigacoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLigacoes.Name = "btnLigacoes";
            this.btnLigacoes.Size = new System.Drawing.Size(36, 38);
            this.btnLigacoes.Text = "toolStripButton1";
            this.btnLigacoes.ToolTipText = "Ligações";
            this.btnLigacoes.Click += new System.EventHandler(this.btnLigacoes_Click);
            // 
            // btnEstatisticas
            // 
            this.btnEstatisticas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEstatisticas.Image = ((System.Drawing.Image)(resources.GetObject("btnEstatisticas.Image")));
            this.btnEstatisticas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEstatisticas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEstatisticas.Name = "btnEstatisticas";
            this.btnEstatisticas.Size = new System.Drawing.Size(36, 38);
            this.btnEstatisticas.Text = "toolStripButton1";
            this.btnEstatisticas.ToolTipText = "Estatísticas";
            this.btnEstatisticas.Click += new System.EventHandler(this.btnEstatisticas_Click);
            // 
            // btnPerformance
            // 
            this.btnPerformance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPerformance.Image = ((System.Drawing.Image)(resources.GetObject("btnPerformance.Image")));
            this.btnPerformance.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPerformance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Size = new System.Drawing.Size(36, 38);
            this.btnPerformance.Text = "toolStripButton1";
            this.btnPerformance.ToolTipText = "Performance";
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // frmPaisLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 696);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cboConfederacao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grdMain);
            this.Name = "frmPaisLista";
            this.Text = "Lista de Países";
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdMain;
        private System.Windows.Forms.ComboBox cboConfederacao;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnIncluir;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnLigacoes;
        private System.Windows.Forms.ToolStripButton btnEstatisticas;
        private System.Windows.Forms.ToolStripButton btnPerformance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Ingles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Confederacao;
        private System.Windows.Forms.DataGridViewImageColumn Bandeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
    }
}