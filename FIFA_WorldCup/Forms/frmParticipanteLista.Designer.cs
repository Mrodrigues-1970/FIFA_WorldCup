namespace FIFA_WorldCup.Forms
{
    partial class frmParticipanteLista
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
            this.lstDisponiveis = new System.Windows.Forms.ListBox();
            this.lstAssociados = new System.Windows.Forms.ListBox();
            this.btAssociar = new System.Windows.Forms.Button();
            this.btDesaciociar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAssociados = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCopaLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(260, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Lista de Participantes da Copa";
            // 
            // lstDisponiveis
            // 
            this.lstDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisponiveis.FormattingEnabled = true;
            this.lstDisponiveis.HorizontalScrollbar = true;
            this.lstDisponiveis.ItemHeight = 16;
            this.lstDisponiveis.Location = new System.Drawing.Point(31, 100);
            this.lstDisponiveis.Name = "lstDisponiveis";
            this.lstDisponiveis.Size = new System.Drawing.Size(400, 388);
            this.lstDisponiveis.TabIndex = 7;
            this.lstDisponiveis.DoubleClick += new System.EventHandler(this.lstDisponiveis_DoubleClick);
            // 
            // lstAssociados
            // 
            this.lstAssociados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAssociados.FormattingEnabled = true;
            this.lstAssociados.HorizontalScrollbar = true;
            this.lstAssociados.ItemHeight = 16;
            this.lstAssociados.Location = new System.Drawing.Point(505, 100);
            this.lstAssociados.Name = "lstAssociados";
            this.lstAssociados.Size = new System.Drawing.Size(400, 388);
            this.lstAssociados.TabIndex = 8;
            this.lstAssociados.DoubleClick += new System.EventHandler(this.lstAssociados_DoubleClick);
            // 
            // btAssociar
            // 
            this.btAssociar.Location = new System.Drawing.Point(454, 200);
            this.btAssociar.Name = "btAssociar";
            this.btAssociar.Size = new System.Drawing.Size(29, 23);
            this.btAssociar.TabIndex = 9;
            this.btAssociar.Text = ">>";
            this.btAssociar.UseVisualStyleBackColor = true;
            this.btAssociar.Click += new System.EventHandler(this.btAssociar_Click);
            // 
            // btDesaciociar
            // 
            this.btDesaciociar.Location = new System.Drawing.Point(454, 333);
            this.btDesaciociar.Name = "btDesaciociar";
            this.btDesaciociar.Size = new System.Drawing.Size(29, 23);
            this.btDesaciociar.TabIndex = 10;
            this.btDesaciociar.Text = "<<";
            this.btDesaciociar.UseVisualStyleBackColor = true;
            this.btDesaciociar.Click += new System.EventHandler(this.btDesaciociar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Países Disponíveis";
            // 
            // lblAssociados
            // 
            this.lblAssociados.AutoSize = true;
            this.lblAssociados.Location = new System.Drawing.Point(671, 84);
            this.lblAssociados.Name = "lblAssociados";
            this.lblAssociados.Size = new System.Drawing.Size(104, 13);
            this.lblAssociados.TabIndex = 12;
            this.lblAssociados.Text = "Países Participantes";
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvar.Location = new System.Drawing.Point(356, 529);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 13;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCopaLista
            // 
            this.btCopaLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCopaLista.Location = new System.Drawing.Point(505, 529);
            this.btCopaLista.Name = "btCopaLista";
            this.btCopaLista.Size = new System.Drawing.Size(103, 23);
            this.btCopaLista.TabIndex = 14;
            this.btCopaLista.Text = "Lista de Copas";
            this.btCopaLista.UseVisualStyleBackColor = true;
            this.btCopaLista.Click += new System.EventHandler(this.btCopaLista_Click);
            // 
            // frmParticipanteLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 596);
            this.Controls.Add(this.btCopaLista);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lblAssociados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDesaciociar);
            this.Controls.Add(this.btAssociar);
            this.Controls.Add(this.lstAssociados);
            this.Controls.Add(this.lstDisponiveis);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmParticipanteLista";
            this.Text = "frmParticipanteLista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstDisponiveis;
        private System.Windows.Forms.ListBox lstAssociados;
        private System.Windows.Forms.Button btAssociar;
        private System.Windows.Forms.Button btDesaciociar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAssociados;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCopaLista;
    }
}