namespace Festa_Fatec
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblRefri = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCerveja = new System.Windows.Forms.Label();
            this.lblCoxinha = new System.Windows.Forms.Label();
            this.lblSopa = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblAcumulado = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnEncerramento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(73, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(210, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "FESTA FATEC";
            // 
            // lblRefri
            // 
            this.lblRefri.AutoSize = true;
            this.lblRefri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefri.Location = new System.Drawing.Point(75, 127);
            this.lblRefri.Name = "lblRefri";
            this.lblRefri.Size = new System.Drawing.Size(77, 13);
            this.lblRefri.TabIndex = 1;
            this.lblRefri.Text = "Refrigerante";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(182, 130);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "TOTAL: ";
            // 
            // lblCerveja
            // 
            this.lblCerveja.AutoSize = true;
            this.lblCerveja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerveja.Location = new System.Drawing.Point(75, 152);
            this.lblCerveja.Name = "lblCerveja";
            this.lblCerveja.Size = new System.Drawing.Size(50, 13);
            this.lblCerveja.TabIndex = 3;
            this.lblCerveja.Text = "Cerveja";
            // 
            // lblCoxinha
            // 
            this.lblCoxinha.AutoSize = true;
            this.lblCoxinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoxinha.Location = new System.Drawing.Point(75, 199);
            this.lblCoxinha.Name = "lblCoxinha";
            this.lblCoxinha.Size = new System.Drawing.Size(52, 13);
            this.lblCoxinha.TabIndex = 4;
            this.lblCoxinha.Text = "Coxinha";
            // 
            // lblSopa
            // 
            this.lblSopa.AutoSize = true;
            this.lblSopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSopa.Location = new System.Drawing.Point(75, 225);
            this.lblSopa.Name = "lblSopa";
            this.lblSopa.Size = new System.Drawing.Size(36, 13);
            this.lblSopa.TabIndex = 5;
            this.lblSopa.Text = "Sopa";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.Location = new System.Drawing.Point(12, 67);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(67, 13);
            this.lblOperador.TabIndex = 6;
            this.lblOperador.Text = "Operador: ";
            // 
            // lblAcumulado
            // 
            this.lblAcumulado.AutoSize = true;
            this.lblAcumulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcumulado.Location = new System.Drawing.Point(12, 294);
            this.lblAcumulado.Name = "lblAcumulado";
            this.lblAcumulado.Size = new System.Drawing.Size(77, 13);
            this.lblAcumulado.TabIndex = 7;
            this.lblAcumulado.Text = "Acumulado: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 122);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(15, 148);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(15, 195);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown3.TabIndex = 10;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(15, 221);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown4.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Daiane",
            "Thiago"});
            this.comboBox1.Location = new System.Drawing.Point(92, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 121);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 33);
            this.textBox2.TabIndex = 14;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(260, 170);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnEncerramento
            // 
            this.btnEncerramento.Location = new System.Drawing.Point(255, 285);
            this.btnEncerramento.Name = "btnEncerramento";
            this.btnEncerramento.Size = new System.Drawing.Size(92, 23);
            this.btnEncerramento.TabIndex = 16;
            this.btnEncerramento.Text = "Encerramento";
            this.btnEncerramento.UseVisualStyleBackColor = true;
            this.btnEncerramento.Click += new System.EventHandler(this.btnEncerramento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 320);
            this.Controls.Add(this.btnEncerramento);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblAcumulado);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblSopa);
            this.Controls.Add(this.lblCoxinha);
            this.Controls.Add(this.lblCerveja);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRefri);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Controle de Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRefri;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCerveja;
        private System.Windows.Forms.Label lblCoxinha;
        private System.Windows.Forms.Label lblSopa;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblAcumulado;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnEncerramento;
    }
}

