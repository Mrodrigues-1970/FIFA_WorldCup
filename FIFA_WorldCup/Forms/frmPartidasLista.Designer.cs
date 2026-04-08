namespace FIFA_WorldCup.Forms
{
    partial class frmPartidasLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartidasLista));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaisA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gols_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaisB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gols_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfederacaoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfederacaoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecao_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecao_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Competicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desempate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ordem_Treeview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnIncluir = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnGrupos = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(430, 75);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 25);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Lista de Partidas";
            // 
            // grdMain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Data,
            this.Estadio,
            this.NomePaisA,
            this.Gols_A,
            this.NomePaisB,
            this.Gols_B,
            this.ConfederacaoA,
            this.ConfederacaoB,
            this.Selecao_A,
            this.Selecao_B,
            this.GrupoID,
            this.Local,
            this.CopaNome,
            this.Competicao,
            this.Desempate,
            this.CopaID,
            this.Ordem_Treeview});
            this.grdMain.Location = new System.Drawing.Point(136, 186);
            this.grdMain.MultiSelect = false;
            this.grdMain.Name = "grdMain";
            this.grdMain.ReadOnly = true;
            this.grdMain.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdMain.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMain.Size = new System.Drawing.Size(740, 380);
            this.grdMain.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 80;
            // 
            // Estadio
            // 
            this.Estadio.DataPropertyName = "Estadio";
            this.Estadio.HeaderText = "Estádio";
            this.Estadio.Name = "Estadio";
            this.Estadio.ReadOnly = true;
            this.Estadio.Width = 180;
            // 
            // NomePaisA
            // 
            this.NomePaisA.DataPropertyName = "NomePaisA";
            this.NomePaisA.HeaderText = "Pais A";
            this.NomePaisA.Name = "NomePaisA";
            this.NomePaisA.ReadOnly = true;
            this.NomePaisA.Width = 130;
            // 
            // Gols_A
            // 
            this.Gols_A.DataPropertyName = "Gols_A";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Gols_A.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gols_A.HeaderText = "Gols A";
            this.Gols_A.Name = "Gols_A";
            this.Gols_A.ReadOnly = true;
            this.Gols_A.Width = 70;
            // 
            // NomePaisB
            // 
            this.NomePaisB.DataPropertyName = "NomePaisB";
            this.NomePaisB.HeaderText = "Pais B";
            this.NomePaisB.Name = "NomePaisB";
            this.NomePaisB.ReadOnly = true;
            this.NomePaisB.Width = 130;
            // 
            // Gols_B
            // 
            this.Gols_B.DataPropertyName = "Gols_B";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Gols_B.DefaultCellStyle = dataGridViewCellStyle3;
            this.Gols_B.HeaderText = "Gols B";
            this.Gols_B.Name = "Gols_B";
            this.Gols_B.ReadOnly = true;
            this.Gols_B.Width = 70;
            // 
            // ConfederacaoA
            // 
            this.ConfederacaoA.DataPropertyName = "ConfederacaoA";
            this.ConfederacaoA.HeaderText = "ConfederacaoA";
            this.ConfederacaoA.Name = "ConfederacaoA";
            this.ConfederacaoA.ReadOnly = true;
            this.ConfederacaoA.Visible = false;
            // 
            // ConfederacaoB
            // 
            this.ConfederacaoB.DataPropertyName = "ConfederacaoB";
            this.ConfederacaoB.HeaderText = "ConfederacaoB";
            this.ConfederacaoB.Name = "ConfederacaoB";
            this.ConfederacaoB.ReadOnly = true;
            this.ConfederacaoB.Visible = false;
            // 
            // Selecao_A
            // 
            this.Selecao_A.DataPropertyName = "SelecaoID_A";
            this.Selecao_A.HeaderText = "Selecao_A";
            this.Selecao_A.Name = "Selecao_A";
            this.Selecao_A.ReadOnly = true;
            this.Selecao_A.Visible = false;
            // 
            // Selecao_B
            // 
            this.Selecao_B.DataPropertyName = "SelecaoID_B";
            this.Selecao_B.HeaderText = "Selecao_B";
            this.Selecao_B.Name = "Selecao_B";
            this.Selecao_B.ReadOnly = true;
            this.Selecao_B.Visible = false;
            // 
            // GrupoID
            // 
            this.GrupoID.DataPropertyName = "GrupoID";
            this.GrupoID.HeaderText = "GrupoID";
            this.GrupoID.Name = "GrupoID";
            this.GrupoID.ReadOnly = true;
            this.GrupoID.Visible = false;
            // 
            // Local
            // 
            this.Local.DataPropertyName = "Local";
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.ReadOnly = true;
            this.Local.Visible = false;
            // 
            // CopaNome
            // 
            this.CopaNome.DataPropertyName = "CopaNome";
            this.CopaNome.HeaderText = "CopaNome";
            this.CopaNome.Name = "CopaNome";
            this.CopaNome.ReadOnly = true;
            this.CopaNome.Visible = false;
            // 
            // Competicao
            // 
            this.Competicao.DataPropertyName = "Competicao";
            this.Competicao.HeaderText = "Competicao";
            this.Competicao.Name = "Competicao";
            this.Competicao.ReadOnly = true;
            this.Competicao.Visible = false;
            // 
            // Desempate
            // 
            this.Desempate.DataPropertyName = "Desempate";
            this.Desempate.HeaderText = "Desempate";
            this.Desempate.Name = "Desempate";
            this.Desempate.ReadOnly = true;
            this.Desempate.Visible = false;
            // 
            // CopaID
            // 
            this.CopaID.DataPropertyName = "CopaID";
            this.CopaID.HeaderText = "CopaID";
            this.CopaID.Name = "CopaID";
            this.CopaID.ReadOnly = true;
            this.CopaID.Visible = false;
            // 
            // Ordem_Treeview
            // 
            this.Ordem_Treeview.DataPropertyName = "Ordem_Treeview";
            this.Ordem_Treeview.HeaderText = "Ordem_Treeview";
            this.Ordem_Treeview.Name = "Ordem_Treeview";
            this.Ordem_Treeview.ReadOnly = true;
            this.Ordem_Treeview.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIncluir,
            this.btnAlterar,
            this.btnGrupos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1049, 39);
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
            this.btnIncluir.Size = new System.Drawing.Size(36, 36);
            this.btnIncluir.Text = "btnIncluir";
            this.btnIncluir.ToolTipText = "Incluir";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(36, 36);
            this.btnAlterar.Text = "toolStripButton1";
            this.btnAlterar.ToolTipText = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnGrupos
            // 
            this.btnGrupos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGrupos.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupos.Image")));
            this.btnGrupos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGrupos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(36, 36);
            this.btnGrupos.Text = "toolStripButton1";
            this.btnGrupos.ToolTipText = "Grupos";
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // frmPartidasLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 685);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grdMain);
            this.Name = "frmPartidasLista";
            this.Text = "frmPartidasList";
            this.Shown += new System.EventHandler(this.frmPartidasLista_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaisA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gols_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaisB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gols_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfederacaoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfederacaoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selecao_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selecao_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desempate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem_Treeview;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnIncluir;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnGrupos;
    }
}