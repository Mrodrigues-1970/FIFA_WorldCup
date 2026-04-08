namespace FIFA_WorldCup
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCopa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPais = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAnfitrioes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnParticipacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFIFARanking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnSimuladores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuadrangular = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCopaMasculina = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showcaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTabelas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.showcaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCopa,
            this.mnPais,
            this.mnAnfitrioes,
            this.mnParticipacoes,
            this.mnFIFARanking,
            this.toolStripSeparator1,
            this.mnSimuladores,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // mnCopa
            // 
            this.mnCopa.Name = "mnCopa";
            this.mnCopa.Size = new System.Drawing.Size(144, 22);
            this.mnCopa.Text = "Copa";
            this.mnCopa.Click += new System.EventHandler(this.mnCopa_Click);
            // 
            // mnPais
            // 
            this.mnPais.Name = "mnPais";
            this.mnPais.Size = new System.Drawing.Size(144, 22);
            this.mnPais.Text = "Pais";
            this.mnPais.Click += new System.EventHandler(this.mnPais_Click);
            // 
            // mnAnfitrioes
            // 
            this.mnAnfitrioes.Name = "mnAnfitrioes";
            this.mnAnfitrioes.Size = new System.Drawing.Size(144, 22);
            this.mnAnfitrioes.Text = "Anfitriões";
            this.mnAnfitrioes.Click += new System.EventHandler(this.mnAnfitrioes_Click);
            // 
            // mnParticipacoes
            // 
            this.mnParticipacoes.Name = "mnParticipacoes";
            this.mnParticipacoes.Size = new System.Drawing.Size(144, 22);
            this.mnParticipacoes.Text = "Participações";
            this.mnParticipacoes.Click += new System.EventHandler(this.mnParticipacoes_Click);
            // 
            // mnFIFARanking
            // 
            this.mnFIFARanking.Name = "mnFIFARanking";
            this.mnFIFARanking.Size = new System.Drawing.Size(144, 22);
            this.mnFIFARanking.Text = "FIFA Ranking";
            this.mnFIFARanking.Click += new System.EventHandler(this.mnFIFARanking_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // mnSimuladores
            // 
            this.mnSimuladores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnQuadrangular,
            this.mnCopaMasculina});
            this.mnSimuladores.Name = "mnSimuladores";
            this.mnSimuladores.Size = new System.Drawing.Size(144, 22);
            this.mnSimuladores.Text = "Simuladores";
            // 
            // mnQuadrangular
            // 
            this.mnQuadrangular.Name = "mnQuadrangular";
            this.mnQuadrangular.Size = new System.Drawing.Size(159, 22);
            this.mnQuadrangular.Text = "Quadrangular";
            this.mnQuadrangular.Click += new System.EventHandler(this.mnQuadrangular_Click);
            // 
            // mnCopaMasculina
            // 
            this.mnCopaMasculina.Name = "mnCopaMasculina";
            this.mnCopaMasculina.Size = new System.Drawing.Size(159, 22);
            this.mnCopaMasculina.Text = "Copa Masculina";
            this.mnCopaMasculina.Click += new System.EventHandler(this.mnCopaMasculina_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // showcaseToolStripMenuItem
            // 
            this.showcaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTabelas});
            this.showcaseToolStripMenuItem.Name = "showcaseToolStripMenuItem";
            this.showcaseToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.showcaseToolStripMenuItem.Text = "Showcase";
            // 
            // mnTabelas
            // 
            this.mnTabelas.Name = "mnTabelas";
            this.mnTabelas.Size = new System.Drawing.Size(113, 22);
            this.mnTabelas.Text = "Tabelas";
            this.mnTabelas.Click += new System.EventHandler(this.mnTabelas_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 741);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 780);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIFA World Cup";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnCopa;
        private System.Windows.Forms.ToolStripMenuItem mnPais;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnAnfitrioes;
        private System.Windows.Forms.ToolStripMenuItem mnParticipacoes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnSimuladores;
        private System.Windows.Forms.ToolStripMenuItem mnQuadrangular;
        private System.Windows.Forms.ToolStripMenuItem mnCopaMasculina;
        private System.Windows.Forms.ToolStripMenuItem mnFIFARanking;
        private System.Windows.Forms.ToolStripMenuItem showcaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnTabelas;
    }
}

