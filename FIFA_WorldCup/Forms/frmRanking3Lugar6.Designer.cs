namespace FIFA_WorldCup.Forms
{
    partial class frmRanking3Lugar6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRanking3Lugar6));
            this.grdRanking = new System.Windows.Forms.DataGridView();
            this.Flag = new System.Windows.Forms.DataGridViewImageColumn();
            this.NomePais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jogos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vitorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Derrotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GolsPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GolsContra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRanking
            // 
            this.grdRanking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Flag,
            this.NomePais,
            this.Jogos,
            this.Vitorias,
            this.Empates,
            this.Derrotas,
            this.GolsPro,
            this.GolsContra,
            this.Saldo,
            this.Pontos,
            this.TipoFase,
            this.Ano,
            this.PaisID,
            this.CopaID});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdRanking.DefaultCellStyle = dataGridViewCellStyle10;
            this.grdRanking.Location = new System.Drawing.Point(107, 222);
            this.grdRanking.Name = "grdRanking";
            this.grdRanking.RowHeadersVisible = false;
            this.grdRanking.RowTemplate.Height = 53;
            this.grdRanking.Size = new System.Drawing.Size(688, 340);
            this.grdRanking.TabIndex = 0;
            // 
            // Flag
            // 
            this.Flag.HeaderText = "Flag";
            this.Flag.Name = "Flag";
            this.Flag.Width = 60;
            // 
            // NomePais
            // 
            this.NomePais.DataPropertyName = "NomePais";
            this.NomePais.HeaderText = "País";
            this.NomePais.Name = "NomePais";
            this.NomePais.Width = 220;
            // 
            // Jogos
            // 
            this.Jogos.DataPropertyName = "Jogos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Jogos.DefaultCellStyle = dataGridViewCellStyle2;
            this.Jogos.HeaderText = "Jogos";
            this.Jogos.Name = "Jogos";
            this.Jogos.Width = 50;
            // 
            // Vitorias
            // 
            this.Vitorias.DataPropertyName = "Vitorias";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Vitorias.DefaultCellStyle = dataGridViewCellStyle3;
            this.Vitorias.HeaderText = "Vitorias";
            this.Vitorias.Name = "Vitorias";
            this.Vitorias.Width = 50;
            // 
            // Empates
            // 
            this.Empates.DataPropertyName = "Empates";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Empates.DefaultCellStyle = dataGridViewCellStyle4;
            this.Empates.HeaderText = "Empates";
            this.Empates.Name = "Empates";
            this.Empates.Width = 50;
            // 
            // Derrotas
            // 
            this.Derrotas.DataPropertyName = "Derrotas";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Derrotas.DefaultCellStyle = dataGridViewCellStyle5;
            this.Derrotas.HeaderText = "Derrotas";
            this.Derrotas.Name = "Derrotas";
            this.Derrotas.Width = 50;
            // 
            // GolsPro
            // 
            this.GolsPro.DataPropertyName = "GolsPro";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GolsPro.DefaultCellStyle = dataGridViewCellStyle6;
            this.GolsPro.HeaderText = "GolsPro";
            this.GolsPro.Name = "GolsPro";
            this.GolsPro.Width = 50;
            // 
            // GolsContra
            // 
            this.GolsContra.DataPropertyName = "GolsContra";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GolsContra.DefaultCellStyle = dataGridViewCellStyle7;
            this.GolsContra.HeaderText = "GolsContra";
            this.GolsContra.Name = "GolsContra";
            this.GolsContra.Width = 50;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle8;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.Width = 50;
            // 
            // Pontos
            // 
            this.Pontos.DataPropertyName = "Pontos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Pontos.DefaultCellStyle = dataGridViewCellStyle9;
            this.Pontos.HeaderText = "Pontos";
            this.Pontos.Name = "Pontos";
            this.Pontos.Width = 50;
            // 
            // TipoFase
            // 
            this.TipoFase.DataPropertyName = "TipoFase";
            this.TipoFase.HeaderText = "TipoFase";
            this.TipoFase.Name = "TipoFase";
            this.TipoFase.Visible = false;
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.Visible = false;
            // 
            // PaisID
            // 
            this.PaisID.DataPropertyName = "PaisID";
            this.PaisID.HeaderText = "PaisID";
            this.PaisID.Name = "PaisID";
            this.PaisID.Visible = false;
            // 
            // CopaID
            // 
            this.CopaID.DataPropertyName = "CopaID";
            this.CopaID.HeaderText = "CopaID";
            this.CopaID.Name = "CopaID";
            this.CopaID.Visible = false;
            // 
            // frmRanking3Lugar6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 687);
            this.Controls.Add(this.grdRanking);
            this.Name = "frmRanking3Lugar6";
            this.Text = "frmRankin3Lugar6";
            this.Shown += new System.EventHandler(this.frmRanking3Lugar6_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdRanking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRanking;
        private System.Windows.Forms.DataGridViewImageColumn Flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vitorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Derrotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn GolsPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn GolsContra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopaID;
    }
}