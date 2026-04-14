namespace FIFA_WorldCup.Forms
{
    partial class frmRanking3Lugar12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRanking3Lugar12));
            this.grdRanking = new System.Windows.Forms.DataGridView();
            this.Posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jogos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vitorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Derrotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GolsPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GolsContra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiferencaGols = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRanking
            // 
            this.grdRanking.AllowUserToAddRows = false;
            this.grdRanking.AllowUserToDeleteRows = false;
            this.grdRanking.AllowUserToOrderColumns = true;
            this.grdRanking.AllowUserToResizeColumns = false;
            this.grdRanking.AllowUserToResizeRows = false;
            this.grdRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posicao,
            this.Grupo,
            this.Pais,
            this.Jogos,
            this.Vitorias,
            this.Empates,
            this.Derrotas,
            this.GolsPro,
            this.GolsContra,
            this.DiferencaGols,
            this.Pontos});
            this.grdRanking.Location = new System.Drawing.Point(62, 193);
            this.grdRanking.MultiSelect = false;
            this.grdRanking.Name = "grdRanking";
            this.grdRanking.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRanking.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdRanking.RowHeadersVisible = false;
            this.grdRanking.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdRanking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdRanking.Size = new System.Drawing.Size(778, 434);
            this.grdRanking.TabIndex = 0;
            // 
            // Posicao
            // 
            this.Posicao.HeaderText = "_";
            this.Posicao.Name = "Posicao";
            this.Posicao.ReadOnly = true;
            this.Posicao.Width = 50;
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grp";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            this.Grupo.Width = 50;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "País";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            this.Pais.Width = 250;
            // 
            // Jogos
            // 
            this.Jogos.HeaderText = "J";
            this.Jogos.Name = "Jogos";
            this.Jogos.ReadOnly = true;
            this.Jogos.Width = 50;
            // 
            // Vitorias
            // 
            this.Vitorias.HeaderText = "V";
            this.Vitorias.Name = "Vitorias";
            this.Vitorias.ReadOnly = true;
            this.Vitorias.Width = 50;
            // 
            // Empates
            // 
            this.Empates.HeaderText = "E";
            this.Empates.Name = "Empates";
            this.Empates.ReadOnly = true;
            this.Empates.Width = 50;
            // 
            // Derrotas
            // 
            this.Derrotas.HeaderText = "D";
            this.Derrotas.Name = "Derrotas";
            this.Derrotas.ReadOnly = true;
            this.Derrotas.Width = 50;
            // 
            // GolsPro
            // 
            this.GolsPro.HeaderText = "GP";
            this.GolsPro.Name = "GolsPro";
            this.GolsPro.ReadOnly = true;
            this.GolsPro.Width = 50;
            // 
            // GolsContra
            // 
            this.GolsContra.HeaderText = "GC";
            this.GolsContra.Name = "GolsContra";
            this.GolsContra.ReadOnly = true;
            this.GolsContra.Width = 50;
            // 
            // DiferencaGols
            // 
            this.DiferencaGols.HeaderText = "DG";
            this.DiferencaGols.Name = "DiferencaGols";
            this.DiferencaGols.ReadOnly = true;
            this.DiferencaGols.Width = 50;
            // 
            // Pontos
            // 
            this.Pontos.HeaderText = "Pts";
            this.Pontos.Name = "Pontos";
            this.Pontos.ReadOnly = true;
            this.Pontos.Width = 50;
            // 
            // frmRanking3Lugar12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 687);
            this.Controls.Add(this.grdRanking);
            this.Name = "frmRanking3Lugar12";
            this.Text = "frmRanking3Lugar12";
            ((System.ComponentModel.ISupportInitialize)(this.grdRanking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vitorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Derrotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn GolsPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn GolsContra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiferencaGols;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pontos;
    }
}