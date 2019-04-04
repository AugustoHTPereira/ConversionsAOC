namespace WFConversoes
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
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDeHexadecimal = new System.Windows.Forms.RadioButton();
            this.rbDeBase5 = new System.Windows.Forms.RadioButton();
            this.rbDeOctal = new System.Windows.Forms.RadioButton();
            this.rbDeDecimal = new System.Windows.Forms.RadioButton();
            this.rbDeBinario = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbParaHexadecimal = new System.Windows.Forms.RadioButton();
            this.rbParaBase5 = new System.Windows.Forms.RadioButton();
            this.rbParaOctal = new System.Windows.Forms.RadioButton();
            this.rbParaBinario = new System.Windows.Forms.RadioButton();
            this.rbParaDecimal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtEntrada.Location = new System.Drawing.Point(15, 194);
            this.txtEntrada.MaxLength = 19;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(174, 20);
            this.txtEntrada.TabIndex = 0;
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            // 
            // txtSaida
            // 
            this.txtSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaida.Enabled = false;
            this.txtSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtSaida.Location = new System.Drawing.Point(195, 194);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ReadOnly = true;
            this.txtSaida.Size = new System.Drawing.Size(174, 20);
            this.txtSaida.TabIndex = 1;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErro.Location = new System.Drawing.Point(12, 222);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDeHexadecimal);
            this.groupBox1.Controls.Add(this.rbDeBase5);
            this.groupBox1.Controls.Add(this.rbDeOctal);
            this.groupBox1.Controls.Add(this.rbDeDecimal);
            this.groupBox1.Controls.Add(this.rbDeBinario);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.groupBox1.Location = new System.Drawing.Point(15, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // rbDeHexadecimal
            // 
            this.rbDeHexadecimal.AutoSize = true;
            this.rbDeHexadecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbDeHexadecimal.Location = new System.Drawing.Point(6, 111);
            this.rbDeHexadecimal.Name = "rbDeHexadecimal";
            this.rbDeHexadecimal.Size = new System.Drawing.Size(92, 24);
            this.rbDeHexadecimal.TabIndex = 9;
            this.rbDeHexadecimal.Text = "Hexadecimal";
            this.rbDeHexadecimal.UseVisualStyleBackColor = true;
            this.rbDeHexadecimal.CheckedChanged += new System.EventHandler(this.rbDeHexadecimal_CheckedChanged);
            // 
            // rbDeBase5
            // 
            this.rbDeBase5.AutoSize = true;
            this.rbDeBase5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbDeBase5.Location = new System.Drawing.Point(6, 88);
            this.rbDeBase5.Name = "rbDeBase5";
            this.rbDeBase5.Size = new System.Drawing.Size(59, 24);
            this.rbDeBase5.TabIndex = 8;
            this.rbDeBase5.Text = "Base 5";
            this.rbDeBase5.UseVisualStyleBackColor = true;
            this.rbDeBase5.CheckedChanged += new System.EventHandler(this.rbDeBase5_CheckedChanged);
            // 
            // rbDeOctal
            // 
            this.rbDeOctal.AutoSize = true;
            this.rbDeOctal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbDeOctal.Location = new System.Drawing.Point(6, 65);
            this.rbDeOctal.Name = "rbDeOctal";
            this.rbDeOctal.Size = new System.Drawing.Size(52, 24);
            this.rbDeOctal.TabIndex = 7;
            this.rbDeOctal.Text = "Octal";
            this.rbDeOctal.UseVisualStyleBackColor = true;
            this.rbDeOctal.CheckedChanged += new System.EventHandler(this.rbDeOctal_CheckedChanged);
            // 
            // rbDeDecimal
            // 
            this.rbDeDecimal.AutoSize = true;
            this.rbDeDecimal.Checked = true;
            this.rbDeDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbDeDecimal.Location = new System.Drawing.Point(6, 42);
            this.rbDeDecimal.Name = "rbDeDecimal";
            this.rbDeDecimal.Size = new System.Drawing.Size(67, 24);
            this.rbDeDecimal.TabIndex = 6;
            this.rbDeDecimal.TabStop = true;
            this.rbDeDecimal.Text = "Decimal";
            this.rbDeDecimal.UseVisualStyleBackColor = true;
            this.rbDeDecimal.CheckedChanged += new System.EventHandler(this.rbDeDecimal_CheckedChanged);
            // 
            // rbDeBinario
            // 
            this.rbDeBinario.AutoSize = true;
            this.rbDeBinario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbDeBinario.Location = new System.Drawing.Point(6, 19);
            this.rbDeBinario.Name = "rbDeBinario";
            this.rbDeBinario.Size = new System.Drawing.Size(63, 24);
            this.rbDeBinario.TabIndex = 5;
            this.rbDeBinario.Text = "Binário";
            this.rbDeBinario.UseVisualStyleBackColor = true;
            this.rbDeBinario.CheckedChanged += new System.EventHandler(this.rbDeBinario_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbParaHexadecimal);
            this.groupBox2.Controls.Add(this.rbParaBase5);
            this.groupBox2.Controls.Add(this.rbParaOctal);
            this.groupBox2.Controls.Add(this.rbParaBinario);
            this.groupBox2.Controls.Add(this.rbParaDecimal);
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.groupBox2.Location = new System.Drawing.Point(195, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 142);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saída";
            // 
            // rbParaHexadecimal
            // 
            this.rbParaHexadecimal.AutoSize = true;
            this.rbParaHexadecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbParaHexadecimal.Location = new System.Drawing.Point(6, 111);
            this.rbParaHexadecimal.Name = "rbParaHexadecimal";
            this.rbParaHexadecimal.Size = new System.Drawing.Size(92, 24);
            this.rbParaHexadecimal.TabIndex = 10;
            this.rbParaHexadecimal.TabStop = true;
            this.rbParaHexadecimal.Text = "Hexadecimal";
            this.rbParaHexadecimal.UseVisualStyleBackColor = true;
            this.rbParaHexadecimal.CheckedChanged += new System.EventHandler(this.rbParaHexadecimal_CheckedChanged);
            // 
            // rbParaBase5
            // 
            this.rbParaBase5.AutoSize = true;
            this.rbParaBase5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbParaBase5.Location = new System.Drawing.Point(6, 88);
            this.rbParaBase5.Name = "rbParaBase5";
            this.rbParaBase5.Size = new System.Drawing.Size(59, 24);
            this.rbParaBase5.TabIndex = 12;
            this.rbParaBase5.TabStop = true;
            this.rbParaBase5.Text = "Base 5";
            this.rbParaBase5.UseVisualStyleBackColor = true;
            this.rbParaBase5.CheckedChanged += new System.EventHandler(this.rbParaBase5_CheckedChanged);
            // 
            // rbParaOctal
            // 
            this.rbParaOctal.AutoSize = true;
            this.rbParaOctal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbParaOctal.Location = new System.Drawing.Point(6, 65);
            this.rbParaOctal.Name = "rbParaOctal";
            this.rbParaOctal.Size = new System.Drawing.Size(52, 24);
            this.rbParaOctal.TabIndex = 11;
            this.rbParaOctal.TabStop = true;
            this.rbParaOctal.Text = "Octal";
            this.rbParaOctal.UseVisualStyleBackColor = true;
            this.rbParaOctal.CheckedChanged += new System.EventHandler(this.rbParaOctal_CheckedChanged);
            // 
            // rbParaBinario
            // 
            this.rbParaBinario.AutoSize = true;
            this.rbParaBinario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbParaBinario.Location = new System.Drawing.Point(6, 19);
            this.rbParaBinario.Name = "rbParaBinario";
            this.rbParaBinario.Size = new System.Drawing.Size(63, 24);
            this.rbParaBinario.TabIndex = 9;
            this.rbParaBinario.TabStop = true;
            this.rbParaBinario.Text = "Binário";
            this.rbParaBinario.UseVisualStyleBackColor = true;
            this.rbParaBinario.CheckedChanged += new System.EventHandler(this.rbParaBinario_CheckedChanged);
            // 
            // rbParaDecimal
            // 
            this.rbParaDecimal.AutoSize = true;
            this.rbParaDecimal.Checked = true;
            this.rbParaDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbParaDecimal.Location = new System.Drawing.Point(6, 42);
            this.rbParaDecimal.Name = "rbParaDecimal";
            this.rbParaDecimal.Size = new System.Drawing.Size(67, 24);
            this.rbParaDecimal.TabIndex = 10;
            this.rbParaDecimal.TabStop = true;
            this.rbParaDecimal.Text = "Decimal";
            this.rbParaDecimal.UseVisualStyleBackColor = true;
            this.rbParaDecimal.CheckedChanged += new System.EventHandler(this.rbParaDecimal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONVERSÕES DE BASE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WFConversoes.Properties.Resources.icons8_cancel_filled_50;
            this.pictureBox1.Location = new System.Drawing.Point(346, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(384, 250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.txtEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversões";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDeHexadecimal;
        private System.Windows.Forms.RadioButton rbDeBase5;
        private System.Windows.Forms.RadioButton rbDeOctal;
        private System.Windows.Forms.RadioButton rbDeDecimal;
        private System.Windows.Forms.RadioButton rbDeBinario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbParaHexadecimal;
        private System.Windows.Forms.RadioButton rbParaBase5;
        private System.Windows.Forms.RadioButton rbParaOctal;
        private System.Windows.Forms.RadioButton rbParaBinario;
        private System.Windows.Forms.RadioButton rbParaDecimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

