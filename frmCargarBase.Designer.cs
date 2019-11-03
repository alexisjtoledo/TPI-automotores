namespace Automotores
{
    partial class frmCargarBase
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
            this.btnCargarStructure = new System.Windows.Forms.Button();
            this.btnCargarData = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarStructure
            // 
            this.btnCargarStructure.Location = new System.Drawing.Point(12, 12);
            this.btnCargarStructure.Name = "btnCargarStructure";
            this.btnCargarStructure.Size = new System.Drawing.Size(278, 141);
            this.btnCargarStructure.TabIndex = 0;
            this.btnCargarStructure.Text = "Cargar Estructura";
            this.btnCargarStructure.UseVisualStyleBackColor = true;
            this.btnCargarStructure.Click += new System.EventHandler(this.btnCargarStructure_Click);
            // 
            // btnCargarData
            // 
            this.btnCargarData.Location = new System.Drawing.Point(296, 12);
            this.btnCargarData.Name = "btnCargarData";
            this.btnCargarData.Size = new System.Drawing.Size(279, 141);
            this.btnCargarData.TabIndex = 1;
            this.btnCargarData.Text = "Cargar Datos";
            this.btnCargarData.UseVisualStyleBackColor = true;
            this.btnCargarData.Click += new System.EventHandler(this.btnCargarData_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(296, 159);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(279, 88);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmCargarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 259);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCargarData);
            this.Controls.Add(this.btnCargarStructure);
            this.Name = "frmCargarBase";
            this.Text = "Cargas de Base";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarStructure;
        private System.Windows.Forms.Button btnCargarData;
        private System.Windows.Forms.Button btnVolver;
    }
}