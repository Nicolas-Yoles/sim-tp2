﻿namespace sim_tp2.Views
{
    partial class SistemaContinuoEuler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownProbabilidadAprendiz = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownVeteranoA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownTiempoAprendiz = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTiempoCorteVeterano = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownLimiteInferiorCliente = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownLimiteSuperiorCliente = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProbabilidadAprendiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVeteranoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiempoAprendiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiempoCorteVeterano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimiteInferiorCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimiteSuperiorCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parámetros de distribucion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Probabilidad de Atencion Aprendiz";
            // 
            // numericUpDownProbabilidadAprendiz
            // 
            this.numericUpDownProbabilidadAprendiz.DecimalPlaces = 2;
            this.numericUpDownProbabilidadAprendiz.Location = new System.Drawing.Point(352, 155);
            this.numericUpDownProbabilidadAprendiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownProbabilidadAprendiz.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownProbabilidadAprendiz.Name = "numericUpDownProbabilidadAprendiz";
            this.numericUpDownProbabilidadAprendiz.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownProbabilidadAprendiz.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Probabilidad de Atencion Veterano A";
            // 
            // numericUpDownVeteranoA
            // 
            this.numericUpDownVeteranoA.DecimalPlaces = 2;
            this.numericUpDownVeteranoA.Location = new System.Drawing.Point(352, 185);
            this.numericUpDownVeteranoA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownVeteranoA.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVeteranoA.Name = "numericUpDownVeteranoA";
            this.numericUpDownVeteranoA.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownVeteranoA.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tiempo de demora de Aprendiz (Ta)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDownTiempoAprendiz
            // 
            this.numericUpDownTiempoAprendiz.Location = new System.Drawing.Point(352, 66);
            this.numericUpDownTiempoAprendiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownTiempoAprendiz.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDownTiempoAprendiz.Name = "numericUpDownTiempoAprendiz";
            this.numericUpDownTiempoAprendiz.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTiempoAprendiz.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tiempo de demora de Veteranos (Tv)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDownTiempoCorteVeterano
            // 
            this.numericUpDownTiempoCorteVeterano.Location = new System.Drawing.Point(352, 96);
            this.numericUpDownTiempoCorteVeterano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownTiempoCorteVeterano.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericUpDownTiempoCorteVeterano.Name = "numericUpDownTiempoCorteVeterano";
            this.numericUpDownTiempoCorteVeterano.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTiempoCorteVeterano.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(325, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cliente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(253, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Límite inferior";
            // 
            // numericUpDownLimiteInferiorCliente
            // 
            this.numericUpDownLimiteInferiorCliente.Location = new System.Drawing.Point(352, 256);
            this.numericUpDownLimiteInferiorCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownLimiteInferiorCliente.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
            this.numericUpDownLimiteInferiorCliente.Name = "numericUpDownLimiteInferiorCliente";
            this.numericUpDownLimiteInferiorCliente.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLimiteInferiorCliente.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(245, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "Límite superior";
            // 
            // numericUpDownLimiteSuperiorCliente
            // 
            this.numericUpDownLimiteSuperiorCliente.Location = new System.Drawing.Point(352, 286);
            this.numericUpDownLimiteSuperiorCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownLimiteSuperiorCliente.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.numericUpDownLimiteSuperiorCliente.Name = "numericUpDownLimiteSuperiorCliente";
            this.numericUpDownLimiteSuperiorCliente.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLimiteSuperiorCliente.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tamaño del paso de integración (h)";
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.DecimalPlaces = 2;
            this.numericUpDownH.Location = new System.Drawing.Point(352, 126);
            this.numericUpDownH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownH.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownH.TabIndex = 29;
            // 
            // SistemaContinuoEuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 388);
            this.Controls.Add(this.numericUpDownH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownLimiteSuperiorCliente);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numericUpDownLimiteInferiorCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericUpDownTiempoCorteVeterano);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownTiempoAprendiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownVeteranoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownProbabilidadAprendiz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SistemaContinuoEuler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parámetros";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProbabilidadAprendiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVeteranoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiempoAprendiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiempoCorteVeterano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimiteInferiorCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimiteSuperiorCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownProbabilidadAprendiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownVeteranoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTiempoAprendiz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownTiempoCorteVeterano;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownLimiteInferiorCliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownLimiteSuperiorCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownH;
    }
}