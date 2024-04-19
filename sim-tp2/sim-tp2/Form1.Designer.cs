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
            this.button1 = new System.Windows.Forms.Button();
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
            this.checkBoxUniforme.Location = new System.Drawing.Point(40, 76);
            this.checkBoxUniforme.Name = "checkBoxUniforme";
            this.checkBoxUniforme.Size = new System.Drawing.Size(83, 20);
            this.checkBoxUniforme.TabIndex = 0;
            this.checkBoxUniforme.Text = "Uniforme";
            this.checkBoxUniforme.UseVisualStyleBackColor = true;
            this.checkBoxUniforme.Click += new System.EventHandler(this.checkBoxUniforme_Click);
            // 
            // checkBoxExponencialNegativa
            // 
            this.checkBoxExponencialNegativa.AutoSize = true;
            this.checkBoxExponencialNegativa.Location = new System.Drawing.Point(344, 76);
            this.checkBoxExponencialNegativa.Name = "checkBoxExponencialNegativa";
            this.checkBoxExponencialNegativa.Size = new System.Drawing.Size(161, 20);
            this.checkBoxExponencialNegativa.TabIndex = 1;
            this.checkBoxExponencialNegativa.Text = "Exponencial Negativa";
            this.checkBoxExponencialNegativa.UseVisualStyleBackColor = true;
            this.checkBoxExponencialNegativa.Click += new System.EventHandler(this.checkBoxExponencialNegativa_Click);
            // 
            // checkBoxNormal
            // 
            this.checkBoxNormal.AutoSize = true;
            this.checkBoxNormal.Location = new System.Drawing.Point(704, 76);
            this.checkBoxNormal.Name = "checkBoxNormal";
            this.checkBoxNormal.Size = new System.Drawing.Size(73, 20);
            this.checkBoxNormal.TabIndex = 2;
            this.checkBoxNormal.Text = "Normal";
            this.checkBoxNormal.UseVisualStyleBackColor = true;
            this.checkBoxNormal.Click += new System.EventHandler(this.checkBoxNormal_Click);
            // 
            // listBoxVariablesAleatorias
            // 
            this.listBoxVariablesAleatorias.FormattingEnabled = true;
            this.listBoxVariablesAleatorias.ItemHeight = 16;
            this.listBoxVariablesAleatorias.Location = new System.Drawing.Point(907, 53);
            this.listBoxVariablesAleatorias.Name = "listBoxVariablesAleatorias";
            this.listBoxVariablesAleatorias.Size = new System.Drawing.Size(286, 660);
            this.listBoxVariablesAleatorias.TabIndex = 3;
            // 
            // labelMinimoUniforme
            // 
            this.labelMinimoUniforme.AutoSize = true;
            this.labelMinimoUniforme.Location = new System.Drawing.Point(37, 119);
            this.labelMinimoUniforme.Name = "labelMinimoUniforme";
            this.labelMinimoUniforme.Size = new System.Drawing.Size(50, 16);
            this.labelMinimoUniforme.TabIndex = 4;
            this.labelMinimoUniforme.Text = "Minimo";
            // 
            // numericUpDownMinimoUniforme
            // 
            this.numericUpDownMinimoUniforme.Location = new System.Drawing.Point(93, 119);
            this.numericUpDownMinimoUniforme.Name = "numericUpDownMinimoUniforme";
            this.numericUpDownMinimoUniforme.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMinimoUniforme.TabIndex = 5;
            // 
            // labelMaximoUniforme
            // 
            this.labelMaximoUniforme.AutoSize = true;
            this.labelMaximoUniforme.Location = new System.Drawing.Point(37, 159);
            this.labelMaximoUniforme.Name = "labelMaximoUniforme";
            this.labelMaximoUniforme.Size = new System.Drawing.Size(54, 16);
            this.labelMaximoUniforme.TabIndex = 6;
            this.labelMaximoUniforme.Text = "Maximo";
            // 
            // numericUpDownMaximoUniforme
            // 
            this.numericUpDownMaximoUniforme.Location = new System.Drawing.Point(93, 159);
            this.numericUpDownMaximoUniforme.Name = "numericUpDownMaximoUniforme";
            this.numericUpDownMaximoUniforme.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMaximoUniforme.TabIndex = 7;
            // 
            // labelLambdaExponencialNegativa
            // 
            this.labelLambdaExponencialNegativa.AutoSize = true;
            this.labelLambdaExponencialNegativa.Location = new System.Drawing.Point(341, 118);
            this.labelLambdaExponencialNegativa.Name = "labelLambdaExponencialNegativa";
            this.labelLambdaExponencialNegativa.Size = new System.Drawing.Size(57, 16);
            this.labelLambdaExponencialNegativa.TabIndex = 8;
            this.labelLambdaExponencialNegativa.Text = "Lambda";
            // 
            // numericUpDownLambdaExponencialNegativa
            // 
            this.numericUpDownLambdaExponencialNegativa.Location = new System.Drawing.Point(405, 119);
            this.numericUpDownLambdaExponencialNegativa.Name = "numericUpDownLambdaExponencialNegativa";
            this.numericUpDownLambdaExponencialNegativa.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLambdaExponencialNegativa.TabIndex = 9;
            // 
            // labelMediaNormal
            // 
            this.labelMediaNormal.AutoSize = true;
            this.labelMediaNormal.Location = new System.Drawing.Point(701, 117);
            this.labelMediaNormal.Name = "labelMediaNormal";
            this.labelMediaNormal.Size = new System.Drawing.Size(45, 16);
            this.labelMediaNormal.TabIndex = 10;
            this.labelMediaNormal.Text = "Media";
            // 
            // labelDesviacion
            // 
            this.labelDesviacion.AutoSize = true;
            this.labelDesviacion.Location = new System.Drawing.Point(671, 162);
            this.labelDesviacion.Name = "labelDesviacion";
            this.labelDesviacion.Size = new System.Drawing.Size(75, 16);
            this.labelDesviacion.TabIndex = 11;
            this.labelDesviacion.Text = "Desviacion";
            // 
            // numericUpDownMediaNormal
            // 
            this.numericUpDownMediaNormal.Location = new System.Drawing.Point(752, 115);
            this.numericUpDownMediaNormal.Name = "numericUpDownMediaNormal";
            this.numericUpDownMediaNormal.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMediaNormal.TabIndex = 12;
            // 
            // numericUpDownDesviacionNormal
            // 
            this.numericUpDownDesviacionNormal.Location = new System.Drawing.Point(752, 160);
            this.numericUpDownDesviacionNormal.Name = "numericUpDownDesviacionNormal";
            this.numericUpDownDesviacionNormal.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDesviacionNormal.TabIndex = 13;
            // 
            // labelIntervalos
            // 
            this.labelIntervalos.AutoSize = true;
            this.labelIntervalos.Location = new System.Drawing.Point(153, 32);
            this.labelIntervalos.Name = "labelIntervalos";
            this.labelIntervalos.Size = new System.Drawing.Size(65, 16);
            this.labelIntervalos.TabIndex = 14;
            this.labelIntervalos.Text = "Intervalos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tamaño Muestra";
            // 
            // numericUpDownIntervalos
            // 
            this.numericUpDownIntervalos.Location = new System.Drawing.Point(239, 32);
            this.numericUpDownIntervalos.Name = "numericUpDownIntervalos";
            this.numericUpDownIntervalos.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownIntervalos.TabIndex = 16;
            // 
            // numericUpDownMuestra
            // 
            this.numericUpDownMuestra.Location = new System.Drawing.Point(655, 31);
            this.numericUpDownMuestra.Name = "numericUpDownMuestra";
            this.numericUpDownMuestra.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMuestra.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(768, 679);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 730);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}

