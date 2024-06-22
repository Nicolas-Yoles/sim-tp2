using sim_tp2.Utilities;

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
            this.btnSimular = new System.Windows.Forms.Button();
            this.inputDias = new System.Windows.Forms.NumericUpDown();
            this.inputIteraciones = new System.Windows.Forms.NumericUpDown();
            this.inputHora = new System.Windows.Forms.NumericUpDown();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.eulerButton = new System.Windows.Forms.Button();
            this.cerrarButton = new System.Windows.Forms.Button();
            this.dgvPeluqueria = new sim_tp2.Utilities.DoubleBufferedDataGridView();
            this.peluqueriaEventoDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servidorDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputIteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeluqueria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peluqueriaEventoDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servidorDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTiempo.Location = new System.Drawing.Point(209, 61);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(97, 17);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Dias a simular";
            this.lblTiempo.Click += new System.EventHandler(this.lblTiempo_Click);
            // 
            // lblPeluqueria
            // 
            this.lblPeluqueria.AutoSize = true;
            this.lblPeluqueria.BackColor = System.Drawing.Color.Transparent;
            this.lblPeluqueria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblPeluqueria.Location = new System.Drawing.Point(650, 9);
            this.lblPeluqueria.Name = "lblPeluqueria";
            this.lblPeluqueria.Size = new System.Drawing.Size(173, 29);
            this.lblPeluqueria.TabIndex = 2;
            this.lblPeluqueria.Text = "Peluqueria VIP";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.BackColor = System.Drawing.Color.Transparent;
            this.lblIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIteraciones.Location = new System.Drawing.Point(165, 88);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(141, 17);
            this.lblIteraciones.TabIndex = 5;
            this.lblIteraciones.Text = "Iteraciones a mostrar";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHora.Location = new System.Drawing.Point(160, 114);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(146, 17);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora desde a mostrar";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimular.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSimular.Location = new System.Drawing.Point(488, 61);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(192, 30);
            this.btnSimular.TabIndex = 8;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // inputDias
            // 
            this.inputDias.Location = new System.Drawing.Point(312, 62);
            this.inputDias.Name = "inputDias";
            this.inputDias.Size = new System.Drawing.Size(120, 20);
            this.inputDias.TabIndex = 9;
            // 
            // inputIteraciones
            // 
            this.inputIteraciones.Location = new System.Drawing.Point(312, 88);
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
            this.inputHora.Location = new System.Drawing.Point(312, 114);
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
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(312, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Configurar parámetros de distribución";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eulerButton
            // 
            this.eulerButton.Enabled = false;
            this.eulerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.eulerButton.Location = new System.Drawing.Point(488, 97);
            this.eulerButton.Name = "eulerButton";
            this.eulerButton.Size = new System.Drawing.Size(192, 34);
            this.eulerButton.TabIndex = 13;
            this.eulerButton.Text = "Consultar tabla Euler";
            this.eulerButton.UseVisualStyleBackColor = true;
            this.eulerButton.Visible = false;
            this.eulerButton.Click += new System.EventHandler(this.eulerButton_Click);
            // 
            // cerrarButton
            // 
            this.cerrarButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cerrarButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.cerrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.cerrarButton.ForeColor = System.Drawing.Color.Black;
            this.cerrarButton.Location = new System.Drawing.Point(73, 40);
            this.cerrarButton.Name = "cerrarButton";
            this.cerrarButton.Size = new System.Drawing.Size(46, 42);
            this.cerrarButton.TabIndex = 14;
            this.cerrarButton.Text = "X";
            this.cerrarButton.UseVisualStyleBackColor = false;
            this.cerrarButton.Click += new System.EventHandler(this.cerrarButton_Click);
            // 
            // dgvPeluqueria
            // 
            this.dgvPeluqueria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPeluqueria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeluqueria.Location = new System.Drawing.Point(73, 212);
            this.dgvPeluqueria.Name = "dgvPeluqueria";
            this.dgvPeluqueria.ReadOnly = true;
            this.dgvPeluqueria.RowHeadersWidth = 51;
            this.dgvPeluqueria.Size = new System.Drawing.Size(1300, 550);
            this.dgvPeluqueria.TabIndex = 7;
            this.dgvPeluqueria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeluqueria_CellContentClick);
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
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1438, 827);
            this.Controls.Add(this.cerrarButton);
            this.Controls.Add(this.eulerButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.inputDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputIteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeluqueria)).EndInit();
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
        private DoubleBufferedDataGridView dgvPeluqueria;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.NumericUpDown inputDias;
        private System.Windows.Forms.NumericUpDown inputIteraciones;
        private System.Windows.Forms.NumericUpDown inputHora;
        private System.Windows.Forms.BindingSource peluqueriaEventoDtoBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingSource servidorDtoBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button eulerButton;
        private System.Windows.Forms.Button cerrarButton;
    }
}