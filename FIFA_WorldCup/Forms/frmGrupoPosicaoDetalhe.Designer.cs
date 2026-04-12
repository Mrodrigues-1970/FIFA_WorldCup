namespace FIFA_WorldCup.Forms
{
    partial class frmGrupoPosicaoDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupoPosicaoDetalhe));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboPosicao1 = new System.Windows.Forms.ComboBox();
            this.cboPosicao2 = new System.Windows.Forms.ComboBox();
            this.cboPosicao4 = new System.Windows.Forms.ComboBox();
            this.cboPosicao3 = new System.Windows.Forms.ComboBox();
            this.picSalvar = new System.Windows.Forms.PictureBox();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(291, 53);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(351, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Definição de Posições para ";
            // 
            // cboPosicao1
            // 
            this.cboPosicao1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosicao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosicao1.FormattingEnabled = true;
            this.cboPosicao1.Location = new System.Drawing.Point(274, 174);
            this.cboPosicao1.Name = "cboPosicao1";
            this.cboPosicao1.Size = new System.Drawing.Size(442, 28);
            this.cboPosicao1.TabIndex = 1;
            // 
            // cboPosicao2
            // 
            this.cboPosicao2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosicao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosicao2.FormattingEnabled = true;
            this.cboPosicao2.Location = new System.Drawing.Point(274, 257);
            this.cboPosicao2.Name = "cboPosicao2";
            this.cboPosicao2.Size = new System.Drawing.Size(442, 28);
            this.cboPosicao2.TabIndex = 2;
            // 
            // cboPosicao4
            // 
            this.cboPosicao4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosicao4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosicao4.FormattingEnabled = true;
            this.cboPosicao4.Location = new System.Drawing.Point(274, 423);
            this.cboPosicao4.Name = "cboPosicao4";
            this.cboPosicao4.Size = new System.Drawing.Size(442, 28);
            this.cboPosicao4.TabIndex = 4;
            // 
            // cboPosicao3
            // 
            this.cboPosicao3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosicao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosicao3.FormattingEnabled = true;
            this.cboPosicao3.Location = new System.Drawing.Point(274, 340);
            this.cboPosicao3.Name = "cboPosicao3";
            this.cboPosicao3.Size = new System.Drawing.Size(442, 28);
            this.cboPosicao3.TabIndex = 3;
            // 
            // picSalvar
            // 
            this.picSalvar.BackColor = System.Drawing.Color.Transparent;
            this.picSalvar.Image = ((System.Drawing.Image)(resources.GetObject("picSalvar.Image")));
            this.picSalvar.Location = new System.Drawing.Point(274, 505);
            this.picSalvar.Name = "picSalvar";
            this.picSalvar.Size = new System.Drawing.Size(64, 64);
            this.picSalvar.TabIndex = 7;
            this.picSalvar.TabStop = false;
            this.picSalvar.Click += new System.EventHandler(this.picSalvar_Click);
            // 
            // picVoltar
            // 
            this.picVoltar.BackColor = System.Drawing.Color.Transparent;
            this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
            this.picVoltar.Location = new System.Drawing.Point(652, 505);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(64, 64);
            this.picVoltar.TabIndex = 8;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.picVoltar_Click);
            // 
            // frmGrupoPosicaoDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 657);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.picSalvar);
            this.Controls.Add(this.cboPosicao4);
            this.Controls.Add(this.cboPosicao3);
            this.Controls.Add(this.cboPosicao2);
            this.Controls.Add(this.cboPosicao1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmGrupoPosicaoDetalhe";
            this.Text = "frmGrupoPosicaoDetalhe";
            this.Shown += new System.EventHandler(this.frmGrupoPosicaoDetalhe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboPosicao1;
        private System.Windows.Forms.ComboBox cboPosicao2;
        private System.Windows.Forms.ComboBox cboPosicao4;
        private System.Windows.Forms.ComboBox cboPosicao3;
        private System.Windows.Forms.PictureBox picSalvar;
        private System.Windows.Forms.PictureBox picVoltar;
    }
}