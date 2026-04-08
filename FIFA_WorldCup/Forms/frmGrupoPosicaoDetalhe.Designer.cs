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
            this.label1 = new System.Windows.Forms.Label();
            this.cboPosicao1 = new System.Windows.Forms.ComboBox();
            this.cboPosicao2 = new System.Windows.Forms.ComboBox();
            this.cboPosicao4 = new System.Windows.Forms.ComboBox();
            this.cboPosicao3 = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Definição de Posições para ";
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
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(274, 532);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(641, 532);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // frmGrupoPosicaoDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 657);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.cboPosicao4);
            this.Controls.Add(this.cboPosicao3);
            this.Controls.Add(this.cboPosicao2);
            this.Controls.Add(this.cboPosicao1);
            this.Controls.Add(this.label1);
            this.Name = "frmGrupoPosicaoDetalhe";
            this.Text = "frmGrupoPosicaoDetalhe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPosicao1;
        private System.Windows.Forms.ComboBox cboPosicao2;
        private System.Windows.Forms.ComboBox cboPosicao4;
        private System.Windows.Forms.ComboBox cboPosicao3;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
    }
}