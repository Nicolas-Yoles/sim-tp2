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
            this.lblTiempo.Location = new System.Drawing.Point(35, 84);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(164, 29);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Dias a simular";
            this.lblTiempo.Click += new System.EventHandler(this.lblTiempo_Click);
            // 
            // lblPeluqueria
            // 
            this.lblPeluqueria.AutoSize = true;
            this.lblPeluqueria.BackColor = System.Drawing.SystemColors.Window;
            this.lblPeluqueria.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeluqueria.Location = new System.Drawing.Point(663, 9);
            this.lblPeluqueria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeluqueria.Name = "lblPeluqueria";
            this.lblPeluqueria.Size = new System.Drawing.Size(274, 54);
            this.lblPeluqueria.TabIndex = 2;
            this.lblPeluqueria.Text = "Peluqueria VIP";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIteraciones.Location = new System.Drawing.Point(552, 84);
            this.lblIteraciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(237, 29);
            this.lblIteraciones.TabIndex = 5;
            this.lblIteraciones.Text = "Iteraciones a mostrar";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(1076, 84);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(245, 29);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora desde a mostrar";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // dgvPeluqueria
            // 
            this.dgvPeluqueria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPeluqueria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeluqueria.Location = new System.Drawing.Point(30, 172);
            this.dgvPeluqueria.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPeluqueria.Name = "dgvPeluqueria";
            this.dgvPeluqueria.RowHeadersWidth = 51;
            this.dgvPeluqueria.Size = new System.Drawing.Size(1472, 676);
            this.dgvPeluqueria.TabIndex = 7;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(1402, 136);
            this.btnSimular.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(100, 28);
            this.btnSimular.TabIndex = 8;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // inputDias
            // 
            this.inputDias.Location = new System.Drawing.Point(219, 84);
            this.inputDias.Margin = new System.Windows.Forms.Padding(4);
            this.inputDias.Name = "inputDias";
            this.inputDias.Size = new System.Drawing.Size(160, 22);
            this.inputDias.TabIndex = 9;
            // 
            // inputIteraciones
            // 
            this.inputIteraciones.Location = new System.Drawing.Point(809, 84);
            this.inputIteraciones.Margin = new System.Windows.Forms.Padding(4);
            this.inputIteraciones.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.inputIteraciones.Name = "inputIteraciones";
            this.inputIteraciones.Size = new System.Drawing.Size(160, 22);
            this.inputIteraciones.TabIndex = 10;
            // 
            // inputHora
            // 
            this.inputHora.DecimalPlaces = 2;
            this.inputHora.Location = new System.Drawing.Point(1342, 84);
            this.inputHora.Margin = new System.Windows.Forms.Padding(4);
            this.inputHora.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.inputHora.Name = "inputHora";
            this.inputHora.Size = new System.Drawing.Size(160, 22);
            this.inputHora.TabIndex = 11;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.peluqueriaEventoDtoBindingSource;
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = global::sim_tp2.Properties.Resources._208478232_composición_con_tijeras_y_otros_accesorios_de_peluquería_sobre_fondo_blanco_vista_superior;
            this.ClientSize = new System.Drawing.Size(1918, 1018);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
            this.Name = "SistemaColas";
            this.Text = "SistemaColas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}