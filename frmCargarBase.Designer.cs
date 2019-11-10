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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarBase));
            this.btnCargarStructure = new System.Windows.Forms.Button();
            this.btnCargarData = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarStructure
            // 
            this.btnCargarStructure.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarStructure.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarStructure.Image")));
            this.btnCargarStructure.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarStructure.Location = new System.Drawing.Point(12, 13);
            this.btnCargarStructure.Name = "btnCargarStructure";
            this.btnCargarStructure.Padding = new System.Windows.Forms.Padding(0, 40, 0, 40);
            this.btnCargarStructure.Size = new System.Drawing.Size(185, 185);
            this.btnCargarStructure.TabIndex = 0;
            this.btnCargarStructure.Text = "CARGAR ESTRUCTURA";
            this.btnCargarStructure.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarStructure.UseVisualStyleBackColor = true;
            this.btnCargarStructure.Click += new System.EventHandler(this.btnCargarStructure_Click);
            // 
            // btnCargarData
            // 
            this.btnCargarData.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarData.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarData.Image")));
            this.btnCargarData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarData.Location = new System.Drawing.Point(220, 13);
            this.btnCargarData.Name = "btnCargarData";
            this.btnCargarData.Padding = new System.Windows.Forms.Padding(0, 40, 0, 50);
            this.btnCargarData.Size = new System.Drawing.Size(185, 185);
            this.btnCargarData.TabIndex = 1;
            this.btnCargarData.Text = "CARGAR DATOS";
            this.btnCargarData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarData.UseVisualStyleBackColor = true;
            this.btnCargarData.Click += new System.EventHandler(this.btnCargarData_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver.Location = new System.Drawing.Point(636, 13);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Padding = new System.Windows.Forms.Padding(0, 40, 0, 50);
            this.btnVolver.Size = new System.Drawing.Size(185, 185);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(428, 13);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 50);
            this.button1.Size = new System.Drawing.Size(185, 185);
            this.button1.TabIndex = 4;
            this.button1.Text = "CARGAR VISTAS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCargarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCargarData);
            this.Controls.Add(this.btnCargarStructure);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargarBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargas de Base";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCargarBase_FormClosing);
            this.Load += new System.EventHandler(this.frmCargarBase_Load);
            this.Shown += new System.EventHandler(this.FrmCargarBase_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarStructure;
        private System.Windows.Forms.Button btnCargarData;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button1;
    }
}