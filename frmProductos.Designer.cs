namespace Proyecto_1_PAvanzada
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
            components = new System.ComponentModel.Container();
            dgvProductos = new DataGridView();
            panel1 = new Panel();
            btnLimpiar = new Button();
            label4 = new Label();
            cmbEstados = new ComboBox();
            cmbSuplidores = new ComboBox();
            cmbCategoria = new ComboBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPrecioUnitario = new TextBox();
            bindingSource1 = new BindingSource(components);
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.DarkGray;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(250, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(1265, 619);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbEstados);
            panel1.Controls.Add(cmbSuplidores);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPrecioUnitario);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(textBox7);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 619);
            panel1.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpiar.BackColor = Color.LightSeaGreen;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Times New Roman", 16.2F);
            btnLimpiar.Location = new Point(12, 559);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(224, 42);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 38);
            label4.TabIndex = 18;
            label4.Text = "Productos";
            // 
            // cmbEstados
            // 
            cmbEstados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbEstados.DisplayMember = "Nombre_Categoria";
            cmbEstados.Font = new Font("Times New Roman", 10.8F);
            cmbEstados.FormattingEnabled = true;
            cmbEstados.Location = new Point(12, 280);
            cmbEstados.Name = "cmbEstados";
            cmbEstados.Size = new Size(151, 28);
            cmbEstados.TabIndex = 16;
            cmbEstados.ValueMember = "Nombre_Categoria";
            // 
            // cmbSuplidores
            // 
            cmbSuplidores.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbSuplidores.DisplayMember = "Nombre_Categoria";
            cmbSuplidores.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSuplidores.FormattingEnabled = true;
            cmbSuplidores.Location = new Point(12, 407);
            cmbSuplidores.Name = "cmbSuplidores";
            cmbSuplidores.Size = new Size(151, 28);
            cmbSuplidores.TabIndex = 17;
            cmbSuplidores.ValueMember = "Nombre_Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbCategoria.DisplayMember = "Nombre_Categoria";
            cmbCategoria.Font = new Font("Times New Roman", 10.8F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(12, 339);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 15;
            cmbCategoria.ValueMember = "Nombre_Categoria";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Times New Roman", 16.2F);
            btnEliminar.Location = new Point(12, 511);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(224, 42);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardar.BackColor = Color.MediumSeaGreen;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Times New Roman", 16.2F);
            btnGuardar.Location = new Point(12, 463);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(224, 42);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F);
            label9.Location = new Point(12, 310);
            label9.Name = "label9";
            label9.Size = new Size(100, 26);
            label9.TabIndex = 11;
            label9.Text = "Categoria";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F);
            label8.Location = new Point(12, 378);
            label8.Name = "label8";
            label8.Size = new Size(93, 26);
            label8.TabIndex = 10;
            label8.Text = "Suplidor";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F);
            label7.Location = new Point(12, 251);
            label7.Name = "label7";
            label7.Size = new Size(74, 26);
            label7.TabIndex = 9;
            label7.Text = "Estado";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(158, 26);
            label3.TabIndex = 8;
            label3.Text = "Precio  Unitario";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(123, 26);
            label2.TabIndex = 7;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F);
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(88, 26);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtPrecioUnitario.DataBindings.Add(new Binding("Text", bindingSource1, "Precio_Unitario", true));
            txtPrecioUnitario.Font = new Font("Times New Roman", 10.8F);
            txtPrecioUnitario.Location = new Point(12, 221);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(151, 28);
            txtPrecioUnitario.TabIndex = 2;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(ProductosFormViewModel);
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtDescripcion.DataBindings.Add(new Binding("Text", bindingSource1, "Descripcion_Producto", true));
            txtDescripcion.Font = new Font("Times New Roman", 10.8F);
            txtDescripcion.Location = new Point(12, 162);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(151, 28);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNombre.DataBindings.Add(new Binding("Text", bindingSource1, "Nombre_Producto", true));
            txtNombre.Font = new Font("Times New Roman", 10.8F);
            txtNombre.Location = new Point(12, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 28);
            txtNombre.TabIndex = 0;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "Id", true));
            textBox7.Font = new Font("Times New Roman", 10.2F);
            textBox7.Location = new Point(125, 463);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(20, 27);
            textBox7.TabIndex = 12;
            textBox7.Visible = false;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 619);
            Controls.Add(dgvProductos);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProductos";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private Panel panel1;
        private TextBox txtPrecioUnitario;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private TextBox textBox7;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cmbCategoria;
        private BindingSource bindingSource1;
        private ComboBox cmbSuplidores;
        private ComboBox cmbEstados;
        private Label label4;
        private Button btnLimpiar;
        private Button btnEliminar;
    }
}