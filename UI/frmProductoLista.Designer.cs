namespace UI
{
    partial class frmProductoLista
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
            lblTitulo = new Label();
            btnNuevo = new Button();
            gbxLista = new GroupBox();
            label1 = new Label();
            txtBusqueda = new TextBox();
            lstvLista = new ListView();
            colId = new ColumnHeader();
            colNombre = new ColumnHeader();
            colPrecio = new ColumnHeader();
            gbxLista.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(227, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(412, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenimiento Productos";
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.Red;
            btnNuevo.FlatAppearance.BorderSize = 3;
            btnNuevo.Location = new Point(693, 35);
            btnNuevo.Margin = new Padding(4, 5, 4, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(171, 67);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = " Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // gbxLista
            // 
            gbxLista.Controls.Add(label1);
            gbxLista.Controls.Add(txtBusqueda);
            gbxLista.Controls.Add(lstvLista);
            gbxLista.Location = new Point(17, 112);
            gbxLista.Margin = new Padding(4, 5, 4, 5);
            gbxLista.Name = "gbxLista";
            gbxLista.Padding = new Padding(4, 5, 4, 5);
            gbxLista.Size = new Size(847, 645);
            gbxLista.TabIndex = 2;
            gbxLista.TabStop = false;
            gbxLista.Text = "Lista Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 4;
            label1.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(26, 83);
            txtBusqueda.Margin = new Padding(4, 5, 4, 5);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(790, 31);
            txtBusqueda.TabIndex = 3;
            // 
            // lstvLista
            // 
            lstvLista.Columns.AddRange(new ColumnHeader[] { colId, colNombre, colPrecio });
            lstvLista.FullRowSelect = true;
            lstvLista.GridLines = true;
            lstvLista.HoverSelection = true;
            lstvLista.Location = new Point(26, 147);
            lstvLista.Margin = new Padding(4, 5, 4, 5);
            lstvLista.MultiSelect = false;
            lstvLista.Name = "lstvLista";
            lstvLista.Size = new Size(794, 486);
            lstvLista.TabIndex = 0;
            lstvLista.UseCompatibleStateImageBehavior = false;
            lstvLista.View = View.Details;
            lstvLista.SelectedIndexChanged += lstvLista_SelectedIndexChanged;
            lstvLista.MouseDoubleClick += lstvLista_MouseDoubleClick;
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
            // colPrecio
            // 
            colPrecio.Text = "Precio";
            colPrecio.Width = 150;
            // 
            // frmProductoLista
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 775);
            Controls.Add(btnNuevo);
            Controls.Add(gbxLista);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmProductoLista";
            Text = "Mantenimiento: Productos";
            Load += frmProductoLista_Load;
            gbxLista.ResumeLayout(false);
            gbxLista.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnNuevo;
        private GroupBox gbxLista;
        private ListView lstvLista;
        private TextBox txtBusqueda;
        private Label label1;
        private ColumnHeader colId;
        private ColumnHeader colNombre;
        private ColumnHeader colPrecio;
    }
}