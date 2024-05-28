namespace sim_tp2.Views
{
    partial class SistemaColas
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
            this.txTiempo = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblPeluqueria = new System.Windows.Forms.Label();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.txHora = new System.Windows.Forms.TextBox();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txTiempo
            // 
            this.txTiempo.Location = new System.Drawing.Point(165, 84);
            this.txTiempo.Name = "txTiempo";
            this.txTiempo.Size = new System.Drawing.Size(100, 20);
            this.txTiempo.TabIndex = 0;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTiempo.Location = new System.Drawing.Point(84, 84);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(75, 24);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblPeluqueria
            // 
            this.lblPeluqueria.AutoSize = true;
            this.lblPeluqueria.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeluqueria.Location = new System.Drawing.Point(296, 9);
            this.lblPeluqueria.Name = "lblPeluqueria";
            this.lblPeluqueria.Size = new System.Drawing.Size(215, 43);
            this.lblPeluqueria.TabIndex = 2;
            this.lblPeluqueria.Text = "Peluqueria VIP";
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(423, 84);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(100, 20);
            this.txtIteraciones.TabIndex = 3;
            // 
            // txHora
            // 
            this.txHora.Location = new System.Drawing.Point(627, 84);
            this.txHora.Name = "txHora";
            this.txHora.Size = new System.Drawing.Size(100, 20);
            this.txHora.TabIndex = 4;
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIteraciones.Location = new System.Drawing.Point(316, 84);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(101, 24);
            this.lblIteraciones.TabIndex = 5;
            this.lblIteraciones.Text = "Iteraciones";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(570, 84);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 24);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 215);
            this.dataGridView1.TabIndex = 7;
            // 
            // SistemaColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sim_tp2.Properties.Resources._208478232_composición_con_tijeras_y_otros_accesorios_de_peluquería_sobre_fondo_blanco_vista_superior;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblIteraciones);
            this.Controls.Add(this.txHora);
            this.Controls.Add(this.txtIteraciones);
            this.Controls.Add(this.lblPeluqueria);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.txTiempo);
            this.Name = "SistemaColas";
            this.Text = "SistemaColas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txTiempo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblPeluqueria;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.TextBox txHora;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}