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
            this.eulerDataGridView = new System.Windows.Forms.DataGridView();
            this.consultarEulerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eulerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nroEulerInput
            // 
            this.nroEulerInput.Location = new System.Drawing.Point(87, 19);
            this.nroEulerInput.Name = "nroEulerInput";
            this.nroEulerInput.Size = new System.Drawing.Size(84, 20);
            this.nroEulerInput.TabIndex = 0;
            // 
            // nroEulerLabel
            // 
            this.nroEulerLabel.AutoSize = true;
            this.nroEulerLabel.Location = new System.Drawing.Point(9, 22);
            this.nroEulerLabel.Name = "nroEulerLabel";
            this.nroEulerLabel.Size = new System.Drawing.Size(72, 13);
            this.nroEulerLabel.TabIndex = 1;
            this.nroEulerLabel.Text = "Nro. de Euler:";
            // 
            // eulerDataGridView
            // 
            this.eulerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eulerDataGridView.Location = new System.Drawing.Point(12, 45);
            this.eulerDataGridView.Name = "eulerDataGridView";
            this.eulerDataGridView.Size = new System.Drawing.Size(240, 393);
            this.eulerDataGridView.TabIndex = 2;
            // 
            // consultarEulerButton
            // 
            this.consultarEulerButton.Location = new System.Drawing.Point(177, 16);
            this.consultarEulerButton.Name = "consultarEulerButton";
            this.consultarEulerButton.Size = new System.Drawing.Size(75, 23);
            this.consultarEulerButton.TabIndex = 3;
            this.consultarEulerButton.Text = "Consultar";
            this.consultarEulerButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Euler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.consultarEulerButton);
            this.Controls.Add(this.eulerDataGridView);
            this.Controls.Add(this.nroEulerLabel);
            this.Controls.Add(this.nroEulerInput);
            this.Name = "Euler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Euler";
            this.Load += new System.EventHandler(this.Euler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eulerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nroEulerInput;
        private System.Windows.Forms.Label nroEulerLabel;
        private System.Windows.Forms.DataGridView eulerDataGridView;
        private System.Windows.Forms.Button consultarEulerButton;
        private System.Windows.Forms.Button button1;
    }
}