namespace UI
{
    partial class frmClienteLista
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
            btnNuevoCliente = new Button();
            gbxListaCliente = new GroupBox();
            label1 = new Label();
            txtBusquedaCliente = new TextBox();
            lstvListaCliente = new ListView();
            colId = new ColumnHeader();
            colNombre = new ColumnHeader();
            colApellido1 = new ColumnHeader();
            colApellido2 = new ColumnHeader();
            colGenero = new ColumnHeader();
            colFecha = new ColumnHeader();
            colCorreo = new ColumnHeader();
            colEstado = new ColumnHeader();
            lblTitulo = new Label();
            gbxListaCliente.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.FlatAppearance.BorderColor = Color.Red;
            btnNuevoCliente.FlatAppearance.BorderSize = 3;
            btnNuevoCliente.Location = new Point(745, 39);
            btnNuevoCliente.Margin = new Padding(4, 5, 4, 5);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(171, 67);
            btnNuevoCliente.TabIndex = 4;
            btnNuevoCliente.Text = " Nuevo";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            btnNuevoCliente.TextChanged += btnNuevoCliente_TextChanged;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // gbxListaCliente
            // 
            gbxListaCliente.Controls.Add(label1);
            gbxListaCliente.Controls.Add(txtBusquedaCliente);
            gbxListaCliente.Controls.Add(lstvListaCliente);
            gbxListaCliente.Location = new Point(69, 116);
            gbxListaCliente.Margin = new Padding(4, 5, 4, 5);
            gbxListaCliente.Name = "gbxListaCliente";
            gbxListaCliente.Padding = new Padding(4, 5, 4, 5);
            gbxListaCliente.Size = new Size(847, 645);
            gbxListaCliente.TabIndex = 5;
            gbxListaCliente.TabStop = false;
            gbxListaCliente.Text = "Lista Clientes";
            gbxListaCliente.Enter += gbxListaCliente_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 4;
            label1.Text = "Busqueda:";
            // 
            // txtBusquedaCliente
            // 
            txtBusquedaCliente.Location = new Point(26, 83);
            txtBusquedaCliente.Margin = new Padding(4, 5, 4, 5);
            txtBusquedaCliente.Name = "txtBusquedaCliente";
            txtBusquedaCliente.Size = new Size(790, 31);
            txtBusquedaCliente.TabIndex = 3;
            // 
            // lstvListaCliente
            // 
            lstvListaCliente.Columns.AddRange(new ColumnHeader[] { colId, colNombre, colApellido1, colApellido2, colGenero, colFecha, colCorreo, colEstado });
            lstvListaCliente.FullRowSelect = true;
            lstvListaCliente.GridLines = true;
            lstvListaCliente.Location = new Point(26, 147);
            lstvListaCliente.Margin = new Padding(4, 5, 4, 5);
            lstvListaCliente.MultiSelect = false;
            lstvListaCliente.Name = "lstvListaCliente";
            lstvListaCliente.Size = new Size(794, 486);
            lstvListaCliente.TabIndex = 0;
            lstvListaCliente.UseCompatibleStateImageBehavior = false;
            lstvListaCliente.View = View.Details;
            lstvListaCliente.SelectedIndexChanged += lstvListaCliente_SelectedIndexChanged;
            lstvListaCliente.MouseDoubleClick += lstvListaCliente_MouseDoubleClick_1;
            // 
            // colId
            // 
            colId.Text = "ID";
            colId.Width = 100;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 300;
            // 
            // colApellido1
            // 
            colApellido1.Text = "Apellido 1";
            colApellido1.Width = 150;
            // 
            // colApellido2
            // 
            colApellido2.Text = "Apellido 2";
            // 
            // colGenero
            // 
            colGenero.Text = "Genero";
            // 
            // colFecha
            // 
            colFecha.Text = "Fecha";
            // 
            // colCorreo
            // 
            colCorreo.Text = "Correo";
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(279, 19);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(415, 45);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Administración de clientes";
            lblTitulo.TextChanged += lblTitulo_TextChanged;
            // 
            // frmClienteLista
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 686);
            Controls.Add(btnNuevoCliente);
            Controls.Add(gbxListaCliente);
            Controls.Add(lblTitulo);
            Name = "frmClienteLista";
            Text = "Administración de clientes";
            Load += frmClienteLista_Load;
            gbxListaCliente.ResumeLayout(false);
            gbxListaCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevoCliente;
        private GroupBox gbxListaCliente;
        private Label label1;
        private TextBox txtBusquedaCliente;
        private ListView lstvListaCliente;
        private ColumnHeader colId;
        private ColumnHeader colNombre;
        private ColumnHeader colApellido1;
        private Label lblTitulo;
        private ColumnHeader colApellido2;
        private ColumnHeader colGenero;
        private ColumnHeader colFecha;
        private ColumnHeader colCorreo;
        private ColumnHeader colEstado;
    }
}