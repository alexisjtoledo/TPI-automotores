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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.button1 = new System.Windows.Forms.Button();
            this.btnVistasCargadas = new System.Windows.Forms.Button();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(669, 16);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.button1.Size = new System.Drawing.Size(153, 183);
            this.button1.TabIndex = 1;
            this.button1.Text = "VOLVER";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVistasCargadas
            // 
            this.btnVistasCargadas.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVistasCargadas.Image = ((System.Drawing.Image)(resources.GetObject("btnVistasCargadas.Image")));
            this.btnVistasCargadas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVistasCargadas.Location = new System.Drawing.Point(345, 16);
            this.btnVistasCargadas.Name = "btnVistasCargadas";
            this.btnVistasCargadas.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.btnVistasCargadas.Size = new System.Drawing.Size(318, 183);
            this.btnVistasCargadas.TabIndex = 2;
            this.btnVistasCargadas.Text = "PRE-CARGADAS";
            this.btnVistasCargadas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVistasCargadas.UseVisualStyleBackColor = true;
            this.btnVistasCargadas.Click += new System.EventHandler(this.BtnVistasCargadas_Click);
            // 
            // btnBuscador
            // 
            this.btnBuscador.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscador.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscador.Image")));
            this.btnBuscador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscador.Location = new System.Drawing.Point(12, 16);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.btnBuscador.Size = new System.Drawing.Size(325, 183);
            this.btnBuscador.TabIndex = 3;
            this.btnBuscador.Text = "BUSCAR";
            this.btnBuscador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscador.UseVisualStyleBackColor = true;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(834, 211);
            this.Controls.Add(this.btnBuscador);
            this.Controls.Add(this.btnVistasCargadas);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVistasCargadas;
        private System.Windows.Forms.Button btnBuscador;
    }
}