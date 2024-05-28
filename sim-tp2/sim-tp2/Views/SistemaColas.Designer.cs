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
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblPeluqueria = new System.Windows.Forms.Label();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dgvPeluqueria = new System.Windows.Forms.DataGridView();
            this.btnSimular = new System.Windows.Forms.Button();
            this.inputDias = new System.Windows.Forms.NumericUpDown();
            this.inputIteraciones = new System.Windows.Forms.NumericUpDown();
            this.inputHora = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeluqueria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputIteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHora)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTiempo.Location = new System.Drawing.Point(8, 84);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(195, 24);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Dias a simular(tiempo)";
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
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIteraciones.Location = new System.Drawing.Point(366, 84);
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
            this.lblHora.Location = new System.Drawing.Point(620, 84);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 24);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora";
            // 
            // dgvPeluqueria
            // 
            this.dgvPeluqueria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeluqueria.Location = new System.Drawing.Point(12, 212);
            this.dgvPeluqueria.Name = "dgvPeluqueria";
            this.dgvPeluqueria.Size = new System.Drawing.Size(776, 215);
            this.dgvPeluqueria.TabIndex = 7;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(693, 161);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 8;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // inputDias
            // 
            this.inputDias.Location = new System.Drawing.Point(220, 84);
            this.inputDias.Name = "inputDias";
            this.inputDias.Size = new System.Drawing.Size(120, 20);
            this.inputDias.TabIndex = 9;
            // 
            // inputIteraciones
            // 
            this.inputIteraciones.Location = new System.Drawing.Point(483, 84);
            this.inputIteraciones.Name = "inputIteraciones";
            this.inputIteraciones.Size = new System.Drawing.Size(120, 20);
            this.inputIteraciones.TabIndex = 10;
            // 
            // inputHora
            // 
            this.inputHora.Location = new System.Drawing.Point(677, 84);
            this.inputHora.Name = "inputHora";
            this.inputHora.Size = new System.Drawing.Size(120, 20);
            this.inputHora.TabIndex = 11;
            // 
            // SistemaColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sim_tp2.Properties.Resources._208478232_composición_con_tijeras_y_otros_accesorios_de_peluquería_sobre_fondo_blanco_vista_superior;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputHora);
            this.Controls.Add(this.inputIteraciones);
            this.Controls.Add(this.inputDias);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.dgvPeluqueria);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblIteraciones);
            this.Controls.Add(this.lblPeluqueria);
            this.Controls.Add(this.lblTiempo);
            this.Name = "SistemaColas";
            this.Text = "SistemaColas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeluqueria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputIteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblPeluqueria;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DataGridView dgvPeluqueria;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.NumericUpDown inputDias;
        private System.Windows.Forms.NumericUpDown inputIteraciones;
        private System.Windows.Forms.NumericUpDown inputHora;
    }
}