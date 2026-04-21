namespace FIFA_WorldCup.Forms
{
    partial class frmFormatoDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormatoDisplay));
            this.picFormato = new System.Windows.Forms.PictureBox();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            this.lblNomeCopa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFormato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // picFormato
            // 
            this.picFormato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picFormato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFormato.Location = new System.Drawing.Point(0, 1);
            this.picFormato.Name = "picFormato";
            this.picFormato.Size = new System.Drawing.Size(1007, 712);
            this.picFormato.TabIndex = 0;
            this.picFormato.TabStop = false;
            // 
            // picInfo
            // 
            this.picInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picInfo.BackColor = System.Drawing.Color.Transparent;
            this.picInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInfo.Image = ((System.Drawing.Image)(resources.GetObject("picInfo.Image")));
            this.picInfo.Location = new System.Drawing.Point(448, 658);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(32, 32);
            this.picInfo.TabIndex = 2;
            this.picInfo.TabStop = false;
            this.picInfo.Click += new System.EventHandler(this.picInfo_Click);
            // 
            // picVoltar
            // 
            this.picVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picVoltar.BackColor = System.Drawing.Color.Transparent;
            this.picVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
            this.picVoltar.Location = new System.Drawing.Point(522, 658);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(32, 32);
            this.picVoltar.TabIndex = 3;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.picVoltar_Click);
            // 
            // lblNomeCopa
            // 
            this.lblNomeCopa.AutoSize = true;
            this.lblNomeCopa.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCopa.ForeColor = System.Drawing.Color.Black;
            this.lblNomeCopa.Location = new System.Drawing.Point(176, 39);
            this.lblNomeCopa.Name = "lblNomeCopa";
            this.lblNomeCopa.Size = new System.Drawing.Size(645, 46);
            this.lblNomeCopa.TabIndex = 4;
            this.lblNomeCopa.Text = "Espanha/Portugal/Marrocos 2030";
            // 
            // frmFormatoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 713);
            this.Controls.Add(this.lblNomeCopa);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.picInfo);
            this.Controls.Add(this.picFormato);
            this.Name = "frmFormatoDisplay";
            this.Text = "Detalhe do Formato";
            this.Shown += new System.EventHandler(this.frmFormatoDisplay_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picFormato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFormato;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.PictureBox picVoltar;
        private System.Windows.Forms.Label lblNomeCopa;
    }
}