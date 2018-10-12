namespace SimulateTyped
{
    partial class Form1
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
            this.txtScript = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkTeclasAcao = new System.Windows.Forms.CheckBox();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTempoIniciar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTempoPressionar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDefinirFonte = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnBackground = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempoIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempoPressionar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScript
            // 
            this.txtScript.AcceptsTab = true;
            this.txtScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScript.BackColor = System.Drawing.Color.Black;
            this.txtScript.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScript.ForeColor = System.Drawing.Color.Red;
            this.txtScript.Location = new System.Drawing.Point(12, 178);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScript.Size = new System.Drawing.Size(521, 184);
            this.txtScript.TabIndex = 0;
            this.txtScript.TabStop = false;
            this.txtScript.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScript_KeyDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(12, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkTeclasAcao
            // 
            this.chkTeclasAcao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTeclasAcao.AutoSize = true;
            this.chkTeclasAcao.Checked = true;
            this.chkTeclasAcao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTeclasAcao.ForeColor = System.Drawing.Color.Red;
            this.chkTeclasAcao.Location = new System.Drawing.Point(14, 372);
            this.chkTeclasAcao.Name = "chkTeclasAcao";
            this.chkTeclasAcao.Size = new System.Drawing.Size(101, 17);
            this.chkTeclasAcao.TabIndex = 2;
            this.chkTeclasAcao.Text = "Teclas de Ação";
            this.chkTeclasAcao.UseVisualStyleBackColor = true;
            // 
            // txtOriginal
            // 
            this.txtOriginal.AcceptsTab = true;
            this.txtOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOriginal.BackColor = System.Drawing.Color.Black;
            this.txtOriginal.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginal.ForeColor = System.Drawing.Color.Yellow;
            this.txtOriginal.Location = new System.Drawing.Point(12, 12);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOriginal.Size = new System.Drawing.Size(521, 160);
            this.txtOriginal.TabIndex = 3;
            this.txtOriginal.TabStop = false;
            this.txtOriginal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textOriginal_KeyDown);
            this.txtOriginal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOriginal_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Gold;
            this.btnLimpar.Location = new System.Drawing.Point(377, 394);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(156, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(71, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "em";
            // 
            // nudTempoIniciar
            // 
            this.nudTempoIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudTempoIniciar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nudTempoIniciar.ForeColor = System.Drawing.Color.Gold;
            this.nudTempoIniciar.Location = new System.Drawing.Point(93, 396);
            this.nudTempoIniciar.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTempoIniciar.Name = "nudTempoIniciar";
            this.nudTempoIniciar.Size = new System.Drawing.Size(49, 20);
            this.nudTempoIniciar.TabIndex = 6;
            this.nudTempoIniciar.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(143, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "segundos";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(237, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pressionar tecla a cada";
            // 
            // nudTempoPressionar
            // 
            this.nudTempoPressionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudTempoPressionar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nudTempoPressionar.ForeColor = System.Drawing.Color.Gold;
            this.nudTempoPressionar.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTempoPressionar.Location = new System.Drawing.Point(240, 396);
            this.nudTempoPressionar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTempoPressionar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTempoPressionar.Name = "nudTempoPressionar";
            this.nudTempoPressionar.Size = new System.Drawing.Size(57, 20);
            this.nudTempoPressionar.TabIndex = 9;
            this.nudTempoPressionar.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(304, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ms";
            // 
            // btnDefinirFonte
            // 
            this.btnDefinirFonte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefinirFonte.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDefinirFonte.ForeColor = System.Drawing.Color.Gold;
            this.btnDefinirFonte.Location = new System.Drawing.Point(458, 365);
            this.btnDefinirFonte.Name = "btnDefinirFonte";
            this.btnDefinirFonte.Size = new System.Drawing.Size(75, 23);
            this.btnDefinirFonte.TabIndex = 11;
            this.btnDefinirFonte.Text = "Fonte";
            this.btnDefinirFonte.UseVisualStyleBackColor = false;
            this.btnDefinirFonte.Click += new System.EventHandler(this.btnDefinirFonte_Click);
            // 
            // btnBackground
            // 
            this.btnBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackground.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackground.ForeColor = System.Drawing.Color.Gold;
            this.btnBackground.Location = new System.Drawing.Point(377, 365);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(75, 23);
            this.btnBackground.TabIndex = 12;
            this.btnBackground.Text = "Background";
            this.btnBackground.UseVisualStyleBackColor = false;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(126, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "T";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(545, 429);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.btnDefinirFonte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudTempoPressionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTempoIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.chkTeclasAcao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtScript);
            this.Name = "Form1";
            this.Text = "Simulador de Pressionamento by: Caio";
            ((System.ComponentModel.ISupportInitialize)(this.nudTempoIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempoPressionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkTeclasAcao;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTempoIniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudTempoPressionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDefinirFonte;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label5;
    }
}

