namespace FIFA_WorldCup.Forms
{
    partial class frmCidadeLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCidadeLista));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeIngles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picIncluir = new System.Windows.Forms.PictureBox();
            this.picAlterar = new System.Windows.Forms.PictureBox();
            this.picCancelar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIncluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(309, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(224, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lista de Cidades:";
            // 
            // grdMain
            // 
            this.grdMain.AllowUserToAddRows = false;
            this.grdMain.AllowUserToDeleteRows = false;
            this.grdMain.AllowUserToOrderColumns = true;
            this.grdMain.AllowUserToResizeColumns = false;
            this.grdMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PaisID,
            this.Nome,
            this.NomeIngles});
            this.grdMain.Location = new System.Drawing.Point(252, 126);
            this.grdMain.Name = "grdMain";
            this.grdMain.ReadOnly = true;
            this.grdMain.RowHeadersVisible = false;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMain.ShowEditingIcon = false;
            this.grdMain.Size = new System.Drawing.Size(473, 419);
            this.grdMain.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // PaisID
            // 
            this.PaisID.DataPropertyName = "PaisID";
            this.PaisID.HeaderText = "PaisID";
            this.PaisID.Name = "PaisID";
            this.PaisID.ReadOnly = true;
            this.PaisID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // NomeIngles
            // 
            this.NomeIngles.DataPropertyName = "NomeIngles";
            this.NomeIngles.HeaderText = "Nome Inglês";
            this.NomeIngles.Name = "NomeIngles";
            this.NomeIngles.ReadOnly = true;
            this.NomeIngles.Width = 200;
            // 
            // picIncluir
            // 
            this.picIncluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picIncluir.BackColor = System.Drawing.Color.Transparent;
            this.picIncluir.Image = ((System.Drawing.Image)(resources.GetObject("picIncluir.Image")));
            this.picIncluir.Location = new System.Drawing.Point(334, 605);
            this.picIncluir.Name = "picIncluir";
            this.picIncluir.Size = new System.Drawing.Size(64, 64);
            this.picIncluir.TabIndex = 2;
            this.picIncluir.TabStop = false;
            this.picIncluir.Click += new System.EventHandler(this.picIncluir_Click);
            // 
            // picAlterar
            // 
            this.picAlterar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picAlterar.BackColor = System.Drawing.Color.Transparent;
            this.picAlterar.Image = ((System.Drawing.Image)(resources.GetObject("picAlterar.Image")));
            this.picAlterar.Location = new System.Drawing.Point(478, 605);
            this.picAlterar.Name = "picAlterar";
            this.picAlterar.Size = new System.Drawing.Size(64, 64);
            this.picAlterar.TabIndex = 3;
            this.picAlterar.TabStop = false;
            this.picAlterar.Click += new System.EventHandler(this.picAlterar_Click);
            // 
            // picCancelar
            // 
            this.picCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picCancelar.BackColor = System.Drawing.Color.Transparent;
            this.picCancelar.Image = ((System.Drawing.Image)(resources.GetObject("picCancelar.Image")));
            this.picCancelar.Location = new System.Drawing.Point(616, 605);
            this.picCancelar.Name = "picCancelar";
            this.picCancelar.Size = new System.Drawing.Size(64, 64);
            this.picCancelar.TabIndex = 4;
            this.picCancelar.TabStop = false;
            this.picCancelar.Click += new System.EventHandler(this.picCancelar_Click);
            // 
            // frmCidadeLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 707);
            this.Controls.Add(this.picCancelar);
            this.Controls.Add(this.picAlterar);
            this.Controls.Add(this.picIncluir);
            this.Controls.Add(this.grdMain);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCidadeLista";
            this.Text = "Lista de Cidades";
            this.Shown += new System.EventHandler(this.frmCidadeLista_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIncluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeIngles;
        private System.Windows.Forms.PictureBox picIncluir;
        private System.Windows.Forms.PictureBox picAlterar;
        private System.Windows.Forms.PictureBox picCancelar;
    }
}