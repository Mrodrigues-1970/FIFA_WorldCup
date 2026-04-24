namespace FIFA_WorldCup.Forms
{
    partial class frmCopaLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCopaLista));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mascote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCompeticao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCompeticao = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnParticipantes = new System.Windows.Forms.ToolStripButton();
            this.btnGrupos = new System.Windows.Forms.ToolStripButton();
            this.btnLocais = new System.Windows.Forms.ToolStripButton();
            this.btnResultado = new System.Windows.Forms.ToolStripButton();
            this.btnMatamata = new System.Windows.Forms.ToolStripButton();
            this.btnVagas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.masculinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femininoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confederaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picIncluir = new System.Windows.Forms.PictureBox();
            this.picEditar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIncluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(383, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 31);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Lista de Copas";
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
            this.Ano,
            this.Mascote,
            this.Status,
            this.Data_Inicial,
            this.Data_Final,
            this.TipoCompeticao});
            this.grdMain.Location = new System.Drawing.Point(78, 113);
            this.grdMain.MultiSelect = false;
            this.grdMain.Name = "grdMain";
            this.grdMain.ReadOnly = true;
            this.grdMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdMain.RowHeadersVisible = false;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMain.Size = new System.Drawing.Size(876, 504);
            this.grdMain.TabIndex = 2;
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
            this.Nome.Width = 180;
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            this.Ano.Width = 50;
            // 
            // Mascote
            // 
            this.Mascote.DataPropertyName = "Mascote";
            this.Mascote.HeaderText = "Mascote";
            this.Mascote.Name = "Mascote";
            this.Mascote.ReadOnly = true;
            this.Mascote.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Data_Inicial
            // 
            this.Data_Inicial.DataPropertyName = "Data_Inicial";
            this.Data_Inicial.HeaderText = "Data Inicial";
            this.Data_Inicial.Name = "Data_Inicial";
            this.Data_Inicial.ReadOnly = true;
            // 
            // Data_Final
            // 
            this.Data_Final.DataPropertyName = "Data_Final";
            this.Data_Final.HeaderText = "Data Final";
            this.Data_Final.Name = "Data_Final";
            this.Data_Final.ReadOnly = true;
            // 
            // TipoCompeticao
            // 
            this.TipoCompeticao.DataPropertyName = "Competicao";
            this.TipoCompeticao.HeaderText = "Competição";
            this.TipoCompeticao.Name = "TipoCompeticao";
            this.TipoCompeticao.ReadOnly = true;
            // 
            // cboCompeticao
            // 
            this.cboCompeticao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCompeticao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompeticao.FormattingEnabled = true;
            this.cboCompeticao.Location = new System.Drawing.Point(770, 70);
            this.cboCompeticao.Name = "cboCompeticao";
            this.cboCompeticao.Size = new System.Drawing.Size(159, 21);
            this.cboCompeticao.TabIndex = 8;
            this.cboCompeticao.SelectedIndexChanged += new System.EventHandler(this.cboCompeticao_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnParticipantes,
            this.btnGrupos,
            this.btnLocais,
            this.btnResultado,
            this.btnMatamata,
            this.btnVagas,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1027, 39);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnParticipantes
            // 
            this.btnParticipantes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnParticipantes.Image = ((System.Drawing.Image)(resources.GetObject("btnParticipantes.Image")));
            this.btnParticipantes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnParticipantes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnParticipantes.Name = "btnParticipantes";
            this.btnParticipantes.Size = new System.Drawing.Size(36, 36);
            this.btnParticipantes.Text = "toolStripButton1";
            this.btnParticipantes.ToolTipText = "Participantes";
            this.btnParticipantes.Click += new System.EventHandler(this.btnParticipantes_Click);
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
            // btnLocais
            // 
            this.btnLocais.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLocais.Image = ((System.Drawing.Image)(resources.GetObject("btnLocais.Image")));
            this.btnLocais.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLocais.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLocais.Name = "btnLocais";
            this.btnLocais.Size = new System.Drawing.Size(36, 36);
            this.btnLocais.Text = "toolStripButton1";
            this.btnLocais.ToolTipText = "Estádios";
            this.btnLocais.Click += new System.EventHandler(this.btnLocais_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnResultado.Image = ((System.Drawing.Image)(resources.GetObject("btnResultado.Image")));
            this.btnResultado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnResultado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(36, 36);
            this.btnResultado.Text = "toolStripButton1";
            this.btnResultado.ToolTipText = "Resultado";
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnMatamata
            // 
            this.btnMatamata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMatamata.Image = ((System.Drawing.Image)(resources.GetObject("btnMatamata.Image")));
            this.btnMatamata.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMatamata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMatamata.Name = "btnMatamata";
            this.btnMatamata.Size = new System.Drawing.Size(36, 36);
            this.btnMatamata.Text = "toolStripButton1";
            this.btnMatamata.ToolTipText = "Mata mata";
            this.btnMatamata.Click += new System.EventHandler(this.btnMatamata_Click);
            // 
            // btnVagas
            // 
            this.btnVagas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVagas.Image = ((System.Drawing.Image)(resources.GetObject("btnVagas.Image")));
            this.btnVagas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVagas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVagas.Name = "btnVagas";
            this.btnVagas.Size = new System.Drawing.Size(36, 36);
            this.btnVagas.Text = "Vagas";
            this.btnVagas.ToolTipText = "Vagas";
            this.btnVagas.Click += new System.EventHandler(this.btnVagas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masculinoToolStripMenuItem,
            this.femininoToolStripMenuItem,
            this.confederaçõesToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 36);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // masculinoToolStripMenuItem
            // 
            this.masculinoToolStripMenuItem.Name = "masculinoToolStripMenuItem";
            this.masculinoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.masculinoToolStripMenuItem.Text = "Masculino";
            this.masculinoToolStripMenuItem.Click += new System.EventHandler(this.masculinoToolStripMenuItem_Click);
            // 
            // femininoToolStripMenuItem
            // 
            this.femininoToolStripMenuItem.Name = "femininoToolStripMenuItem";
            this.femininoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.femininoToolStripMenuItem.Text = "Feminino";
            this.femininoToolStripMenuItem.Click += new System.EventHandler(this.femininoToolStripMenuItem_Click);
            // 
            // confederaçõesToolStripMenuItem
            // 
            this.confederaçõesToolStripMenuItem.Name = "confederaçõesToolStripMenuItem";
            this.confederaçõesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.confederaçõesToolStripMenuItem.Text = "Confederações";
            this.confederaçõesToolStripMenuItem.Click += new System.EventHandler(this.confederaçõesToolStripMenuItem_Click);
            // 
            // picIncluir
            // 
            this.picIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picIncluir.BackColor = System.Drawing.Color.Transparent;
            this.picIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIncluir.Image = ((System.Drawing.Image)(resources.GetObject("picIncluir.Image")));
            this.picIncluir.Location = new System.Drawing.Point(389, 640);
            this.picIncluir.Name = "picIncluir";
            this.picIncluir.Size = new System.Drawing.Size(32, 32);
            this.picIncluir.TabIndex = 12;
            this.picIncluir.TabStop = false;
            this.picIncluir.Click += new System.EventHandler(this.picIncluir_Click);
            // 
            // picEditar
            // 
            this.picEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picEditar.BackColor = System.Drawing.Color.Transparent;
            this.picEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditar.Image = ((System.Drawing.Image)(resources.GetObject("picEditar.Image")));
            this.picEditar.Location = new System.Drawing.Point(587, 640);
            this.picEditar.Name = "picEditar";
            this.picEditar.Size = new System.Drawing.Size(32, 32);
            this.picEditar.TabIndex = 13;
            this.picEditar.TabStop = false;
            this.picEditar.Click += new System.EventHandler(this.picEditar_Click);
            // 
            // frmCopaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 700);
            this.Controls.Add(this.picEditar);
            this.Controls.Add(this.picIncluir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cboCompeticao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grdMain);
            this.Name = "frmCopaLista";
            this.Text = "frmCopaLista";
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIncluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdMain;
        private System.Windows.Forms.ComboBox cboCompeticao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mascote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCompeticao;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnParticipantes;
        private System.Windows.Forms.ToolStripButton btnGrupos;
        private System.Windows.Forms.ToolStripButton btnLocais;
        private System.Windows.Forms.ToolStripButton btnResultado;
        private System.Windows.Forms.ToolStripButton btnMatamata;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnVagas;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem masculinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femininoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confederaçõesToolStripMenuItem;
        private System.Windows.Forms.PictureBox picIncluir;
        private System.Windows.Forms.PictureBox picEditar;
    }
}