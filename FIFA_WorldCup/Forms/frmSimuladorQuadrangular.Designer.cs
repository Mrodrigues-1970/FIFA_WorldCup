namespace FIFA_WorldCup.Forms
{
    partial class frmSimuladorQuadrangular
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
            this.lblSimulador = new System.Windows.Forms.Label();
            this.txtTimeA = new System.Windows.Forms.TextBox();
            this.txtTimeB = new System.Windows.Forms.TextBox();
            this.txtTimeD = new System.Windows.Forms.TextBox();
            this.txtTimeC = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRodada1 = new System.Windows.Forms.TabPage();
            this.chk_SimularR1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.J2E = new System.Windows.Forms.RadioButton();
            this.rb_J2TB = new System.Windows.Forms.RadioButton();
            this.rb_J2TA = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.J1E = new System.Windows.Forms.RadioButton();
            this.rb_J1TB = new System.Windows.Forms.RadioButton();
            this.rb_J1TA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRodada2 = new System.Windows.Forms.TabPage();
            this.chk_SimularR2 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.J4E = new System.Windows.Forms.RadioButton();
            this.rb_J4TB = new System.Windows.Forms.RadioButton();
            this.rb_J4TA = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.J3E = new System.Windows.Forms.RadioButton();
            this.rb_J3TB = new System.Windows.Forms.RadioButton();
            this.rb_J3TA = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tabRodada3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chk_SimularR3 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rb_J5TB = new System.Windows.Forms.RadioButton();
            this.rb_J5TA = new System.Windows.Forms.RadioButton();
            this.rb_J6TB = new System.Windows.Forms.RadioButton();
            this.rb_J6TA = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabRodada1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabRodada2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabRodada3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSimulador
            // 
            this.lblSimulador.AutoSize = true;
            this.lblSimulador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.Location = new System.Drawing.Point(61, 44);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(252, 25);
            this.lblSimulador.TabIndex = 0;
            this.lblSimulador.Text = "Simulador de Quadrangular";
            // 
            // txtTimeA
            // 
            this.txtTimeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeA.Location = new System.Drawing.Point(66, 118);
            this.txtTimeA.Name = "txtTimeA";
            this.txtTimeA.Size = new System.Drawing.Size(171, 26);
            this.txtTimeA.TabIndex = 1;
            this.txtTimeA.Text = "AAA";
            this.txtTimeA.TextChanged += new System.EventHandler(this.txtTimeA_TextChanged);
            // 
            // txtTimeB
            // 
            this.txtTimeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeB.Location = new System.Drawing.Point(66, 201);
            this.txtTimeB.Name = "txtTimeB";
            this.txtTimeB.Size = new System.Drawing.Size(171, 26);
            this.txtTimeB.TabIndex = 2;
            this.txtTimeB.Text = "BBB";
            this.txtTimeB.TextChanged += new System.EventHandler(this.txtTimeB_TextChanged);
            // 
            // txtTimeD
            // 
            this.txtTimeD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeD.Location = new System.Drawing.Point(66, 355);
            this.txtTimeD.Name = "txtTimeD";
            this.txtTimeD.Size = new System.Drawing.Size(171, 26);
            this.txtTimeD.TabIndex = 4;
            this.txtTimeD.Text = "DDD";
            this.txtTimeD.TextChanged += new System.EventHandler(this.txtTimeD_TextChanged);
            // 
            // txtTimeC
            // 
            this.txtTimeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeC.Location = new System.Drawing.Point(66, 280);
            this.txtTimeC.Name = "txtTimeC";
            this.txtTimeC.Size = new System.Drawing.Size(171, 26);
            this.txtTimeC.TabIndex = 3;
            this.txtTimeC.Text = "CCC";
            this.txtTimeC.TextChanged += new System.EventHandler(this.txtTimeC_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.tabRodada1);
            this.tabControl1.Controls.Add(this.tabRodada2);
            this.tabControl1.Controls.Add(this.tabRodada3);
            this.tabControl1.Location = new System.Drawing.Point(312, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 299);
            this.tabControl1.TabIndex = 5;
            // 
            // tabRodada1
            // 
            this.tabRodada1.Controls.Add(this.chk_SimularR1);
            this.tabRodada1.Controls.Add(this.groupBox2);
            this.tabRodada1.Controls.Add(this.groupBox1);
            this.tabRodada1.Location = new System.Drawing.Point(4, 22);
            this.tabRodada1.Name = "tabRodada1";
            this.tabRodada1.Padding = new System.Windows.Forms.Padding(3);
            this.tabRodada1.Size = new System.Drawing.Size(358, 273);
            this.tabRodada1.TabIndex = 0;
            this.tabRodada1.Text = "Rodada 1";
            this.tabRodada1.UseVisualStyleBackColor = true;
            // 
            // chk_SimularR1
            // 
            this.chk_SimularR1.AutoSize = true;
            this.chk_SimularR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_SimularR1.Location = new System.Drawing.Point(135, 238);
            this.chk_SimularR1.Name = "chk_SimularR1";
            this.chk_SimularR1.Size = new System.Drawing.Size(81, 24);
            this.chk_SimularR1.TabIndex = 2;
            this.chk_SimularR1.Text = "Simular";
            this.chk_SimularR1.UseVisualStyleBackColor = true;
            this.chk_SimularR1.CheckedChanged += new System.EventHandler(this.chk_rodada1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.J2E);
            this.groupBox2.Controls.Add(this.rb_J2TB);
            this.groupBox2.Controls.Add(this.rb_J2TA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // J2E
            // 
            this.J2E.AutoSize = true;
            this.J2E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J2E.Location = new System.Drawing.Point(163, 79);
            this.J2E.Name = "J2E";
            this.J2E.Size = new System.Drawing.Size(14, 13);
            this.J2E.TabIndex = 5;
            this.J2E.TabStop = true;
            this.J2E.UseVisualStyleBackColor = true;
            // 
            // rb_J2TB
            // 
            this.rb_J2TB.AutoSize = true;
            this.rb_J2TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_J2TB.Location = new System.Drawing.Point(208, 26);
            this.rb_J2TB.Name = "rb_J2TB";
            this.rb_J2TB.Size = new System.Drawing.Size(87, 24);
            this.rb_J2TB.TabIndex = 4;
            this.rb_J2TB.TabStop = true;
            this.rb_J2TB.Text = "DDDDD";
            this.rb_J2TB.UseVisualStyleBackColor = true;
            // 
            // rb_J2TA
            // 
            this.rb_J2TA.AutoSize = true;
            this.rb_J2TA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_J2TA.Location = new System.Drawing.Point(9, 26);
            this.rb_J2TA.Name = "rb_J2TA";
            this.rb_J2TA.Size = new System.Drawing.Size(82, 24);
            this.rb_J2TA.TabIndex = 3;
            this.rb_J2TA.TabStop = true;
            this.rb_J2TA.Text = "CCCCC";
            this.rb_J2TA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.J1E);
            this.groupBox1.Controls.Add(this.rb_J1TB);
            this.groupBox1.Controls.Add(this.rb_J1TA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // J1E
            // 
            this.J1E.AutoSize = true;
            this.J1E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J1E.Location = new System.Drawing.Point(160, 80);
            this.J1E.Name = "J1E";
            this.J1E.Size = new System.Drawing.Size(14, 13);
            this.J1E.TabIndex = 3;
            this.J1E.TabStop = true;
            this.J1E.UseVisualStyleBackColor = true;
            // 
            // rb_J1TB
            // 
            this.rb_J1TB.AutoSize = true;
            this.rb_J1TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_J1TB.Location = new System.Drawing.Point(205, 34);
            this.rb_J1TB.Name = "rb_J1TB";
            this.rb_J1TB.Size = new System.Drawing.Size(82, 24);
            this.rb_J1TB.TabIndex = 2;
            this.rb_J1TB.TabStop = true;
            this.rb_J1TB.Text = "BBBBB";
            this.rb_J1TB.UseVisualStyleBackColor = true;
            // 
            // rb_J1TA
            // 
            this.rb_J1TA.AutoSize = true;
            this.rb_J1TA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_J1TA.Location = new System.Drawing.Point(6, 34);
            this.rb_J1TA.Name = "rb_J1TA";
            this.rb_J1TA.Size = new System.Drawing.Size(82, 24);
            this.rb_J1TA.TabIndex = 1;
            this.rb_J1TA.TabStop = true;
            this.rb_J1TA.Text = "AAAAA";
            this.rb_J1TA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // tabRodada2
            // 
            this.tabRodada2.Controls.Add(this.chk_SimularR2);
            this.tabRodada2.Controls.Add(this.groupBox3);
            this.tabRodada2.Controls.Add(this.groupBox4);
            this.tabRodada2.Location = new System.Drawing.Point(4, 22);
            this.tabRodada2.Name = "tabRodada2";
            this.tabRodada2.Padding = new System.Windows.Forms.Padding(3);
            this.tabRodada2.Size = new System.Drawing.Size(358, 273);
            this.tabRodada2.TabIndex = 1;
            this.tabRodada2.Text = "Rodada 2";
            this.tabRodada2.UseVisualStyleBackColor = true;
            // 
            // chk_SimularR2
            // 
            this.chk_SimularR2.AutoSize = true;
            this.chk_SimularR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_SimularR2.Location = new System.Drawing.Point(135, 240);
            this.chk_SimularR2.Name = "chk_SimularR2";
            this.chk_SimularR2.Size = new System.Drawing.Size(81, 24);
            this.chk_SimularR2.TabIndex = 5;
            this.chk_SimularR2.Text = "Simular";
            this.chk_SimularR2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.J4E);
            this.groupBox3.Controls.Add(this.rb_J4TB);
            this.groupBox3.Controls.Add(this.rb_J4TA);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 110);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // J4E
            // 
            this.J4E.AutoSize = true;
            this.J4E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J4E.Location = new System.Drawing.Point(163, 79);
            this.J4E.Name = "J4E";
            this.J4E.Size = new System.Drawing.Size(14, 13);
            this.J4E.TabIndex = 5;
            this.J4E.TabStop = true;
            this.J4E.UseVisualStyleBackColor = true;
            // 
            // rb_J4TB
            // 
            this.rb_J4TB.AutoSize = true;
            this.rb_J4TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_J4TB.Location = new System.Drawing.Point(213, 30);
            this.rb_J4TB.Name = "rb_J4TB";
            this.rb_J4TB.Size = new System.Drawing.Size(87, 24);
            this.rb_J4TB.TabIndex = 4;
            this.rb_J4TB.TabStop = true;
            this.rb_J4TB.Text = "DDDDD";
            this.rb_J4TB.UseVisualStyleBackColor = true;
            // 
            // rb_J4TA
            // 
            this.rb_J4TA.AutoSize = true;
            this.rb_J4TA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_J4TA.Location = new System.Drawing.Point(42, 26);
            this.rb_J4TA.Name = "rb_J4TA";
            this.rb_J4TA.Size = new System.Drawing.Size(82, 24);
            this.rb_J4TA.TabIndex = 3;
            this.rb_J4TA.TabStop = true;
            this.rb_J4TA.Text = "BBBBB";
            this.rb_J4TA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.J3E);
            this.groupBox4.Controls.Add(this.rb_J3TB);
            this.groupBox4.Controls.Add(this.rb_J3TA);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 110);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // J3E
            // 
            this.J3E.AutoSize = true;
            this.J3E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J3E.Location = new System.Drawing.Point(160, 80);
            this.J3E.Name = "J3E";
            this.J3E.Size = new System.Drawing.Size(14, 13);
            this.J3E.TabIndex = 3;
            this.J3E.TabStop = true;
            this.J3E.UseVisualStyleBackColor = true;
            // 
            // rb_J3TB
            // 
            this.rb_J3TB.AutoSize = true;
            this.rb_J3TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_J3TB.Location = new System.Drawing.Point(213, 33);
            this.rb_J3TB.Name = "rb_J3TB";
            this.rb_J3TB.Size = new System.Drawing.Size(82, 24);
            this.rb_J3TB.TabIndex = 2;
            this.rb_J3TB.TabStop = true;
            this.rb_J3TB.Text = "CCCCC";
            this.rb_J3TB.UseVisualStyleBackColor = true;
            // 
            // rb_J3TA
            // 
            this.rb_J3TA.AutoSize = true;
            this.rb_J3TA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_J3TA.Location = new System.Drawing.Point(42, 34);
            this.rb_J3TA.Name = "rb_J3TA";
            this.rb_J3TA.Size = new System.Drawing.Size(82, 24);
            this.rb_J3TA.TabIndex = 1;
            this.rb_J3TA.TabStop = true;
            this.rb_J3TA.Text = "AAAAA";
            this.rb_J3TA.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "X";
            // 
            // tabRodada3
            // 
            this.tabRodada3.Controls.Add(this.groupBox5);
            this.tabRodada3.Controls.Add(this.groupBox6);
            this.tabRodada3.Location = new System.Drawing.Point(4, 22);
            this.tabRodada3.Name = "tabRodada3";
            this.tabRodada3.Size = new System.Drawing.Size(358, 273);
            this.tabRodada3.TabIndex = 2;
            this.tabRodada3.Text = "Rodada 3";
            this.tabRodada3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.rb_J6TB);
            this.groupBox5.Controls.Add(this.rb_J6TA);
            this.groupBox5.Controls.Add(this.chk_SimularR3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(5, 157);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(346, 110);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // chk_SimularR3
            // 
            this.chk_SimularR3.AutoSize = true;
            this.chk_SimularR3.Location = new System.Drawing.Point(145, 73);
            this.chk_SimularR3.Name = "chk_SimularR3";
            this.chk_SimularR3.Size = new System.Drawing.Size(62, 17);
            this.chk_SimularR3.TabIndex = 8;
            this.chk_SimularR3.Text = "Empate";
            this.chk_SimularR3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "X";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.rb_J5TB);
            this.groupBox6.Controls.Add(this.rb_J5TA);
            this.groupBox6.Controls.Add(this.checkBox10);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(8, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(346, 110);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(142, 75);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(62, 17);
            this.checkBox10.TabIndex = 5;
            this.checkBox10.Text = "Empate";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "X";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(758, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 241);
            this.dataGridView1.TabIndex = 6;
            // 
            // rb_J5TB
            // 
            this.rb_J5TB.AutoSize = true;
            this.rb_J5TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_J5TB.Location = new System.Drawing.Point(232, 43);
            this.rb_J5TB.Name = "rb_J5TB";
            this.rb_J5TB.Size = new System.Drawing.Size(75, 24);
            this.rb_J5TB.TabIndex = 7;
            this.rb_J5TB.TabStop = true;
            this.rb_J5TB.Text = "DDDD";
            this.rb_J5TB.UseVisualStyleBackColor = true;
            // 
            // rb_J5TA
            // 
            this.rb_J5TA.AutoSize = true;
            this.rb_J5TA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_J5TA.Location = new System.Drawing.Point(33, 43);
            this.rb_J5TA.Name = "rb_J5TA";
            this.rb_J5TA.Size = new System.Drawing.Size(82, 24);
            this.rb_J5TA.TabIndex = 6;
            this.rb_J5TA.TabStop = true;
            this.rb_J5TA.Text = "AAAAA";
            this.rb_J5TA.UseVisualStyleBackColor = true;
            // 
            // rb_J6TB
            // 
            this.rb_J6TB.AutoSize = true;
            this.rb_J6TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_J6TB.Location = new System.Drawing.Point(232, 43);
            this.rb_J6TB.Name = "rb_J6TB";
            this.rb_J6TB.Size = new System.Drawing.Size(82, 24);
            this.rb_J6TB.TabIndex = 10;
            this.rb_J6TB.TabStop = true;
            this.rb_J6TB.Text = "CCCCC";
            this.rb_J6TB.UseVisualStyleBackColor = true;
            // 
            // rb_J6TA
            // 
            this.rb_J6TA.AutoSize = true;
            this.rb_J6TA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_J6TA.Location = new System.Drawing.Point(33, 43);
            this.rb_J6TA.Name = "rb_J6TA";
            this.rb_J6TA.Size = new System.Drawing.Size(71, 24);
            this.rb_J6TA.TabIndex = 9;
            this.rb_J6TA.TabStop = true;
            this.rb_J6TA.Text = "BBBB";
            this.rb_J6TA.UseVisualStyleBackColor = true;
            // 
            // frmSimuladorQuadrangular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtTimeD);
            this.Controls.Add(this.txtTimeC);
            this.Controls.Add(this.txtTimeB);
            this.Controls.Add(this.txtTimeA);
            this.Controls.Add(this.lblSimulador);
            this.Name = "frmSimuladorQuadrangular";
            this.Text = "frmSimuladorQuadrangular";
            this.tabControl1.ResumeLayout(false);
            this.tabRodada1.ResumeLayout(false);
            this.tabRodada1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabRodada2.ResumeLayout(false);
            this.tabRodada2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabRodada3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSimulador;
        private System.Windows.Forms.TextBox txtTimeA;
        private System.Windows.Forms.TextBox txtTimeB;
        private System.Windows.Forms.TextBox txtTimeD;
        private System.Windows.Forms.TextBox txtTimeC;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRodada1;
        private System.Windows.Forms.TabPage tabRodada2;
        private System.Windows.Forms.TabPage tabRodada3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chk_SimularR3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_SimularR1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton J2E;
        private System.Windows.Forms.RadioButton rb_J2TB;
        private System.Windows.Forms.RadioButton rb_J2TA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton J1E;
        private System.Windows.Forms.RadioButton rb_J1TB;
        private System.Windows.Forms.RadioButton rb_J1TA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_SimularR2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton J4E;
        private System.Windows.Forms.RadioButton rb_J4TB;
        private System.Windows.Forms.RadioButton rb_J4TA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton J3E;
        private System.Windows.Forms.RadioButton rb_J3TB;
        private System.Windows.Forms.RadioButton rb_J3TA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_J6TB;
        private System.Windows.Forms.RadioButton rb_J6TA;
        private System.Windows.Forms.RadioButton rb_J5TB;
        private System.Windows.Forms.RadioButton rb_J5TA;
    }
}