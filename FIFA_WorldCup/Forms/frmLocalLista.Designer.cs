namespace FIFA_WorldCup.Forms
{
    partial class frmLocalLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalLista));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copa_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Ingles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confederacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadio_Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnIncluir = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnListaCopas = new System.Windows.Forms.ToolStripButton();
            this.btnGrupos = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(419, 53);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 25);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Lista de Locais";
            // 
            // grdMain
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Copa_ID,
            this.Nome_Ingles,
            this.Confederacao,
            this.Estadio_Cidade});
            this.grdMain.Location = new System.Drawing.Point(134, 107);
            this.grdMain.Name = "grdMain";
            this.grdMain.ReadOnly = true;
            this.grdMain.RowHeadersVisible = false;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMain.Size = new System.Drawing.Size(727, 339);
            this.grdMain.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Copa_ID
            // 
            this.Copa_ID.DataPropertyName = "CopaID";
            this.Copa_ID.HeaderText = "Copa ID";
            this.Copa_ID.Name = "Copa_ID";
            this.Copa_ID.ReadOnly = true;
            this.Copa_ID.Width = 80;
            // 
            // Nome_Ingles
            // 
            this.Nome_Ingles.DataPropertyName = "Estadio";
            this.Nome_Ingles.HeaderText = "Estádio";
            this.Nome_Ingles.Name = "Nome_Ingles";
            this.Nome_Ingles.ReadOnly = true;
            this.Nome_Ingles.Width = 300;
            // 
            // Confederacao
            // 
            this.Confederacao.DataPropertyName = "Cidade";
            this.Confederacao.HeaderText = "Cidade";
            this.Confederacao.Name = "Confederacao";
            this.Confederacao.ReadOnly = true;
            this.Confederacao.Width = 300;
            // 
            // Estadio_Cidade
            // 
            this.Estadio_Cidade.DataPropertyName = "Estadio_Cidade";
            this.Estadio_Cidade.HeaderText = "Estadio_Cidade";
            this.Estadio_Cidade.Name = "Estadio_Cidade";
            this.Estadio_Cidade.ReadOnly = true;
            this.Estadio_Cidade.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIncluir,
            this.btnAlterar,
            this.btnListaCopas,
            this.btnGrupos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1009, 39);
            this.toolStrip1.TabIndex = 15;
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
            // btnGrupos
            // 
            this.btnGrupos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGrupos.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupos.Image")));
            this.btnGrupos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGrupos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(36, 36);
            this.btnGrupos.Text = "Grupos";
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // frmLocalLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 606);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grdMain);
            this.Name = "frmLocalLista";
            this.Text = "frmLocalLista";
            this.Shown += new System.EventHandler(this.frmLocalLista_Shown);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Copa_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Ingles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Confederacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadio_Cidade;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnIncluir;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnListaCopas;
        private System.Windows.Forms.ToolStripButton btnGrupos;
    }
}