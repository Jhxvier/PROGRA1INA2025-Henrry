namespace UI
{
    partial class frmCliente
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
            btnCancelarCliente = new Button();
            btnGuardarCliente = new Button();
            lblTitulo = new Label();
            gbxDatosProducto = new GroupBox();
            txtCorreoCliente = new TextBox();
            label3 = new Label();
            dateCliente = new DateTimePicker();
            label2 = new Label();
            txtGenero = new TextBox();
            label1 = new Label();
            txtApellido2 = new TextBox();
            lblApellido2 = new Label();
            txtApellido1 = new TextBox();
            lblApellido1 = new Label();
            txtNombreCliente = new TextBox();
            lblNombre = new Label();
            txtIdCliente = new TextBox();
            lblId = new Label();
            lblEstado = new Label();
            chkActivo = new CheckBox();
            gbxDatosProducto.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelarCliente
            // 
            btnCancelarCliente.Location = new Point(347, 392);
            btnCancelarCliente.Margin = new Padding(4, 5, 4, 5);
            btnCancelarCliente.Name = "btnCancelarCliente";
            btnCancelarCliente.Size = new Size(161, 60);
            btnCancelarCliente.TabIndex = 7;
            btnCancelarCliente.Text = "Cancelar";
            btnCancelarCliente.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.Location = new Point(521, 392);
            btnGuardarCliente.Margin = new Padding(4, 5, 4, 5);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(161, 60);
            btnGuardarCliente.TabIndex = 6;
            btnGuardarCliente.Text = "Guardar";
            btnGuardarCliente.UseVisualStyleBackColor = true;
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(295, -1);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 45);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Crear Cliente";
            // 
            // gbxDatosProducto
            // 
            gbxDatosProducto.Controls.Add(chkActivo);
            gbxDatosProducto.Controls.Add(lblEstado);
            gbxDatosProducto.Controls.Add(txtCorreoCliente);
            gbxDatosProducto.Controls.Add(label3);
            gbxDatosProducto.Controls.Add(dateCliente);
            gbxDatosProducto.Controls.Add(label2);
            gbxDatosProducto.Controls.Add(txtGenero);
            gbxDatosProducto.Controls.Add(label1);
            gbxDatosProducto.Controls.Add(txtApellido2);
            gbxDatosProducto.Controls.Add(lblApellido2);
            gbxDatosProducto.Controls.Add(txtApellido1);
            gbxDatosProducto.Controls.Add(lblApellido1);
            gbxDatosProducto.Controls.Add(txtNombreCliente);
            gbxDatosProducto.Controls.Add(lblNombre);
            gbxDatosProducto.Controls.Add(txtIdCliente);
            gbxDatosProducto.Controls.Add(lblId);
            gbxDatosProducto.Location = new Point(118, 54);
            gbxDatosProducto.Margin = new Padding(4, 5, 4, 5);
            gbxDatosProducto.Name = "gbxDatosProducto";
            gbxDatosProducto.Padding = new Padding(4, 5, 4, 5);
            gbxDatosProducto.Size = new Size(564, 328);
            gbxDatosProducto.TabIndex = 4;
            gbxDatosProducto.TabStop = false;
            gbxDatosProducto.Text = "Datos de Cliente";
            gbxDatosProducto.Enter += gbxDatosProducto_Enter;
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(379, 190);
            txtCorreoCliente.Margin = new Padding(4, 5, 4, 5);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(128, 31);
            txtCorreoCliente.TabIndex = 13;
            txtCorreoCliente.TextChanged += txtCorreoCliente_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 192);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 12;
            label3.Text = "Correo:";
            // 
            // dateCliente
            // 
            dateCliente.Location = new Point(378, 140);
            dateCliente.Name = "dateCliente";
            dateCliente.Size = new Size(129, 31);
            dateCliente.TabIndex = 11;
            dateCliente.ValueChanged += dateCliente_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 142);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 10;
            label2.Text = "Fecha:";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(379, 89);
            txtGenero.Margin = new Padding(4, 5, 4, 5);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(128, 31);
            txtGenero.TabIndex = 9;
            txtGenero.TextChanged += txtGenero_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 94);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 8;
            label1.Text = "Genero:";
            // 
            // txtApellido2
            // 
            txtApellido2.Location = new Point(112, 214);
            txtApellido2.Margin = new Padding(4, 5, 4, 5);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new Size(177, 31);
            txtApellido2.TabIndex = 7;
            txtApellido2.TextChanged += txtApellido2_TextChanged;
            // 
            // lblApellido2
            // 
            lblApellido2.AutoSize = true;
            lblApellido2.Location = new Point(8, 219);
            lblApellido2.Margin = new Padding(4, 0, 4, 0);
            lblApellido2.Name = "lblApellido2";
            lblApellido2.Size = new Size(97, 25);
            lblApellido2.TabIndex = 6;
            lblApellido2.Text = "Apellido 2:";
            // 
            // txtApellido1
            // 
            txtApellido1.Location = new Point(112, 173);
            txtApellido1.Margin = new Padding(4, 5, 4, 5);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.Size = new Size(177, 31);
            txtApellido1.TabIndex = 5;
            txtApellido1.TextChanged += txtApellido1_TextChanged;
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Location = new Point(8, 178);
            lblApellido1.Margin = new Padding(4, 0, 4, 0);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(97, 25);
            lblApellido1.TabIndex = 4;
            lblApellido1.Text = "Apellido 1:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(112, 132);
            txtNombreCliente.Margin = new Padding(4, 5, 4, 5);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(177, 31);
            txtNombreCliente.TabIndex = 3;
            txtNombreCliente.TextChanged += txtNombreCliente_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 139);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(112, 89);
            txtIdCliente.Margin = new Padding(4, 5, 4, 5);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(177, 31);
            txtIdCliente.TabIndex = 1;
            txtIdCliente.TextChanged += txtIdCliente_TextChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(75, 96);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(300, 233);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 25);
            lblEstado.TabIndex = 14;
            lblEstado.Text = "Estado";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(379, 233);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(88, 29);
            chkActivo.TabIndex = 15;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(btnCancelarCliente);
            Controls.Add(btnGuardarCliente);
            Controls.Add(lblTitulo);
            Controls.Add(gbxDatosProducto);
            Name = "frmCliente";
            Text = "Matentenimiento: Crear Cliente";
            Load += frmCliente_Load;
            gbxDatosProducto.ResumeLayout(false);
            gbxDatosProducto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelarCliente;
        private Button btnGuardarCliente;
        private Label lblTitulo;
        private GroupBox gbxDatosProducto;
        private TextBox txtCorreoCliente;
        private Label label3;
        private DateTimePicker dateCliente;
        private Label label2;
        private TextBox txtGenero;
        private Label label1;
        private TextBox txtApellido2;
        private Label lblApellido2;
        private TextBox txtApellido1;
        private Label lblApellido1;
        private TextBox txtNombreCliente;
        private Label lblNombre;
        private TextBox txtIdCliente;
        private Label lblId;
        private CheckBox chkActivo;
        private Label lblEstado;
    }
}