namespace Automotores
{
    partial class frmProductos
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
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.cboFiltroMarca = new System.Windows.Forms.ComboBox();
            this.rbMayorQue = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFiltroModelo = new System.Windows.Forms.ComboBox();
            this.cmbFiltroTipoProducto = new System.Windows.Forms.ComboBox();
            this.txtFiltroPrecio = new System.Windows.Forms.TextBox();
            this.rbMenorQue = new System.Windows.Forms.RadioButton();
            this.rbIgualQue = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(28, 120);
            this.dgProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersWidth = 51;
            this.dgProductos.RowTemplate.Height = 24;
            this.dgProductos.Size = new System.Drawing.Size(785, 300);
            this.dgProductos.TabIndex = 0;
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProductos_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(28, 440);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(190, 58);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(231, 440);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(206, 58);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(454, 440);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(166, 58);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(640, 440);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(172, 58);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver al Menu Principal";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FILTROS";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(108, 44);
            this.txtFiltroNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(111, 20);
            this.txtFiltroNombre.TabIndex = 7;
            // 
            // cboFiltroMarca
            // 
            this.cboFiltroMarca.FormattingEnabled = true;
            this.cboFiltroMarca.Location = new System.Drawing.Point(283, 42);
            this.cboFiltroMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cboFiltroMarca.Name = "cboFiltroMarca";
            this.cboFiltroMarca.Size = new System.Drawing.Size(92, 21);
            this.cboFiltroMarca.TabIndex = 8;
            // 
            // rbMayorQue
            // 
            this.rbMayorQue.AutoSize = true;
            this.rbMayorQue.Location = new System.Drawing.Point(620, 41);
            this.rbMayorQue.Margin = new System.Windows.Forms.Padding(2);
            this.rbMayorQue.Name = "rbMayorQue";
            this.rbMayorQue.Size = new System.Drawing.Size(75, 17);
            this.rbMayorQue.TabIndex = 9;
            this.rbMayorQue.TabStop = true;
            this.rbMayorQue.Text = "Mayor que";
            this.rbMayorQue.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio";
            // 
            // cboFiltroModelo
            // 
            this.cboFiltroModelo.FormattingEnabled = true;
            this.cboFiltroModelo.Location = new System.Drawing.Point(454, 41);
            this.cboFiltroModelo.Margin = new System.Windows.Forms.Padding(2);
            this.cboFiltroModelo.Name = "cboFiltroModelo";
            this.cboFiltroModelo.Size = new System.Drawing.Size(92, 21);
            this.cboFiltroModelo.TabIndex = 15;
            // 
            // cmbFiltroTipoProducto
            // 
            this.cmbFiltroTipoProducto.FormattingEnabled = true;
            this.cmbFiltroTipoProducto.Location = new System.Drawing.Point(108, 85);
            this.cmbFiltroTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltroTipoProducto.Name = "cmbFiltroTipoProducto";
            this.cmbFiltroTipoProducto.Size = new System.Drawing.Size(111, 21);
            this.cmbFiltroTipoProducto.TabIndex = 16;
            // 
            // txtFiltroPrecio
            // 
            this.txtFiltroPrecio.Location = new System.Drawing.Point(706, 57);
            this.txtFiltroPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroPrecio.Name = "txtFiltroPrecio";
            this.txtFiltroPrecio.Size = new System.Drawing.Size(108, 20);
            this.txtFiltroPrecio.TabIndex = 17;
            // 
            // rbMenorQue
            // 
            this.rbMenorQue.AutoSize = true;
            this.rbMenorQue.Location = new System.Drawing.Point(620, 84);
            this.rbMenorQue.Margin = new System.Windows.Forms.Padding(2);
            this.rbMenorQue.Name = "rbMenorQue";
            this.rbMenorQue.Size = new System.Drawing.Size(76, 17);
            this.rbMenorQue.TabIndex = 18;
            this.rbMenorQue.TabStop = true;
            this.rbMenorQue.Text = "Menor que";
            this.rbMenorQue.UseVisualStyleBackColor = true;
            // 
            // rbIgualQue
            // 
            this.rbIgualQue.AutoSize = true;
            this.rbIgualQue.Location = new System.Drawing.Point(620, 63);
            this.rbIgualQue.Margin = new System.Windows.Forms.Padding(2);
            this.rbIgualQue.Name = "rbIgualQue";
            this.rbIgualQue.Size = new System.Drawing.Size(69, 17);
            this.rbIgualQue.TabIndex = 19;
            this.rbIgualQue.TabStop = true;
            this.rbIgualQue.Text = "Igual que";
            this.rbIgualQue.UseVisualStyleBackColor = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 507);
            this.Controls.Add(this.rbIgualQue);
            this.Controls.Add(this.rbMenorQue);
            this.Controls.Add(this.txtFiltroPrecio);
            this.Controls.Add(this.cmbFiltroTipoProducto);
            this.Controls.Add(this.cboFiltroModelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbMayorQue);
            this.Controls.Add(this.cboFiltroMarca);
            this.Controls.Add(this.txtFiltroNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgProductos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.ComboBox cboFiltroMarca;
        private System.Windows.Forms.RadioButton rbMayorQue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFiltroModelo;
        private System.Windows.Forms.ComboBox cmbFiltroTipoProducto;
        private System.Windows.Forms.TextBox txtFiltroPrecio;
        private System.Windows.Forms.RadioButton rbMenorQue;
        private System.Windows.Forms.RadioButton rbIgualQue;
    }
}