namespace Visualizador_comandos_SQL
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
            this.lblComando = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComando
            // 
            this.lblComando.AutoSize = true;
            this.lblComando.Location = new System.Drawing.Point(21, 23);
            this.lblComando.Name = "lblComando";
            this.lblComando.Size = new System.Drawing.Size(114, 13);
            this.lblComando.TabIndex = 0;
            this.lblComando.Text = "Digite o comando SQL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 145);
            this.textBox1.TabIndex = 1;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(12, 207);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(398, 23);
            this.btnExecutar.TabIndex = 2;
            this.btnExecutar.Text = "Executar Query";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 169);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 428);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblComando);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComando;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

