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
            this.dgProductos.Location = new System.Drawing.Point(37, 148);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersWidth = 51;
            this.dgProductos.RowTemplate.Height = 24;
            this.dgProductos.Size = new System.Drawing.Size(1047, 369);
            this.dgProductos.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(37, 541);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(254, 71);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(308, 541);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(275, 71);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(606, 541);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(222, 71);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(854, 541);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(230, 71);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver al Menu Principal";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "FILTROS";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(144, 54);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(147, 22);
            this.txtFiltroNombre.TabIndex = 7;
            // 
            // cboFiltroMarca
            // 
            this.cboFiltroMarca.FormattingEnabled = true;
            this.cboFiltroMarca.Location = new System.Drawing.Point(377, 52);
            this.cboFiltroMarca.Name = "cboFiltroMarca";
            this.cboFiltroMarca.Size = new System.Drawing.Size(121, 24);
            this.cboFiltroMarca.TabIndex = 8;
            // 
            // rbMayorQue
            // 
            this.rbMayorQue.AutoSize = true;
            this.rbMayorQue.Location = new System.Drawing.Point(826, 50);
            this.rbMayorQue.Name = "rbMayorQue";
            this.rbMayorQue.Size = new System.Drawing.Size(96, 21);
            this.rbMayorQue.TabIndex = 9;
            this.rbMayorQue.TabStop = true;
            this.rbMayorQue.Text = "Mayor que";
            this.rbMayorQue.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio";
            // 
            // cboFiltroModelo
            // 
            this.cboFiltroModelo.FormattingEnabled = true;
            this.cboFiltroModelo.Location = new System.Drawing.Point(606, 50);
            this.cboFiltroModelo.Name = "cboFiltroModelo";
            this.cboFiltroModelo.Size = new System.Drawing.Size(121, 24);
            this.cboFiltroModelo.TabIndex = 15;
            // 
            // cmbFiltroTipoProducto
            // 
            this.cmbFiltroTipoProducto.FormattingEnabled = true;
            this.cmbFiltroTipoProducto.Location = new System.Drawing.Point(144, 105);
            this.cmbFiltroTipoProducto.Name = "cmbFiltroTipoProducto";
            this.cmbFiltroTipoProducto.Size = new System.Drawing.Size(147, 24);
            this.cmbFiltroTipoProducto.TabIndex = 16;
            // 
            // txtFiltroPrecio
            // 
            this.txtFiltroPrecio.Location = new System.Drawing.Point(942, 70);
            this.txtFiltroPrecio.Name = "txtFiltroPrecio";
            this.txtFiltroPrecio.Size = new System.Drawing.Size(142, 22);
            this.txtFiltroPrecio.TabIndex = 17;
            // 
            // rbMenorQue
            // 
            this.rbMenorQue.AutoSize = true;
            this.rbMenorQue.Location = new System.Drawing.Point(826, 104);
            this.rbMenorQue.Name = "rbMenorQue";
            this.rbMenorQue.Size = new System.Drawing.Size(97, 21);
            this.rbMenorQue.TabIndex = 18;
            this.rbMenorQue.TabStop = true;
            this.rbMenorQue.Text = "Menor que";
            this.rbMenorQue.UseVisualStyleBackColor = true;
            // 
            // rbIgualQue
            // 
            this.rbIgualQue.AutoSize = true;
            this.rbIgualQue.Location = new System.Drawing.Point(826, 77);
            this.rbIgualQue.Name = "rbIgualQue";
            this.rbIgualQue.Size = new System.Drawing.Size(87, 21);
            this.rbIgualQue.TabIndex = 19;
            this.rbIgualQue.TabStop = true;
            this.rbIgualQue.Text = "Igual que";
            this.rbIgualQue.UseVisualStyleBackColor = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 624);
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
            this.Name = "frmProductos";
            this.Text = "Productos";
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