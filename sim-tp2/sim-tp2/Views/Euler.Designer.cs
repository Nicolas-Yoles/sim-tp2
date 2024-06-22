namespace sim_tp2.Views
{
    partial class Euler
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
            this.nroEulerInput = new System.Windows.Forms.TextBox();
            this.nroEulerLabel = new System.Windows.Forms.Label();
            this.dgvEuler = new System.Windows.Forms.DataGridView();
            this.consultarEulerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEuler)).BeginInit();
            this.SuspendLayout();
            // 
            // nroEulerInput
            // 
            this.nroEulerInput.Location = new System.Drawing.Point(116, 23);
            this.nroEulerInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nroEulerInput.Name = "nroEulerInput";
            this.nroEulerInput.Size = new System.Drawing.Size(111, 22);
            this.nroEulerInput.TabIndex = 0;
            // 
            // nroEulerLabel
            // 
            this.nroEulerLabel.AutoSize = true;
            this.nroEulerLabel.Location = new System.Drawing.Point(12, 27);
            this.nroEulerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nroEulerLabel.Name = "nroEulerLabel";
            this.nroEulerLabel.Size = new System.Drawing.Size(88, 16);
            this.nroEulerLabel.TabIndex = 1;
            this.nroEulerLabel.Text = "Nro. de Euler:";
            // 
            // dgvEuler
            // 
            this.dgvEuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEuler.Location = new System.Drawing.Point(16, 55);
            this.dgvEuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEuler.Name = "dgvEuler";
            this.dgvEuler.RowHeadersWidth = 51;
            this.dgvEuler.Size = new System.Drawing.Size(923, 462);
            this.dgvEuler.TabIndex = 2;
            // 
            // consultarEulerButton
            // 
            this.consultarEulerButton.Location = new System.Drawing.Point(236, 20);
            this.consultarEulerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consultarEulerButton.Name = "consultarEulerButton";
            this.consultarEulerButton.Size = new System.Drawing.Size(100, 28);
            this.consultarEulerButton.TabIndex = 3;
            this.consultarEulerButton.Text = "Consultar";
            this.consultarEulerButton.UseVisualStyleBackColor = true;
            this.consultarEulerButton.Click += new System.EventHandler(this.consultarEulerButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(839, 525);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Euler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.consultarEulerButton);
            this.Controls.Add(this.dgvEuler);
            this.Controls.Add(this.nroEulerLabel);
            this.Controls.Add(this.nroEulerInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Euler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Euler";
            this.Load += new System.EventHandler(this.Euler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEuler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nroEulerInput;
        private System.Windows.Forms.Label nroEulerLabel;
        private System.Windows.Forms.DataGridView dgvEuler;
        private System.Windows.Forms.Button consultarEulerButton;
        private System.Windows.Forms.Button button1;
    }
}