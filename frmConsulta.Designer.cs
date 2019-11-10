namespace Automotores
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.lblSelTabla = new System.Windows.Forms.Label();
            this.lblSelColumna = new System.Windows.Forms.Label();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.lblContiene = new System.Windows.Forms.Label();
            this.lblEs = new System.Windows.Forms.Label();
            this.lblEntre = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.cboTabla = new System.Windows.Forms.ComboBox();
            this.cboColumna = new System.Windows.Forms.ComboBox();
            this.txtContiene = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.rbtIgual = new System.Windows.Forms.RadioButton();
            this.rbtMayor = new System.Windows.Forms.RadioButton();
            this.rbtMenor = new System.Windows.Forms.RadioButton();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dgvVisor = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelTabla
            // 
            this.lblSelTabla.AutoSize = true;
            this.lblSelTabla.BackColor = System.Drawing.Color.Transparent;
            this.lblSelTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelTabla.Location = new System.Drawing.Point(13, 18);
            this.lblSelTabla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelTabla.Name = "lblSelTabla";
            this.lblSelTabla.Size = new System.Drawing.Size(157, 20);
            this.lblSelTabla.TabIndex = 0;
            this.lblSelTabla.Text = "Seleccionar Tabla:";
            // 
            // lblSelColumna
            // 
            this.lblSelColumna.AutoSize = true;
            this.lblSelColumna.BackColor = System.Drawing.Color.Transparent;
            this.lblSelColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelColumna.Location = new System.Drawing.Point(13, 99);
            this.lblSelColumna.Name = "lblSelColumna";
            this.lblSelColumna.Size = new System.Drawing.Size(183, 20);
            this.lblSelColumna.TabIndex = 1;
            this.lblSelColumna.Text = "Seleccionar Columna:";
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.Location = new System.Drawing.Point(13, 176);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(92, 20);
            this.lblFiltros.TabIndex = 2;
            this.lblFiltros.Text = "Filtrar por:";
            // 
            // lblContiene
            // 
            this.lblContiene.AutoSize = true;
            this.lblContiene.BackColor = System.Drawing.Color.Transparent;
            this.lblContiene.Location = new System.Drawing.Point(13, 216);
            this.lblContiene.Name = "lblContiene";
            this.lblContiene.Size = new System.Drawing.Size(75, 21);
            this.lblContiene.TabIndex = 4;
            this.lblContiene.Text = "Contiene:";
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.BackColor = System.Drawing.Color.Transparent;
            this.lblEs.Location = new System.Drawing.Point(13, 287);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(25, 21);
            this.lblEs.TabIndex = 5;
            this.lblEs.Text = "Es";
            // 
            // lblEntre
            // 
            this.lblEntre.AutoSize = true;
            this.lblEntre.BackColor = System.Drawing.Color.Transparent;
            this.lblEntre.Location = new System.Drawing.Point(13, 421);
            this.lblEntre.Name = "lblEntre";
            this.lblEntre.Size = new System.Drawing.Size(56, 21);
            this.lblEntre.TabIndex = 6;
            this.lblEntre.Text = "Desde:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.BackColor = System.Drawing.Color.Transparent;
            this.lblY.Location = new System.Drawing.Point(121, 421);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(52, 21);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Hasta:";
            // 
            // cboTabla
            // 
            this.cboTabla.FormattingEnabled = true;
            this.cboTabla.Location = new System.Drawing.Point(13, 50);
            this.cboTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTabla.Name = "cboTabla";
            this.cboTabla.Size = new System.Drawing.Size(223, 29);
            this.cboTabla.TabIndex = 8;
            this.cboTabla.SelectedIndexChanged += new System.EventHandler(this.CboTabla_SelectedIndexChanged);
            this.cboTabla.SelectionChangeCommitted += new System.EventHandler(this.CboTabla_SelectionChangeCommitted);
            // 
            // cboColumna
            // 
            this.cboColumna.FormattingEnabled = true;
            this.cboColumna.Location = new System.Drawing.Point(13, 128);
            this.cboColumna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboColumna.Name = "cboColumna";
            this.cboColumna.Size = new System.Drawing.Size(223, 29);
            this.cboColumna.TabIndex = 9;
            this.cboColumna.SelectionChangeCommitted += new System.EventHandler(this.CboColumna_SelectionChangeCommitted);
            // 
            // txtContiene
            // 
            this.txtContiene.Location = new System.Drawing.Point(13, 240);
            this.txtContiene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContiene.Name = "txtContiene";
            this.txtContiene.Size = new System.Drawing.Size(223, 29);
            this.txtContiene.TabIndex = 10;
            this.txtContiene.TextChanged += new System.EventHandler(this.TxtContiene_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(142, 347);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(94, 29);
            this.txtValor.TabIndex = 11;
            this.txtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            // 
            // rbtIgual
            // 
            this.rbtIgual.AutoSize = true;
            this.rbtIgual.BackColor = System.Drawing.Color.Transparent;
            this.rbtIgual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtIgual.Location = new System.Drawing.Point(13, 351);
            this.rbtIgual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtIgual.Name = "rbtIgual";
            this.rbtIgual.Size = new System.Drawing.Size(67, 21);
            this.rbtIgual.TabIndex = 12;
            this.rbtIgual.TabStop = true;
            this.rbtIgual.Text = "igual a:";
            this.rbtIgual.UseVisualStyleBackColor = false;
            this.rbtIgual.CheckedChanged += new System.EventHandler(this.RbtIgual_CheckedChanged);
            // 
            // rbtMayor
            // 
            this.rbtMayor.AutoSize = true;
            this.rbtMayor.BackColor = System.Drawing.Color.Transparent;
            this.rbtMayor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMayor.Location = new System.Drawing.Point(13, 321);
            this.rbtMayor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtMayor.Name = "rbtMayor";
            this.rbtMayor.Size = new System.Drawing.Size(76, 21);
            this.rbtMayor.TabIndex = 13;
            this.rbtMayor.TabStop = true;
            this.rbtMayor.Text = "mayor a:";
            this.rbtMayor.UseVisualStyleBackColor = false;
            this.rbtMayor.CheckedChanged += new System.EventHandler(this.RbtMayor_CheckedChanged);
            // 
            // rbtMenor
            // 
            this.rbtMenor.AutoSize = true;
            this.rbtMenor.BackColor = System.Drawing.Color.Transparent;
            this.rbtMenor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMenor.Location = new System.Drawing.Point(13, 380);
            this.rbtMenor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtMenor.Name = "rbtMenor";
            this.rbtMenor.Size = new System.Drawing.Size(76, 21);
            this.rbtMenor.TabIndex = 14;
            this.rbtMenor.TabStop = true;
            this.rbtMenor.Text = "menor a:";
            this.rbtMenor.UseVisualStyleBackColor = false;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(13, 449);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(107, 29);
            this.dtpInicio.TabIndex = 15;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicio_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(126, 449);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(110, 29);
            this.dtpFin.TabIndex = 16;
            this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // dgvVisor
            // 
            this.dgvVisor.AllowUserToAddRows = false;
            this.dgvVisor.AllowUserToDeleteRows = false;
            this.dgvVisor.AllowUserToOrderColumns = true;
            this.dgvVisor.AllowUserToResizeColumns = false;
            this.dgvVisor.AllowUserToResizeRows = false;
            this.dgvVisor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisor.Location = new System.Drawing.Point(264, 12);
            this.dgvVisor.Name = "dgvVisor";
            this.dgvVisor.RowHeadersWidth = 51;
            this.dgvVisor.Size = new System.Drawing.Size(908, 775);
            this.dgvVisor.TabIndex = 20;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(12, 733);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Padding = new System.Windows.Forms.Padding(52, 0, 52, 0);
            this.btnVolver.Size = new System.Drawing.Size(224, 54);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(12, 664);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.btnConsultar.Size = new System.Drawing.Size(224, 63);
            this.btnConsultar.TabIndex = 22;
            this.btnConsultar.Text = "FILTRAR";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 799);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvVisor);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.rbtMenor);
            this.Controls.Add(this.rbtMayor);
            this.Controls.Add(this.rbtIgual);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtContiene);
            this.Controls.Add(this.cboColumna);
            this.Controls.Add(this.cboTabla);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblEntre);
            this.Controls.Add(this.lblEs);
            this.Controls.Add(this.lblContiene);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.lblSelColumna);
            this.Controls.Add(this.lblSelTabla);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelTabla;
        private System.Windows.Forms.Label lblSelColumna;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Label lblContiene;
        private System.Windows.Forms.Label lblEs;
        private System.Windows.Forms.Label lblEntre;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.ComboBox cboTabla;
        private System.Windows.Forms.ComboBox cboColumna;
        private System.Windows.Forms.TextBox txtContiene;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton rbtIgual;
        private System.Windows.Forms.RadioButton rbtMayor;
        private System.Windows.Forms.RadioButton rbtMenor;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DataGridView dgvVisor;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConsultar;
    }
}