namespace cliente2
{
    partial class Cliente2Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.buttonAbrirFormulario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(76, 71);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(166, 55);
            this.buttonConectar.TabIndex = 0;
            this.buttonConectar.Text = "CONECTAR";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.Location = new System.Drawing.Point(76, 166);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(166, 64);
            this.buttonDesconectar.TabIndex = 1;
            this.buttonDesconectar.Text = "DESCONECTAR";
            this.buttonDesconectar.UseVisualStyleBackColor = true;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // buttonAbrirFormulario
            // 
            this.buttonAbrirFormulario.Location = new System.Drawing.Point(76, 278);
            this.buttonAbrirFormulario.Name = "buttonAbrirFormulario";
            this.buttonAbrirFormulario.Size = new System.Drawing.Size(166, 38);
            this.buttonAbrirFormulario.TabIndex = 2;
            this.buttonAbrirFormulario.Text = "ABRIR FORMULARIO";
            this.buttonAbrirFormulario.UseVisualStyleBackColor = true;
            this.buttonAbrirFormulario.Click += new System.EventHandler(this.buttonAbrirFormulario_Click);
            // 
            // Cliente2Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAbrirFormulario);
            this.Controls.Add(this.buttonDesconectar);
            this.Controls.Add(this.buttonConectar);
            this.Name = "Cliente2Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.Button buttonAbrirFormulario;
    }
}

