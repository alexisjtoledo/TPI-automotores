namespace Automotores
{
    partial class frmConsultas
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
            this.btnCargarInserts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVistasCargadas = new System.Windows.Forms.Button();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarInserts
            // 
            this.btnCargarInserts.Location = new System.Drawing.Point(9, 10);
            this.btnCargarInserts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargarInserts.Name = "btnCargarInserts";
            this.btnCargarInserts.Size = new System.Drawing.Size(224, 113);
            this.btnCargarInserts.TabIndex = 0;
            this.btnCargarInserts.Text = "Cargar Base";
            this.btnCargarInserts.UseVisualStyleBackColor = true;
            this.btnCargarInserts.Click += new System.EventHandler(this.btnCargarInserts_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver al Menu Principal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVistasCargadas
            // 
            this.btnVistasCargadas.Location = new System.Drawing.Point(458, 10);
            this.btnVistasCargadas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVistasCargadas.Name = "btnVistasCargadas";
            this.btnVistasCargadas.Size = new System.Drawing.Size(212, 113);
            this.btnVistasCargadas.TabIndex = 2;
            this.btnVistasCargadas.Text = "Busquedas Pre Cargadas";
            this.btnVistasCargadas.UseVisualStyleBackColor = true;
            this.btnVistasCargadas.Click += new System.EventHandler(this.BtnVistasCargadas_Click);
            // 
            // btnBuscador
            // 
            this.btnBuscador.Location = new System.Drawing.Point(237, 10);
            this.btnBuscador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(216, 113);
            this.btnBuscador.TabIndex = 3;
            this.btnBuscador.Text = "Buscar";
            this.btnBuscador.UseVisualStyleBackColor = true;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 130);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 73);
            this.button2.TabIndex = 4;
            this.button2.Text = "Borrar Base";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 210);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscador);
            this.Controls.Add(this.btnVistasCargadas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCargarInserts);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmConsultas";
            this.Text = "Consultas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarInserts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVistasCargadas;
        private System.Windows.Forms.Button btnBuscador;
        private System.Windows.Forms.Button button2;
    }
}