namespace sim_tp2
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
            this.checkBoxUniforme = new System.Windows.Forms.CheckBox();
            this.checkBoxExponencialNegativa = new System.Windows.Forms.CheckBox();
            this.checkBoxNormal = new System.Windows.Forms.CheckBox();
            this.listBoxVariablesAleatorias = new System.Windows.Forms.ListBox();
            this.labelMinimoUniforme = new System.Windows.Forms.Label();
            this.numericUpDownMinimoUniforme = new System.Windows.Forms.NumericUpDown();
            this.labelMaximoUniforme = new System.Windows.Forms.Label();
            this.numericUpDownMaximoUniforme = new System.Windows.Forms.NumericUpDown();
            this.labelLambdaExponencialNegativa = new System.Windows.Forms.Label();
            this.numericUpDownLambdaExponencialNegativa = new System.Windows.Forms.NumericUpDown();
            this.labelMediaNormal = new System.Windows.Forms.Label();
            this.labelDesviacion = new System.Windows.Forms.Label();
            this.numericUpDownMediaNormal = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDesviacionNormal = new System.Windows.Forms.NumericUpDown();
            this.labelIntervalos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownIntervalos = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMuestra = new System.Windows.Forms.NumericUpDown();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lblVariablesAleatorias = new System.Windows.Forms.Label();
            this.lblHistograma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimoUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximoUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLambdaExponencialNegativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMediaNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesviacionNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxUniforme
            // 
            this.checkBoxUniforme.AutoSize = true;
            this.checkBoxUniforme.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxUniforme.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUniforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxUniforme.Location = new System.Drawing.Point(26, 63);
            this.checkBoxUniforme.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxUniforme.Name = "checkBoxUniforme";
            this.checkBoxUniforme.Size = new System.Drawing.Size(91, 29);
            this.checkBoxUniforme.TabIndex = 0;
            this.checkBoxUniforme.Text = "Uniforme";
            this.checkBoxUniforme.UseVisualStyleBackColor = false;
            this.checkBoxUniforme.Click += new System.EventHandler(this.checkBoxUniforme_Click);
            // 
            // checkBoxExponencialNegativa
            // 
            this.checkBoxExponencialNegativa.AutoSize = true;
            this.checkBoxExponencialNegativa.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExponencialNegativa.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExponencialNegativa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxExponencialNegativa.Location = new System.Drawing.Point(254, 63);
            this.checkBoxExponencialNegativa.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxExponencialNegativa.Name = "checkBoxExponencialNegativa";
            this.checkBoxExponencialNegativa.Size = new System.Drawing.Size(175, 29);
            this.checkBoxExponencialNegativa.TabIndex = 1;
            this.checkBoxExponencialNegativa.Text = "Exponencial Negativa";
            this.checkBoxExponencialNegativa.UseVisualStyleBackColor = false;
            this.checkBoxExponencialNegativa.Click += new System.EventHandler(this.checkBoxExponencialNegativa_Click);
            // 
            // checkBoxNormal
            // 
            this.checkBoxNormal.AutoSize = true;
            this.checkBoxNormal.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxNormal.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNormal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxNormal.Location = new System.Drawing.Point(495, 63);
            this.checkBoxNormal.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxNormal.Name = "checkBoxNormal";
            this.checkBoxNormal.Size = new System.Drawing.Size(78, 29);
            this.checkBoxNormal.TabIndex = 2;
            this.checkBoxNormal.Text = "Normal";
            this.checkBoxNormal.UseVisualStyleBackColor = false;
            this.checkBoxNormal.Click += new System.EventHandler(this.checkBoxNormal_Click);
            // 
            // listBoxVariablesAleatorias
            // 
            this.listBoxVariablesAleatorias.FormattingEnabled = true;
            this.listBoxVariablesAleatorias.Location = new System.Drawing.Point(29, 286);
            this.listBoxVariablesAleatorias.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxVariablesAleatorias.Name = "listBoxVariablesAleatorias";
            this.listBoxVariablesAleatorias.Size = new System.Drawing.Size(215, 199);
            this.listBoxVariablesAleatorias.TabIndex = 3;
            // 
            // labelMinimoUniforme
            // 
            this.labelMinimoUniforme.AutoSize = true;
            this.labelMinimoUniforme.BackColor = System.Drawing.Color.Transparent;
            this.labelMinimoUniforme.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimoUniforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMinimoUniforme.Location = new System.Drawing.Point(24, 100);
            this.labelMinimoUniforme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinimoUniforme.Name = "labelMinimoUniforme";
            this.labelMinimoUniforme.Size = new System.Drawing.Size(61, 25);
            this.labelMinimoUniforme.TabIndex = 4;
            this.labelMinimoUniforme.Text = "Minimo";
            // 
            // numericUpDownMinimoUniforme
            // 
            this.numericUpDownMinimoUniforme.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownMinimoUniforme.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMinimoUniforme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownMinimoUniforme.Location = new System.Drawing.Point(101, 93);
            this.numericUpDownMinimoUniforme.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMinimoUniforme.Name = "numericUpDownMinimoUniforme";
            this.numericUpDownMinimoUniforme.Size = new System.Drawing.Size(90, 32);
            this.numericUpDownMinimoUniforme.TabIndex = 5;
            // 
            // labelMaximoUniforme
            // 
            this.labelMaximoUniforme.AutoSize = true;
            this.labelMaximoUniforme.BackColor = System.Drawing.Color.Transparent;
            this.labelMaximoUniforme.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaximoUniforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMaximoUniforme.Location = new System.Drawing.Point(22, 130);
            this.labelMaximoUniforme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaximoUniforme.Name = "labelMaximoUniforme";
            this.labelMaximoUniforme.Size = new System.Drawing.Size(63, 25);
            this.labelMaximoUniforme.TabIndex = 6;
            this.labelMaximoUniforme.Text = "Maximo";
            // 
            // numericUpDownMaximoUniforme
            // 
            this.numericUpDownMaximoUniforme.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownMaximoUniforme.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMaximoUniforme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownMaximoUniforme.Location = new System.Drawing.Point(101, 128);
            this.numericUpDownMaximoUniforme.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMaximoUniforme.Name = "numericUpDownMaximoUniforme";
            this.numericUpDownMaximoUniforme.Size = new System.Drawing.Size(90, 32);
            this.numericUpDownMaximoUniforme.TabIndex = 7;
            // 
            // labelLambdaExponencialNegativa
            // 
            this.labelLambdaExponencialNegativa.AutoSize = true;
            this.labelLambdaExponencialNegativa.BackColor = System.Drawing.Color.Transparent;
            this.labelLambdaExponencialNegativa.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLambdaExponencialNegativa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLambdaExponencialNegativa.Location = new System.Drawing.Point(249, 100);
            this.labelLambdaExponencialNegativa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLambdaExponencialNegativa.Name = "labelLambdaExponencialNegativa";
            this.labelLambdaExponencialNegativa.Size = new System.Drawing.Size(64, 25);
            this.labelLambdaExponencialNegativa.TabIndex = 8;
            this.labelLambdaExponencialNegativa.Text = "Lambda";
            // 
            // numericUpDownLambdaExponencialNegativa
            // 
            this.numericUpDownLambdaExponencialNegativa.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownLambdaExponencialNegativa.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLambdaExponencialNegativa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownLambdaExponencialNegativa.Location = new System.Drawing.Point(339, 98);
            this.numericUpDownLambdaExponencialNegativa.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownLambdaExponencialNegativa.Name = "numericUpDownLambdaExponencialNegativa";
            this.numericUpDownLambdaExponencialNegativa.Size = new System.Drawing.Size(90, 32);
            this.numericUpDownLambdaExponencialNegativa.TabIndex = 9;
            // 
            // labelMediaNormal
            // 
            this.labelMediaNormal.AutoSize = true;
            this.labelMediaNormal.BackColor = System.Drawing.Color.Transparent;
            this.labelMediaNormal.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMediaNormal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMediaNormal.Location = new System.Drawing.Point(499, 96);
            this.labelMediaNormal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMediaNormal.Name = "labelMediaNormal";
            this.labelMediaNormal.Size = new System.Drawing.Size(52, 25);
            this.labelMediaNormal.TabIndex = 10;
            this.labelMediaNormal.Text = "Media";
            // 
            // labelDesviacion
            // 
            this.labelDesviacion.AutoSize = true;
            this.labelDesviacion.BackColor = System.Drawing.Color.Transparent;
            this.labelDesviacion.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesviacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDesviacion.Location = new System.Drawing.Point(499, 133);
            this.labelDesviacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDesviacion.Name = "labelDesviacion";
            this.labelDesviacion.Size = new System.Drawing.Size(84, 25);
            this.labelDesviacion.TabIndex = 11;
            this.labelDesviacion.Text = "Desviacion";
            // 
            // numericUpDownMediaNormal
            // 
            this.numericUpDownMediaNormal.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownMediaNormal.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMediaNormal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownMediaNormal.Location = new System.Drawing.Point(576, 94);
            this.numericUpDownMediaNormal.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMediaNormal.Name = "numericUpDownMediaNormal";
            this.numericUpDownMediaNormal.Size = new System.Drawing.Size(90, 32);
            this.numericUpDownMediaNormal.TabIndex = 12;
            // 
            // numericUpDownDesviacionNormal
            // 
            this.numericUpDownDesviacionNormal.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownDesviacionNormal.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDesviacionNormal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownDesviacionNormal.Location = new System.Drawing.Point(576, 128);
            this.numericUpDownDesviacionNormal.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownDesviacionNormal.Name = "numericUpDownDesviacionNormal";
            this.numericUpDownDesviacionNormal.Size = new System.Drawing.Size(90, 32);
            this.numericUpDownDesviacionNormal.TabIndex = 13;
            // 
            // labelIntervalos
            // 
            this.labelIntervalos.AutoSize = true;
            this.labelIntervalos.BackColor = System.Drawing.Color.Transparent;
            this.labelIntervalos.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntervalos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIntervalos.Location = new System.Drawing.Point(27, 196);
            this.labelIntervalos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIntervalos.Name = "labelIntervalos";
            this.labelIntervalos.Size = new System.Drawing.Size(78, 25);
            this.labelIntervalos.TabIndex = 14;
            this.labelIntervalos.Text = "Intervalos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(252, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tamaño Muestra";
            // 
            // numericUpDownIntervalos
            // 
            this.numericUpDownIntervalos.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownIntervalos.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownIntervalos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownIntervalos.Location = new System.Drawing.Point(125, 194);
            this.numericUpDownIntervalos.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownIntervalos.Name = "numericUpDownIntervalos";
            this.numericUpDownIntervalos.Size = new System.Drawing.Size(90, 32);
            this.numericUpDownIntervalos.TabIndex = 16;
            // 
            // numericUpDownMuestra
            // 
            this.numericUpDownMuestra.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownMuestra.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMuestra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownMuestra.Location = new System.Drawing.Point(391, 192);
            this.numericUpDownMuestra.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMuestra.Name = "numericUpDownMuestra";
            this.numericUpDownMuestra.Size = new System.Drawing.Size(90, 32);
            this.numericUpDownMuestra.TabIndex = 17;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(603, 376);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(2);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 28);
            this.btn_calcular.TabIndex = 18;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lblVariablesAleatorias
            // 
            this.lblVariablesAleatorias.AutoSize = true;
            this.lblVariablesAleatorias.BackColor = System.Drawing.Color.Transparent;
            this.lblVariablesAleatorias.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariablesAleatorias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVariablesAleatorias.Location = new System.Drawing.Point(24, 259);
            this.lblVariablesAleatorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVariablesAleatorias.Name = "lblVariablesAleatorias";
            this.lblVariablesAleatorias.Size = new System.Drawing.Size(220, 25);
            this.lblVariablesAleatorias.TabIndex = 19;
            this.lblVariablesAleatorias.Text = "Variables aleatorias generadas";
            // 
            // lblHistograma
            // 
            this.lblHistograma.AutoSize = true;
            this.lblHistograma.BackColor = System.Drawing.Color.Transparent;
            this.lblHistograma.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistograma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHistograma.Location = new System.Drawing.Point(334, 259);
            this.lblHistograma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistograma.Name = "lblHistograma";
            this.lblHistograma.Size = new System.Drawing.Size(88, 25);
            this.lblHistograma.TabIndex = 20;
            this.lblHistograma.Text = "Histograma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::sim_tp2.Properties.Resources.blue_images_for_backgrounds_desktop_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 593);
            this.Controls.Add(this.lblHistograma);
            this.Controls.Add(this.lblVariablesAleatorias);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.numericUpDownMuestra);
            this.Controls.Add(this.numericUpDownIntervalos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIntervalos);
            this.Controls.Add(this.numericUpDownDesviacionNormal);
            this.Controls.Add(this.numericUpDownMediaNormal);
            this.Controls.Add(this.labelDesviacion);
            this.Controls.Add(this.labelMediaNormal);
            this.Controls.Add(this.numericUpDownLambdaExponencialNegativa);
            this.Controls.Add(this.labelLambdaExponencialNegativa);
            this.Controls.Add(this.numericUpDownMaximoUniforme);
            this.Controls.Add(this.labelMaximoUniforme);
            this.Controls.Add(this.numericUpDownMinimoUniforme);
            this.Controls.Add(this.labelMinimoUniforme);
            this.Controls.Add(this.listBoxVariablesAleatorias);
            this.Controls.Add(this.checkBoxNormal);
            this.Controls.Add(this.checkBoxExponencialNegativa);
            this.Controls.Add(this.checkBoxUniforme);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimoUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximoUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLambdaExponencialNegativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMediaNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesviacionNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMuestra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxUniforme;
        private System.Windows.Forms.CheckBox checkBoxExponencialNegativa;
        private System.Windows.Forms.CheckBox checkBoxNormal;
        private System.Windows.Forms.ListBox listBoxVariablesAleatorias;
        private System.Windows.Forms.Label labelMinimoUniforme;
        private System.Windows.Forms.NumericUpDown numericUpDownMinimoUniforme;
        private System.Windows.Forms.Label labelMaximoUniforme;
        private System.Windows.Forms.NumericUpDown numericUpDownMaximoUniforme;
        private System.Windows.Forms.Label labelLambdaExponencialNegativa;
        private System.Windows.Forms.NumericUpDown numericUpDownLambdaExponencialNegativa;
        private System.Windows.Forms.Label labelMediaNormal;
        private System.Windows.Forms.Label labelDesviacion;
        private System.Windows.Forms.NumericUpDown numericUpDownMediaNormal;
        private System.Windows.Forms.NumericUpDown numericUpDownDesviacionNormal;
        private System.Windows.Forms.Label labelIntervalos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalos;
        private System.Windows.Forms.NumericUpDown numericUpDownMuestra;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lblVariablesAleatorias;
        private System.Windows.Forms.Label lblHistograma;
    }
}

