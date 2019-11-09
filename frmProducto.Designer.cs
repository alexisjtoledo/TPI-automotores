namespace Automotores
{
    partial class frmProducto
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
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFiltroMarca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFiltroModelo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFiltroTipoProducto = new System.Windows.Forms.ComboBox();
            this.rbMayorQue = new System.Windows.Forms.RadioButton();
            this.rbIgualQue = new System.Windows.Forms.RadioButton();
            this.rbMenorQue = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 16;
            this.lstProductos.Location = new System.Drawing.Point(28, 143);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(1077, 548);
            this.lstProductos.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(289, 713);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(252, 49);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(547, 713);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(268, 49);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(28, 713);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(255, 49);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(821, 713);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(284, 49);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver al Menu Principal";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrar";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(138, 70);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(196, 22);
            this.txtFiltroNombre.TabIndex = 6;
            this.txtFiltroNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio";
            // 
            // txtFiltroPrecio
            // 
            this.txtFiltroPrecio.Location = new System.Drawing.Point(940, 88);
            this.txtFiltroPrecio.Name = "txtFiltroPrecio";
            this.txtFiltroPrecio.Size = new System.Drawing.Size(165, 22);
            this.txtFiltroPrecio.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Marca";
            // 
            // cmbFiltroMarca
            // 
            this.cmbFiltroMarca.FormattingEnabled = true;
            this.cmbFiltroMarca.Location = new System.Drawing.Point(415, 69);
            this.cmbFiltroMarca.Name = "cmbFiltroMarca";
            this.cmbFiltroMarca.Size = new System.Drawing.Size(196, 24);
            this.cmbFiltroMarca.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Modelo";
            // 
            // cboFiltroModelo
            // 
            this.cboFiltroModelo.FormattingEnabled = true;
            this.cboFiltroModelo.Location = new System.Drawing.Point(415, 110);
            this.cboFiltroModelo.Name = "cboFiltroModelo";
            this.cboFiltroModelo.Size = new System.Drawing.Size(196, 24);
            this.cboFiltroModelo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo Producto";
            // 
            // cboFiltroTipoProducto
            // 
            this.cboFiltroTipoProducto.FormattingEnabled = true;
            this.cboFiltroTipoProducto.Location = new System.Drawing.Point(138, 110);
            this.cboFiltroTipoProducto.Name = "cboFiltroTipoProducto";
            this.cboFiltroTipoProducto.Size = new System.Drawing.Size(196, 24);
            this.cboFiltroTipoProducto.TabIndex = 15;
            // 
            // rbMayorQue
            // 
            this.rbMayorQue.AutoSize = true;
            this.rbMayorQue.Location = new System.Drawing.Point(800, 65);
            this.rbMayorQue.Name = "rbMayorQue";
            this.rbMayorQue.Size = new System.Drawing.Size(96, 21);
            this.rbMayorQue.TabIndex = 16;
            this.rbMayorQue.TabStop = true;
            this.rbMayorQue.Text = "Mayor que";
            this.rbMayorQue.UseVisualStyleBackColor = true;
            // 
            // rbIgualQue
            // 
            this.rbIgualQue.AutoSize = true;
            this.rbIgualQue.Location = new System.Drawing.Point(800, 94);
            this.rbIgualQue.Name = "rbIgualQue";
            this.rbIgualQue.Size = new System.Drawing.Size(87, 21);
            this.rbIgualQue.TabIndex = 17;
            this.rbIgualQue.TabStop = true;
            this.rbIgualQue.Text = "Igual que";
            this.rbIgualQue.UseVisualStyleBackColor = true;
            // 
            // rbMenorQue
            // 
            this.rbMenorQue.AutoSize = true;
            this.rbMenorQue.Location = new System.Drawing.Point(800, 121);
            this.rbMenorQue.Name = "rbMenorQue";
            this.rbMenorQue.Size = new System.Drawing.Size(97, 21);
            this.rbMenorQue.TabIndex = 18;
            this.rbMenorQue.TabStop = true;
            this.rbMenorQue.Text = "Menor que";
            this.rbMenorQue.UseVisualStyleBackColor = true;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 774);
            this.Controls.Add(this.rbMenorQue);
            this.Controls.Add(this.rbIgualQue);
            this.Controls.Add(this.rbMayorQue);
            this.Controls.Add(this.cboFiltroTipoProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboFiltroModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFiltroMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFiltroPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltroNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lstProductos);
            this.Name = "frmProducto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltroPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFiltroMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFiltroModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFiltroTipoProducto;
        private System.Windows.Forms.RadioButton rbMayorQue;
        private System.Windows.Forms.RadioButton rbIgualQue;
        private System.Windows.Forms.RadioButton rbMenorQue;
    }
}