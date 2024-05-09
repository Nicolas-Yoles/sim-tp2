namespace sim_tp2.Views
{
    partial class MontecarloForm
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
            this.dgvMontecarlo = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidadRondasTxt = new System.Windows.Forms.TextBox();
            this.rondaInicialTxt = new System.Windows.Forms.TextBox();
            this.rondaFinalTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxCantPuntosExito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCantidadPuntosStrike = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCantidadPuntosSpare = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontecarlo)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMontecarlo
            // 
            this.dgvMontecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMontecarlo.Location = new System.Drawing.Point(426, 112);
            this.dgvMontecarlo.Name = "dgvMontecarlo";
            this.dgvMontecarlo.RowHeadersWidth = 51;
            this.dgvMontecarlo.RowTemplate.Height = 24;
            this.dgvMontecarlo.Size = new System.Drawing.Size(1456, 858);
            this.dgvMontecarlo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(809, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Juego de Bowling";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(820, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Método de Montecarlo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de rondas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ronda inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ronda final";
            // 
            // cantidadRondasTxt
            // 
            this.cantidadRondasTxt.Location = new System.Drawing.Point(45, 31);
            this.cantidadRondasTxt.Name = "cantidadRondasTxt";
            this.cantidadRondasTxt.Size = new System.Drawing.Size(170, 22);
            this.cantidadRondasTxt.TabIndex = 3;
            this.cantidadRondasTxt.Text = "0";
            // 
            // rondaInicialTxt
            // 
            this.rondaInicialTxt.Location = new System.Drawing.Point(45, 64);
            this.rondaInicialTxt.Name = "rondaInicialTxt";
            this.rondaInicialTxt.Size = new System.Drawing.Size(170, 22);
            this.rondaInicialTxt.TabIndex = 4;
            this.rondaInicialTxt.Text = "0";
            // 
            // rondaFinalTxt
            // 
            this.rondaFinalTxt.Location = new System.Drawing.Point(45, 101);
            this.rondaFinalTxt.Name = "rondaFinalTxt";
            this.rondaFinalTxt.Size = new System.Drawing.Size(170, 22);
            this.rondaFinalTxt.TabIndex = 5;
            this.rondaFinalTxt.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "Probabilidades";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxCantPuntosExito
            // 
            this.textBoxCantPuntosExito.Location = new System.Drawing.Point(45, 139);
            this.textBoxCantPuntosExito.Name = "textBoxCantPuntosExito";
            this.textBoxCantPuntosExito.Size = new System.Drawing.Size(170, 22);
            this.textBoxCantPuntosExito.TabIndex = 10;
            this.textBoxCantPuntosExito.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad Puntos Exito";
            // 
            // textBoxCantidadPuntosStrike
            // 
            this.textBoxCantidadPuntosStrike.Location = new System.Drawing.Point(45, 177);
            this.textBoxCantidadPuntosStrike.Name = "textBoxCantidadPuntosStrike";
            this.textBoxCantidadPuntosStrike.Size = new System.Drawing.Size(170, 22);
            this.textBoxCantidadPuntosStrike.TabIndex = 12;
            this.textBoxCantidadPuntosStrike.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad Puntos Strike";
            // 
            // textBoxCantidadPuntosSpare
            // 
            this.textBoxCantidadPuntosSpare.Location = new System.Drawing.Point(45, 215);
            this.textBoxCantidadPuntosSpare.Name = "textBoxCantidadPuntosSpare";
            this.textBoxCantidadPuntosSpare.Size = new System.Drawing.Size(170, 22);
            this.textBoxCantidadPuntosSpare.TabIndex = 14;
            this.textBoxCantidadPuntosSpare.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad Puntos Spare";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 338);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxCantidadPuntosSpare);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxCantidadPuntosStrike);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxCantPuntosExito);
            this.groupBox1.Controls.Add(this.rondaFinalTxt);
            this.groupBox1.Controls.Add(this.rondaInicialTxt);
            this.groupBox1.Controls.Add(this.cantidadRondasTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 251);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // MontecarloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvMontecarlo);
            this.Name = "MontecarloForm";
            this.Text = "MontecarloForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MontecarloForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontecarlo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMontecarlo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cantidadRondasTxt;
        private System.Windows.Forms.TextBox rondaInicialTxt;
        private System.Windows.Forms.TextBox rondaFinalTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxCantPuntosExito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCantidadPuntosStrike;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCantidadPuntosSpare;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}