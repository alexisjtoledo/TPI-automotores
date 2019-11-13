namespace Automotores
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnReporte3 = new System.Windows.Forms.Button();
            this.btnReporte2 = new System.Windows.Forms.Button();
            this.btnReporte1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver.Location = new System.Drawing.Point(577, 14);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Padding = new System.Windows.Forms.Padding(0, 55, 0, 55);
            this.btnVolver.Size = new System.Drawing.Size(180, 180);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnReporte3
            // 
            this.btnReporte3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte3.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte3.Image")));
            this.btnReporte3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporte3.Location = new System.Drawing.Point(389, 14);
            this.btnReporte3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReporte3.Name = "btnReporte3";
            this.btnReporte3.Padding = new System.Windows.Forms.Padding(0, 40, 0, 40);
            this.btnReporte3.Size = new System.Drawing.Size(180, 180);
            this.btnReporte3.TabIndex = 6;
            this.btnReporte3.Text = "Productos no vendidos";
            this.btnReporte3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte3.UseVisualStyleBackColor = true;
            this.btnReporte3.Click += new System.EventHandler(this.btnReporte3_Click);
            // 
            // btnReporte2
            // 
            this.btnReporte2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte2.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte2.Image")));
            this.btnReporte2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporte2.Location = new System.Drawing.Point(201, 14);
            this.btnReporte2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReporte2.Name = "btnReporte2";
            this.btnReporte2.Padding = new System.Windows.Forms.Padding(0, 40, 0, 40);
            this.btnReporte2.Size = new System.Drawing.Size(180, 180);
            this.btnReporte2.TabIndex = 5;
            this.btnReporte2.Text = "Productos Vendidos en 2018";
            this.btnReporte2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte2.UseVisualStyleBackColor = true;
            this.btnReporte2.Click += new System.EventHandler(this.btnReporte2_Click);
            // 
            // btnReporte1
            // 
            this.btnReporte1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte1.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte1.Image")));
            this.btnReporte1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporte1.Location = new System.Drawing.Point(13, 14);
            this.btnReporte1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReporte1.Name = "btnReporte1";
            this.btnReporte1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 40);
            this.btnReporte1.Size = new System.Drawing.Size(180, 180);
            this.btnReporte1.TabIndex = 4;
            this.btnReporte1.Text = "Productos Vendidos en 2019";
            this.btnReporte1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte1.UseVisualStyleBackColor = true;
            this.btnReporte1.Click += new System.EventHandler(this.btnReporte1_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(774, 211);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnReporte3);
            this.Controls.Add(this.btnReporte2);
            this.Controls.Add(this.btnReporte1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReportes_FormClosing);
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnReporte3;
        private System.Windows.Forms.Button btnReporte2;
        private System.Windows.Forms.Button btnReporte1;
    }
}