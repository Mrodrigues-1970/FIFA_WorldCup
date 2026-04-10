namespace FIFA_WorldCup.Forms
{
    partial class frmGrupoLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupoLista));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COPA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnIncluir = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnPartidas = new System.Windows.Forms.ToolStripButton();
            this.btnListaCopas = new System.Windows.Forms.ToolStripButton();
            this.btDefinirPosicao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(391, 78);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(149, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Lista de Grupos";
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
            this.Nome,
            this.TipoFaseID,
            this.COPA_ID});
            this.grdMain.Location = new System.Drawing.Point(318, 146);
            this.grdMain.MultiSelect = false;
            this.grdMain.Name = "grdMain";
            this.grdMain.ReadOnly = true;
            this.grdMain.RowHeadersVisible = false;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMain.Size = new System.Drawing.Size(291, 414);
            this.grdMain.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // TipoFaseID
            // 
            this.TipoFaseID.DataPropertyName = "TipoFaseID";
            this.TipoFaseID.HeaderText = "TipoFaseID";
            this.TipoFaseID.Name = "TipoFaseID";
            this.TipoFaseID.ReadOnly = true;
            this.TipoFaseID.Width = 5;
            // 
            // COPA_ID
            // 
            this.COPA_ID.DataPropertyName = "CopaID";
            this.COPA_ID.HeaderText = "CopaID";
            this.COPA_ID.Name = "COPA_ID";
            this.COPA_ID.ReadOnly = true;
            this.COPA_ID.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIncluir,
            this.btnAlterar,
            this.btnPartidas,
            this.btnListaCopas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(971, 39);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(36, 36);
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
            this.btnAlterar.Size = new System.Drawing.Size(36, 36);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPartidas
            // 
            this.btnPartidas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPartidas.Image = ((System.Drawing.Image)(resources.GetObject("btnPartidas.Image")));
            this.btnPartidas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPartidas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(36, 36);
            this.btnPartidas.Text = "Partidas";
            this.btnPartidas.Click += new System.EventHandler(this.btnPartidas_Click);
            // 
            // btnListaCopas
            // 
            this.btnListaCopas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnListaCopas.Image = ((System.Drawing.Image)(resources.GetObject("btnListaCopas.Image")));
            this.btnListaCopas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListaCopas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListaCopas.Name = "btnListaCopas";
            this.btnListaCopas.Size = new System.Drawing.Size(28, 36);
            this.btnListaCopas.Text = "Lista de Copas";
            this.btnListaCopas.Click += new System.EventHandler(this.btnListaCopas_Click);
            // 
            // btDefinirPosicao
            // 
            this.btDefinirPosicao.Location = new System.Drawing.Point(396, 607);
            this.btDefinirPosicao.Name = "btDefinirPosicao";
            this.btDefinirPosicao.Size = new System.Drawing.Size(159, 23);
            this.btDefinirPosicao.TabIndex = 11;
            this.btDefinirPosicao.Text = "Posições no Grupo";
            this.btDefinirPosicao.UseVisualStyleBackColor = true;
            this.btDefinirPosicao.Click += new System.EventHandler(this.btDefinirPosicao_Click);
            // 
            // frmGrupoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 707);
            this.Controls.Add(this.btDefinirPosicao);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grdMain);
            this.Name = "frmGrupoLista";
            this.Text = "Lista de Grupos";
            this.Shown += new System.EventHandler(this.frmGrupoLista_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnIncluir;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnPartidas;
        private System.Windows.Forms.ToolStripButton btnListaCopas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COPA_ID;
        private System.Windows.Forms.Button btDefinirPosicao;
    }
}