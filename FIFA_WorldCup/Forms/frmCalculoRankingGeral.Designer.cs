namespace FIFA_WorldCup.Forms
{
    partial class frmCalculoRankingGeral
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbCalculoRankinGeral = new System.Windows.Forms.ProgressBar();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(396, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cálculo de Ranking Geral";
            // 
            // pbCalculoRankinGeral
            // 
            this.pbCalculoRankinGeral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCalculoRankinGeral.Location = new System.Drawing.Point(61, 157);
            this.pbCalculoRankinGeral.Name = "pbCalculoRankinGeral";
            this.pbCalculoRankinGeral.Size = new System.Drawing.Size(1013, 23);
            this.pbCalculoRankinGeral.TabIndex = 1;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.Color.Red;
            this.btCalcular.Location = new System.Drawing.Point(452, 290);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(177, 70);
            this.btCalcular.TabIndex = 2;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // frmCalculoRankingGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 695);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.pbCalculoRankinGeral);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCalculoRankingGeral";
            this.Text = "Cálculo de Ranking Geral";
            this.Shown += new System.EventHandler(this.frmCalculoRankingGeral_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ProgressBar pbCalculoRankinGeral;
        private System.Windows.Forms.Button btCalcular;
    }
}