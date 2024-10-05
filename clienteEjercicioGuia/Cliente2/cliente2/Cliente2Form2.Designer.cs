namespace cliente2
{
    partial class Cliente2Form2
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
            this.textBoxTemperatura = new System.Windows.Forms.TextBox();
            this.radioButtonFtoC = new System.Windows.Forms.RadioButton();
            this.radioButtonCtoF = new System.Windows.Forms.RadioButton();
            this.buttonConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTemperatura
            // 
            this.textBoxTemperatura.Location = new System.Drawing.Point(232, 34);
            this.textBoxTemperatura.Name = "textBoxTemperatura";
            this.textBoxTemperatura.Size = new System.Drawing.Size(315, 22);
            this.textBoxTemperatura.TabIndex = 0;
            // 
            // radioButtonFtoC
            // 
            this.radioButtonFtoC.AutoSize = true;
            this.radioButtonFtoC.Location = new System.Drawing.Point(94, 106);
            this.radioButtonFtoC.Name = "radioButtonFtoC";
            this.radioButtonFtoC.Size = new System.Drawing.Size(149, 20);
            this.radioButtonFtoC.TabIndex = 1;
            this.radioButtonFtoC.TabStop = true;
            this.radioButtonFtoC.Text = "Fahrenheit a Celsius";
            this.radioButtonFtoC.UseVisualStyleBackColor = true;
            // 
            // radioButtonCtoF
            // 
            this.radioButtonCtoF.AutoSize = true;
            this.radioButtonCtoF.Location = new System.Drawing.Point(94, 150);
            this.radioButtonCtoF.Name = "radioButtonCtoF";
            this.radioButtonCtoF.Size = new System.Drawing.Size(149, 20);
            this.radioButtonCtoF.TabIndex = 2;
            this.radioButtonCtoF.TabStop = true;
            this.radioButtonCtoF.Text = "Celsius a Fahrenheit";
            this.radioButtonCtoF.UseVisualStyleBackColor = true;
            // 
            // buttonConvertir
            // 
            this.buttonConvertir.Location = new System.Drawing.Point(276, 106);
            this.buttonConvertir.Name = "buttonConvertir";
            this.buttonConvertir.Size = new System.Drawing.Size(188, 64);
            this.buttonConvertir.TabIndex = 3;
            this.buttonConvertir.Text = "CONVERTIR";
            this.buttonConvertir.UseVisualStyleBackColor = true;
            this.buttonConvertir.Click += new System.EventHandler(this.buttonConvertir_Click);
            // 
            // Cliente2Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConvertir);
            this.Controls.Add(this.radioButtonCtoF);
            this.Controls.Add(this.radioButtonFtoC);
            this.Controls.Add(this.textBoxTemperatura);
            this.Name = "Cliente2Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTemperatura;
        private System.Windows.Forms.RadioButton radioButtonFtoC;
        private System.Windows.Forms.RadioButton radioButtonCtoF;
        private System.Windows.Forms.Button buttonConvertir;
    }
}