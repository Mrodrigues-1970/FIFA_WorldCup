namespace FIFA_WorldCup.Forms
{
    partial class frmPerformance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerformance));
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.CopaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jogos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vitorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Derrotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GolsPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GolsContra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CopaID,
            this.PaisID,
            this.Ano,
            this.Jogos,
            this.Vitorias,
            this.Empates,
            this.Derrotas,
            this.GolsPro,
            this.GolsContra,
            this.Saldo,
            this.Pontos,
            this.TipoFase,
            this.NomePais});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdMain.Location = new System.Drawing.Point(100, 64);
            this.grdMain.Name = "grdMain";
            this.grdMain.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdMain.RowHeadersVisible = false;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMain.Size = new System.Drawing.Size(784, 488);
            this.grdMain.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(333, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Performance nas Copas: ";
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOK.Location = new System.Drawing.Point(475, 582);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // CopaID
            // 
            this.CopaID.DataPropertyName = "CopaID";
            this.CopaID.HeaderText = "CopaID";
            this.CopaID.Name = "CopaID";
            this.CopaID.ReadOnly = true;
            this.CopaID.Visible = false;
            // 
            // PaisID
            // 
            this.PaisID.DataPropertyName = "PaisID";
            this.PaisID.HeaderText = "PaisID";
            this.PaisID.Name = "PaisID";
            this.PaisID.ReadOnly = true;
            this.PaisID.Visible = false;
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            this.Ano.Width = 80;
            // 
            // Jogos
            // 
            this.Jogos.DataPropertyName = "Jogos";
            this.Jogos.HeaderText = "Jogos";
            this.Jogos.Name = "Jogos";
            this.Jogos.ReadOnly = true;
            this.Jogos.Width = 80;
            // 
            // Vitorias
            // 
            this.Vitorias.DataPropertyName = "Vitorias";
            this.Vitorias.HeaderText = "Vitórias";
            this.Vitorias.Name = "Vitorias";
            this.Vitorias.ReadOnly = true;
            this.Vitorias.Width = 80;
            // 
            // Empates
            // 
            this.Empates.DataPropertyName = "Empates";
            this.Empates.HeaderText = "Empates";
            this.Empates.Name = "Empates";
            this.Empates.ReadOnly = true;
            this.Empates.Width = 80;
            // 
            // Derrotas
            // 
            this.Derrotas.DataPropertyName = "Derrotas";
            this.Derrotas.HeaderText = "Derrotas";
            this.Derrotas.Name = "Derrotas";
            this.Derrotas.ReadOnly = true;
            this.Derrotas.Width = 80;
            // 
            // GolsPro
            // 
            this.GolsPro.DataPropertyName = "GolsPro";
            this.GolsPro.HeaderText = "Gols Pró";
            this.GolsPro.Name = "GolsPro";
            this.GolsPro.ReadOnly = true;
            this.GolsPro.Width = 80;
            // 
            // GolsContra
            // 
            this.GolsContra.DataPropertyName = "GolsContra";
            this.GolsContra.HeaderText = "Gols Contra";
            this.GolsContra.Name = "GolsContra";
            this.GolsContra.ReadOnly = true;
            this.GolsContra.Width = 80;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 80;
            // 
            // Pontos
            // 
            this.Pontos.DataPropertyName = "Pontos";
            this.Pontos.HeaderText = "Pontos";
            this.Pontos.Name = "Pontos";
            this.Pontos.ReadOnly = true;
            this.Pontos.Width = 80;
            // 
            // TipoFase
            // 
            this.TipoFase.DataPropertyName = "TipoFase";
            this.TipoFase.HeaderText = "TipoFase";
            this.TipoFase.Name = "TipoFase";
            this.TipoFase.ReadOnly = true;
            this.TipoFase.Visible = false;
            this.TipoFase.Width = 80;
            // 
            // NomePais
            // 
            this.NomePais.DataPropertyName = "NomePais";
            this.NomePais.HeaderText = "NomePais";
            this.NomePais.Name = "NomePais";
            this.NomePais.ReadOnly = true;
            this.NomePais.Visible = false;
            // 
            // frmPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 633);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grdMain);
            this.Name = "frmPerformance";
            this.Text = "Performance";
            this.Shown += new System.EventHandler(this.frmPerformance_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMain;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vitorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Derrotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn GolsPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn GolsContra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFase;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePais;
    }
}