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
            this.components = new System.ComponentModel.Container();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblPeluqueria = new System.Windows.Forms.Label();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dgvPeluqueria = new System.Windows.Forms.DataGridView();
            this.btnSimular = new System.Windows.Forms.Button();
            this.inputDias = new System.Windows.Forms.NumericUpDown();
            this.inputIteraciones = new System.Windows.Forms.NumericUpDown();
            this.inputHora = new System.Windows.Forms.NumericUpDown();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.peluqueriaEventoDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servidorDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeluqueria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputIteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peluqueriaEventoDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servidorDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTiempo.Location = new System.Drawing.Point(234, 122);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(126, 24);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Dias a simular";
            this.lblTiempo.Click += new System.EventHandler(this.lblTiempo_Click);
            // 
            // lblPeluqueria
            // 
            this.lblPeluqueria.AutoSize = true;
            this.lblPeluqueria.BackColor = System.Drawing.SystemColors.Window;
            this.lblPeluqueria.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeluqueria.Location = new System.Drawing.Point(589, 40);
            this.lblPeluqueria.Name = "lblPeluqueria";
            this.lblPeluqueria.Size = new System.Drawing.Size(266, 42);
            this.lblPeluqueria.TabIndex = 2;
            this.lblPeluqueria.Text = "Peluqueria VIP";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIteraciones.Location = new System.Drawing.Point(523, 120);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(183, 24);
            this.lblIteraciones.TabIndex = 5;
            this.lblIteraciones.Text = "Iteraciones a mostrar";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(860, 119);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(191, 24);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora desde a mostrar";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // dgvPeluqueria
            // 
            this.dgvPeluqueria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPeluqueria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeluqueria.Location = new System.Drawing.Point(73, 212);
            this.dgvPeluqueria.Name = "dgvPeluqueria";
            this.dgvPeluqueria.RowHeadersWidth = 51;
            this.dgvPeluqueria.Size = new System.Drawing.Size(1300, 550);
            this.dgvPeluqueria.TabIndex = 7;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(780, 169);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 8;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // inputDias
            // 
            this.inputDias.Location = new System.Drawing.Point(369, 126);
            this.inputDias.Name = "inputDias";
            this.inputDias.Size = new System.Drawing.Size(120, 20);
            this.inputDias.TabIndex = 9;
            // 
            // inputIteraciones
            // 
            this.inputIteraciones.Location = new System.Drawing.Point(715, 121);
            this.inputIteraciones.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.inputIteraciones.Name = "inputIteraciones";
            this.inputIteraciones.Size = new System.Drawing.Size(120, 20);
            this.inputIteraciones.TabIndex = 10;
            // 
            // inputHora
            // 
            this.inputHora.DecimalPlaces = 2;
            this.inputHora.Location = new System.Drawing.Point(1056, 122);
            this.inputHora.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.inputHora.Name = "inputHora";
            this.inputHora.Size = new System.Drawing.Size(120, 20);
            this.inputHora.TabIndex = 11;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.peluqueriaEventoDtoBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Parametros Distribucion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // peluqueriaEventoDtoBindingSource
            // 
            this.peluqueriaEventoDtoBindingSource.DataSource = typeof(sim_tp2.DTOs.Peluqueria.PeluqueriaEventoDto);
            // 
            // servidorDtoBindingSource
            // 
            this.servidorDtoBindingSource.DataSource = typeof(sim_tp2.DTOs.Peluqueria.ServidorDto);
            // 
            // SistemaColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::sim_tp2.Properties.Resources._208478232_composición_con_tijeras_y_otros_accesorios_de_peluquería_sobre_fondo_blanco_vista_superior;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1438, 827);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputHora);
            this.Controls.Add(this.inputIteraciones);
            this.Controls.Add(this.inputDias);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.dgvPeluqueria);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblIteraciones);
            this.Controls.Add(this.lblPeluqueria);
            this.Controls.Add(this.lblTiempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1440, 878);
            this.MinimumSize = new System.Drawing.Size(1438, 827);
            this.Name = "SistemaColas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SistemaColas";
            this.Load += new System.EventHandler(this.SistemaColas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeluqueria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputIteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peluqueriaEventoDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servidorDtoBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource peluqueriaEventoDtoBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingSource servidorDtoBindingSource;
        private System.Windows.Forms.Button button1;
    }
}