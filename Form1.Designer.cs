namespace GerarStringAleatoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGerar.Location = new System.Drawing.Point(102, 215);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 33);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 133);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(278, 23);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "-";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.Location = new System.Drawing.Point(125, 61);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudQuantidade.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(52, 23);
            this.nudQuantidade.TabIndex = 0;
            this.nudQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuantidade.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade de caracteres:";
            // 
            // btnCopiar
            // 
            this.btnCopiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCopiar.Enabled = false;
            this.btnCopiar.Image = ((System.Drawing.Image)(resources.GetObject("btnCopiar.Image")));
            this.btnCopiar.Location = new System.Drawing.Point(138, 160);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(27, 28);
            this.btnCopiar.TabIndex = 1;
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Visible = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(302, 288);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnGerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar String Aleatória";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopiar;
    }
}

