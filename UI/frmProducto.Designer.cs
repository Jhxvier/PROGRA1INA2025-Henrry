namespace UI
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
            gbxDatosProducto = new GroupBox();
            txtCantidad = new NumericUpDown();
            lblCantidad = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtId = new TextBox();
            lblId = new Label();
            lblTitulo = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            gbxDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // gbxDatosProducto
            // 
            gbxDatosProducto.Controls.Add(txtCantidad);
            gbxDatosProducto.Controls.Add(lblCantidad);
            gbxDatosProducto.Controls.Add(txtPrecio);
            gbxDatosProducto.Controls.Add(lblPrecio);
            gbxDatosProducto.Controls.Add(txtNombre);
            gbxDatosProducto.Controls.Add(lblNombre);
            gbxDatosProducto.Controls.Add(txtId);
            gbxDatosProducto.Controls.Add(lblId);
            gbxDatosProducto.Location = new Point(17, 77);
            gbxDatosProducto.Margin = new Padding(4, 5, 4, 5);
            gbxDatosProducto.Name = "gbxDatosProducto";
            gbxDatosProducto.Padding = new Padding(4, 5, 4, 5);
            gbxDatosProducto.Size = new Size(564, 328);
            gbxDatosProducto.TabIndex = 0;
            gbxDatosProducto.TabStop = false;
            gbxDatosProducto.Text = "Datos de producto";
            gbxDatosProducto.Enter += gbxDatosProducto_Enter;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(111, 207);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(121, 31);
            txtCantidad.TabIndex = 4;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(20, 210);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(87, 25);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(111, 157);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(177, 31);
            txtPrecio.TabIndex = 3;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(41, 162);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(64, 25);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 108);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(428, 31);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 113);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtId
            // 
            txtId.Location = new Point(111, 60);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(177, 31);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(73, 65);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(194, 22);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(248, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Crear Producto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(250, 415);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(161, 60);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(420, 415);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(161, 60);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(80, 415);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(161, 60);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 488);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(gbxDatosProducto);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmProducto";
            Text = "Matentenimiento: Crear Producto";
            Load += frmProducto_Load;
            gbxDatosProducto.ResumeLayout(false);
            gbxDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxDatosProducto;
        private Label lblTitulo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblCantidad;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtId;
        private Label lblId;
        private NumericUpDown txtCantidad;
        private Button btnEliminar;
    }
}