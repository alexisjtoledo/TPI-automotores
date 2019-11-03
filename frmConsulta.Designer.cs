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
            this.lblSelTabla = new System.Windows.Forms.Label();
            this.lblSelColumna = new System.Windows.Forms.Label();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.lblOrdenar = new System.Windows.Forms.Label();
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
            this.rbtAscendente = new System.Windows.Forms.RadioButton();
            this.rbtDescendente = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvVisor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelTabla
            // 
            this.lblSelTabla.AutoSize = true;
            this.lblSelTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelTabla.Location = new System.Drawing.Point(16, 20);
            this.lblSelTabla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelTabla.Name = "lblSelTabla";
            this.lblSelTabla.Size = new System.Drawing.Size(157, 20);
            this.lblSelTabla.TabIndex = 0;
            this.lblSelTabla.Text = "Seleccionar Tabla:";
            // 
            // lblSelColumna
            // 
            this.lblSelColumna.AutoSize = true;
            this.lblSelColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelColumna.Location = new System.Drawing.Point(16, 94);
            this.lblSelColumna.Name = "lblSelColumna";
            this.lblSelColumna.Size = new System.Drawing.Size(183, 20);
            this.lblSelColumna.TabIndex = 1;
            this.lblSelColumna.Text = "Seleccionar Columna:";
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.Location = new System.Drawing.Point(16, 168);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(92, 20);
            this.lblFiltros.TabIndex = 2;
            this.lblFiltros.Text = "Filtrar por:";
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenar.Location = new System.Drawing.Point(16, 477);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(110, 20);
            this.lblOrdenar.TabIndex = 3;
            this.lblOrdenar.Text = "Ordenar por:";
            // 
            // lblContiene
            // 
            this.lblContiene.AutoSize = true;
            this.lblContiene.Location = new System.Drawing.Point(18, 206);
            this.lblContiene.Name = "lblContiene";
            this.lblContiene.Size = new System.Drawing.Size(77, 20);
            this.lblContiene.TabIndex = 4;
            this.lblContiene.Text = "Contiene:";
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.Location = new System.Drawing.Point(16, 273);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(28, 20);
            this.lblEs.TabIndex = 5;
            this.lblEs.Text = "Es";
            // 
            // lblEntre
            // 
            this.lblEntre.AutoSize = true;
            this.lblEntre.Location = new System.Drawing.Point(17, 405);
            this.lblEntre.Name = "lblEntre";
            this.lblEntre.Size = new System.Drawing.Size(60, 20);
            this.lblEntre.TabIndex = 6;
            this.lblEntre.Text = "Desde:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(123, 405);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(56, 20);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Hasta:";
            // 
            // cboTabla
            // 
            this.cboTabla.FormattingEnabled = true;
            this.cboTabla.Location = new System.Drawing.Point(20, 48);
            this.cboTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTabla.Name = "cboTabla";
            this.cboTabla.Size = new System.Drawing.Size(227, 28);
            this.cboTabla.TabIndex = 8;
            this.cboTabla.SelectedIndexChanged += new System.EventHandler(this.CboTabla_SelectedIndexChanged);
            this.cboTabla.SelectionChangeCommitted += new System.EventHandler(this.CboTabla_SelectionChangeCommitted);
            // 
            // cboColumna
            // 
            this.cboColumna.FormattingEnabled = true;
            this.cboColumna.Location = new System.Drawing.Point(20, 122);
            this.cboColumna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboColumna.Name = "cboColumna";
            this.cboColumna.Size = new System.Drawing.Size(227, 28);
            this.cboColumna.TabIndex = 9;
            this.cboColumna.SelectionChangeCommitted += new System.EventHandler(this.CboColumna_SelectionChangeCommitted);
            // 
            // txtContiene
            // 
            this.txtContiene.Location = new System.Drawing.Point(20, 229);
            this.txtContiene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContiene.Name = "txtContiene";
            this.txtContiene.Size = new System.Drawing.Size(227, 26);
            this.txtContiene.TabIndex = 10;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(147, 331);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(79, 26);
            this.txtValor.TabIndex = 11;
            // 
            // rbtIgual
            // 
            this.rbtIgual.AutoSize = true;
            this.rbtIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtIgual.Location = new System.Drawing.Point(20, 334);
            this.rbtIgual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtIgual.Name = "rbtIgual";
            this.rbtIgual.Size = new System.Drawing.Size(69, 20);
            this.rbtIgual.TabIndex = 12;
            this.rbtIgual.TabStop = true;
            this.rbtIgual.Text = "igual a:";
            this.rbtIgual.UseVisualStyleBackColor = true;
            // 
            // rbtMayor
            // 
            this.rbtMayor.AutoSize = true;
            this.rbtMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMayor.Location = new System.Drawing.Point(20, 306);
            this.rbtMayor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtMayor.Name = "rbtMayor";
            this.rbtMayor.Size = new System.Drawing.Size(78, 20);
            this.rbtMayor.TabIndex = 13;
            this.rbtMayor.TabStop = true;
            this.rbtMayor.Text = "mayor a:";
            this.rbtMayor.UseVisualStyleBackColor = true;
            // 
            // rbtMenor
            // 
            this.rbtMenor.AutoSize = true;
            this.rbtMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMenor.Location = new System.Drawing.Point(20, 362);
            this.rbtMenor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtMenor.Name = "rbtMenor";
            this.rbtMenor.Size = new System.Drawing.Size(78, 20);
            this.rbtMenor.TabIndex = 14;
            this.rbtMenor.TabStop = true;
            this.rbtMenor.Text = "menor a:";
            this.rbtMenor.UseVisualStyleBackColor = true;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(20, 428);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(100, 26);
            this.dtpInicio.TabIndex = 15;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(126, 428);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(100, 26);
            this.dtpFin.TabIndex = 16;
            // 
            // rbtAscendente
            // 
            this.rbtAscendente.AutoSize = true;
            this.rbtAscendente.Location = new System.Drawing.Point(20, 505);
            this.rbtAscendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtAscendente.Name = "rbtAscendente";
            this.rbtAscendente.Size = new System.Drawing.Size(60, 24);
            this.rbtAscendente.TabIndex = 17;
            this.rbtAscendente.TabStop = true;
            this.rbtAscendente.Text = "ASC";
            this.rbtAscendente.UseVisualStyleBackColor = true;
            // 
            // rbtDescendente
            // 
            this.rbtDescendente.AutoSize = true;
            this.rbtDescendente.Location = new System.Drawing.Point(87, 505);
            this.rbtDescendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtDescendente.Name = "rbtDescendente";
            this.rbtDescendente.Size = new System.Drawing.Size(72, 24);
            this.rbtDescendente.TabIndex = 18;
            this.rbtDescendente.TabStop = true;
            this.rbtDescendente.Text = "DESC";
            this.rbtDescendente.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(55, 573);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(157, 51);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dgvVisor
            // 
            this.dgvVisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisor.Location = new System.Drawing.Point(279, 12);
            this.dgvVisor.Name = "dgvVisor";
            this.dgvVisor.Size = new System.Drawing.Size(808, 630);
            this.dgvVisor.TabIndex = 20;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 654);
            this.Controls.Add(this.dgvVisor);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.rbtDescendente);
            this.Controls.Add(this.rbtAscendente);
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
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.lblSelColumna);
            this.Controls.Add(this.lblSelTabla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsulta";
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
        private System.Windows.Forms.Label lblOrdenar;
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
        private System.Windows.Forms.RadioButton rbtAscendente;
        private System.Windows.Forms.RadioButton rbtDescendente;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvVisor;
    }
}