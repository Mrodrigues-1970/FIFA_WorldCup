namespace FIFA_WorldCup.Forms
{
    partial class frmPopupFormato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopupFormato));
            this.lblNomeCopa = new System.Windows.Forms.Label();
            this.txtDescricaoFormato = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeCopa
            // 
            this.lblNomeCopa.AutoSize = true;
            this.lblNomeCopa.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCopa.ForeColor = System.Drawing.Color.Yellow;
            this.lblNomeCopa.Location = new System.Drawing.Point(78, 27);
            this.lblNomeCopa.Name = "lblNomeCopa";
            this.lblNomeCopa.Size = new System.Drawing.Size(645, 46);
            this.lblNomeCopa.TabIndex = 0;
            this.lblNomeCopa.Text = "Espanha/Portugal/Marrocos 2030";
            // 
            // txtDescricaoFormato
            // 
            this.txtDescricaoFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoFormato.Location = new System.Drawing.Point(65, 119);
            this.txtDescricaoFormato.Multiline = true;
            this.txtDescricaoFormato.Name = "txtDescricaoFormato";
            this.txtDescricaoFormato.Size = new System.Drawing.Size(685, 144);
            this.txtDescricaoFormato.TabIndex = 1;
            this.txtDescricaoFormato.Text = "...\r\n";
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(368, 314);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 33);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // frmPopupFormato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.ControlBox = false;
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.txtDescricaoFormato);
            this.Controls.Add(this.lblNomeCopa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPopupFormato";
            this.Text = "Detalhes Formato";
            this.Shown += new System.EventHandler(this.frmPopupFormato_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCopa;
        private System.Windows.Forms.TextBox txtDescricaoFormato;
        private System.Windows.Forms.Button btOK;
    }
}