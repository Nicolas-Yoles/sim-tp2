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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.lblMuestra = new System.Windows.Forms.Label();
            this.numericUpDownIntervalos = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMuestra = new System.Windows.Forms.NumericUpDown();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lblVariablesAleatorias = new System.Windows.Forms.Label();
            this.lblHistograma = new System.Windows.Forms.Label();
            this.chartDistribucion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGrilla = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSimulacion = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimoUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximoUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLambdaExponencialNegativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMediaNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesviacionNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMuestra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistribucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxUniforme
            // 
            this.checkBoxUniforme.AutoSize = true;
            this.checkBoxUniforme.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxUniforme.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUniforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxUniforme.Location = new System.Drawing.Point(128, 87);
            this.checkBoxUniforme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxUniforme.Name = "checkBoxUniforme";
            this.checkBoxUniforme.Size = new System.Drawing.Size(145, 39);
            this.checkBoxUniforme.TabIndex = 0;
            this.checkBoxUniforme.Text = "Uniforme";
            this.checkBoxUniforme.UseVisualStyleBackColor = false;
            this.checkBoxUniforme.Click += new System.EventHandler(this.checkBoxUniforme_Click);
            // 
            // checkBoxExponencialNegativa
            // 
            this.checkBoxExponencialNegativa.AutoSize = true;
            this.checkBoxExponencialNegativa.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExponencialNegativa.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExponencialNegativa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxExponencialNegativa.Location = new System.Drawing.Point(448, 87);
            this.checkBoxExponencialNegativa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxExponencialNegativa.Name = "checkBoxExponencialNegativa";
            this.checkBoxExponencialNegativa.Size = new System.Drawing.Size(279, 39);
            this.checkBoxExponencialNegativa.TabIndex = 1;
            this.checkBoxExponencialNegativa.Text = "Exponencial Negativa";
            this.checkBoxExponencialNegativa.UseVisualStyleBackColor = false;
            this.checkBoxExponencialNegativa.Click += new System.EventHandler(this.checkBoxExponencialNegativa_Click);
            // 
            // checkBoxNormal
            // 
            this.checkBoxNormal.AutoSize = true;
            this.checkBoxNormal.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxNormal.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNormal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxNormal.Location = new System.Drawing.Point(898, 87);
            this.checkBoxNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxNormal.Name = "checkBoxNormal";
            this.checkBoxNormal.Size = new System.Drawing.Size(121, 39);
            this.checkBoxNormal.TabIndex = 2;
            this.checkBoxNormal.Text = "Normal";
            this.checkBoxNormal.UseVisualStyleBackColor = false;
            this.checkBoxNormal.Click += new System.EventHandler(this.checkBoxNormal_Click);
            // 
            // listBoxVariablesAleatorias
            // 
            this.listBoxVariablesAleatorias.FormattingEnabled = true;
            this.listBoxVariablesAleatorias.ItemHeight = 16;
            this.listBoxVariablesAleatorias.Location = new System.Drawing.Point(59, 420);
            this.listBoxVariablesAleatorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxVariablesAleatorias.Name = "listBoxVariablesAleatorias";
            this.listBoxVariablesAleatorias.Size = new System.Drawing.Size(250, 596);
            this.listBoxVariablesAleatorias.TabIndex = 3;
            // 
            // labelMinimoUniforme
            // 
            this.labelMinimoUniforme.AutoSize = true;
            this.labelMinimoUniforme.BackColor = System.Drawing.Color.Transparent;
            this.labelMinimoUniforme.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelMinimoUniforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMinimoUniforme.Location = new System.Drawing.Point(125, 132);
            this.labelMinimoUniforme.Name = "labelMinimoUniforme";
            this.labelMinimoUniforme.Size = new System.Drawing.Size(75, 24);
            this.labelMinimoUniforme.TabIndex = 4;
            this.labelMinimoUniforme.Text = "Mínimo";
            // 
            // numericUpDownMinimoUniforme
            // 
            this.numericUpDownMinimoUniforme.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownMinimoUniforme.Font = new System.Drawing.Font("Calibri", 12F);
            this.numericUpDownMinimoUniforme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownMinimoUniforme.Location = new System.Drawing.Point(262, 125);
            this.numericUpDownMinimoUniforme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMinimoUniforme.Name = "numericUpDownMinimoUniforme";
            this.numericUpDownMinimoUniforme.Size = new System.Drawing.Size(120, 32);
            this.numericUpDownMinimoUniforme.TabIndex = 5;
            // 
            // labelMaximoUniforme
            // 
            this.labelMaximoUniforme.AutoSize = true;
            this.labelMaximoUniforme.BackColor = System.Drawing.Color.Transparent;
            this.labelMaximoUniforme.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelMaximoUniforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMaximoUniforme.Location = new System.Drawing.Point(123, 169);
            this.labelMaximoUniforme.Name = "labelMaximoUniforme";
            this.labelMaximoUniforme.Size = new System.Drawing.Size(78, 24);
            this.labelMaximoUniforme.TabIndex = 6;
            this.labelMaximoUniforme.Text = "Máximo";
            // 
            // numericUpDownMaximoUniforme
            // 
            this.numericUpDownMaximoUniforme.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownMaximoUniforme.Font = new System.Drawing.Font("Calibri", 12F);
            this.numericUpDownMaximoUniforme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownMaximoUniforme.Location = new System.Drawing.Point(262, 168);
            this.numericUpDownMaximoUniforme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMaximoUniforme.Name = "numericUpDownMaximoUniforme";
            this.numericUpDownMaximoUniforme.Size = new System.Drawing.Size(120, 32);
            this.numericUpDownMaximoUniforme.TabIndex = 7;
            // 
            // labelLambdaExponencialNegativa
            // 
            this.labelLambdaExponencialNegativa.AutoSize = true;
            this.labelLambdaExponencialNegativa.BackColor = System.Drawing.Color.Transparent;
            this.labelLambdaExponencialNegativa.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelLambdaExponencialNegativa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLambdaExponencialNegativa.Location = new System.Drawing.Point(452, 132);
            this.labelLambdaExponencialNegativa.Name = "labelLambdaExponencialNegativa";
            this.labelLambdaExponencialNegativa.Size = new System.Drawing.Size(76, 24);
            this.labelLambdaExponencialNegativa.TabIndex = 8;
            this.labelLambdaExponencialNegativa.Text = "Lambda";
            // 
            // numericUpDownLambdaExponencialNegativa
            // 
            this.numericUpDownLambdaExponencialNegativa.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownLambdaExponencialNegativa.Font = new System.Drawing.Font("Calibri", 12F);
            this.numericUpDownLambdaExponencialNegativa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownLambdaExponencialNegativa.Location = new System.Drawing.Point(572, 130);
            this.numericUpDownLambdaExponencialNegativa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownLambdaExponencialNegativa.Name = "numericUpDownLambdaExponencialNegativa";
            this.numericUpDownLambdaExponencialNegativa.Size = new System.Drawing.Size(120, 32);
            this.numericUpDownLambdaExponencialNegativa.TabIndex = 9;
            // 
            // labelMediaNormal
            // 
            this.labelMediaNormal.AutoSize = true;
            this.labelMediaNormal.BackColor = System.Drawing.Color.Transparent;
            this.labelMediaNormal.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelMediaNormal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMediaNormal.Location = new System.Drawing.Point(891, 125);
            this.labelMediaNormal.Name = "labelMediaNormal";
            this.labelMediaNormal.Size = new System.Drawing.Size(63, 24);
            this.labelMediaNormal.TabIndex = 10;
            this.labelMediaNormal.Text = "Media";
            // 
            // labelDesviacion
            // 
            this.labelDesviacion.AutoSize = true;
            this.labelDesviacion.BackColor = System.Drawing.Color.Transparent;
            this.labelDesviacion.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelDesviacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDesviacion.Location = new System.Drawing.Point(888, 169);
            this.labelDesviacion.Name = "labelDesviacion";
            this.labelDesviacion.Size = new System.Drawing.Size(99, 24);
            this.labelDesviacion.TabIndex = 11;
            this.labelDesviacion.Text = "Desviación";
            // 
            // numericUpDownMediaNormal
            // 
            this.numericUpDownMediaNormal.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownMediaNormal.Font = new System.Drawing.Font("Calibri", 12F);
            this.numericUpDownMediaNormal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownMediaNormal.Location = new System.Drawing.Point(1041, 125);
            this.numericUpDownMediaNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMediaNormal.Name = "numericUpDownMediaNormal";
            this.numericUpDownMediaNormal.Size = new System.Drawing.Size(120, 32);
            this.numericUpDownMediaNormal.TabIndex = 12;
            // 
            // numericUpDownDesviacionNormal
            // 
            this.numericUpDownDesviacionNormal.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownDesviacionNormal.Font = new System.Drawing.Font("Calibri", 12F);
            this.numericUpDownDesviacionNormal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownDesviacionNormal.Location = new System.Drawing.Point(1041, 167);
            this.numericUpDownDesviacionNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDesviacionNormal.Name = "numericUpDownDesviacionNormal";
            this.numericUpDownDesviacionNormal.Size = new System.Drawing.Size(120, 32);
            this.numericUpDownDesviacionNormal.TabIndex = 13;
            // 
            // labelIntervalos
            // 
            this.labelIntervalos.AutoSize = true;
            this.labelIntervalos.BackColor = System.Drawing.Color.Transparent;
            this.labelIntervalos.Font = new System.Drawing.Font("Calibri", 14F);
            this.labelIntervalos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIntervalos.Location = new System.Drawing.Point(1630, 235);
            this.labelIntervalos.Name = "labelIntervalos";
            this.labelIntervalos.Size = new System.Drawing.Size(111, 29);
            this.labelIntervalos.TabIndex = 14;
            this.labelIntervalos.Text = "Intervalos";
            // 
            // lblMuestra
            // 
            this.lblMuestra.AutoSize = true;
            this.lblMuestra.BackColor = System.Drawing.Color.Transparent;
            this.lblMuestra.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblMuestra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMuestra.Location = new System.Drawing.Point(1561, 279);
            this.lblMuestra.Name = "lblMuestra";
            this.lblMuestra.Size = new System.Drawing.Size(180, 29);
            this.lblMuestra.TabIndex = 15;
            this.lblMuestra.Text = "Tamaño Muestra";
            // 
            // numericUpDownIntervalos
            // 
            this.numericUpDownIntervalos.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownIntervalos.Font = new System.Drawing.Font("Calibri", 14F);
            this.numericUpDownIntervalos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownIntervalos.Location = new System.Drawing.Point(1747, 233);
            this.numericUpDownIntervalos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownIntervalos.Name = "numericUpDownIntervalos";
            this.numericUpDownIntervalos.Size = new System.Drawing.Size(120, 36);
            this.numericUpDownIntervalos.TabIndex = 16;
            // 
            // numericUpDownMuestra
            // 
            this.numericUpDownMuestra.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownMuestra.Font = new System.Drawing.Font("Calibri", 14F);
            this.numericUpDownMuestra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDownMuestra.Location = new System.Drawing.Point(1747, 279);
            this.numericUpDownMuestra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMuestra.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMuestra.Name = "numericUpDownMuestra";
            this.numericUpDownMuestra.Size = new System.Drawing.Size(120, 36);
            this.numericUpDownMuestra.TabIndex = 17;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_calcular.Location = new System.Drawing.Point(1734, 344);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(133, 34);
            this.btn_calcular.TabIndex = 18;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lblVariablesAleatorias
            // 
            this.lblVariablesAleatorias.AutoSize = true;
            this.lblVariablesAleatorias.BackColor = System.Drawing.Color.Transparent;
            this.lblVariablesAleatorias.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblVariablesAleatorias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVariablesAleatorias.Location = new System.Drawing.Point(53, 387);
            this.lblVariablesAleatorias.Name = "lblVariablesAleatorias";
            this.lblVariablesAleatorias.Size = new System.Drawing.Size(314, 29);
            this.lblVariablesAleatorias.TabIndex = 19;
            this.lblVariablesAleatorias.Text = "Variables aleatorias generadas";
            // 
            // lblHistograma
            // 
            this.lblHistograma.AutoSize = true;
            this.lblHistograma.BackColor = System.Drawing.Color.Transparent;
            this.lblHistograma.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblHistograma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHistograma.Location = new System.Drawing.Point(387, 387);
            this.lblHistograma.Name = "lblHistograma";
            this.lblHistograma.Size = new System.Drawing.Size(126, 29);
            this.lblHistograma.TabIndex = 20;
            this.lblHistograma.Text = "Histograma";
            // 
            // chartDistribucion
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDistribucion.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDistribucion.Legends.Add(legend3);
            this.chartDistribucion.Location = new System.Drawing.Point(393, 420);
            this.chartDistribucion.Margin = new System.Windows.Forms.Padding(4);
            this.chartDistribucion.Name = "chartDistribucion";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDistribucion.Series.Add(series3);
            this.chartDistribucion.Size = new System.Drawing.Size(700, 600);
            this.chartDistribucion.TabIndex = 21;
            this.chartDistribucion.Text = "chart1";
            // 
            // lblGrilla
            // 
            this.lblGrilla.AutoSize = true;
            this.lblGrilla.BackColor = System.Drawing.Color.Transparent;
            this.lblGrilla.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblGrilla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGrilla.Location = new System.Drawing.Point(1161, 385);
            this.lblGrilla.Name = "lblGrilla";
            this.lblGrilla.Size = new System.Drawing.Size(66, 29);
            this.lblGrilla.TabIndex = 22;
            this.lblGrilla.Text = "Grilla";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvDatos.Location = new System.Drawing.Point(1167, 420);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(700, 600);
            this.dgvDatos.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Li";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ls";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marca de Clase";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "fo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "fe";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fo Ac";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fe Ac";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // lblSimulacion
            // 
            this.lblSimulacion.AutoSize = true;
            this.lblSimulacion.BackColor = System.Drawing.Color.Transparent;
            this.lblSimulacion.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSimulacion.Location = new System.Drawing.Point(7, 9);
            this.lblSimulacion.Name = "lblSimulacion";
            this.lblSimulacion.Size = new System.Drawing.Size(330, 45);
            this.lblSimulacion.TabIndex = 24;
            this.lblSimulacion.Text = "Trabajo práctico Nº2";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar.Location = new System.Drawing.Point(1581, 344);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(130, 34);
            this.btn_limpiar.TabIndex = 25;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::sim_tp2.Properties.Resources.blue_images_for_backgrounds_desktop_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.lblSimulacion);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblGrilla);
            this.Controls.Add(this.chartDistribucion);
            this.Controls.Add(this.lblHistograma);
            this.Controls.Add(this.lblVariablesAleatorias);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.numericUpDownMuestra);
            this.Controls.Add(this.numericUpDownIntervalos);
            this.Controls.Add(this.lblMuestra);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimoUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximoUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLambdaExponencialNegativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMediaNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesviacionNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMuestra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistribucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
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
        private System.Windows.Forms.Label lblMuestra;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalos;
        private System.Windows.Forms.NumericUpDown numericUpDownMuestra;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lblVariablesAleatorias;
        private System.Windows.Forms.Label lblHistograma;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistribucion;
        private System.Windows.Forms.Label lblGrilla;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lblSimulacion;
        private System.Windows.Forms.Button btn_limpiar;
    }
}

