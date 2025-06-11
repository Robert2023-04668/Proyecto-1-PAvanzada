namespace Proyecto_1_PAvanzada
{
    partial class frmCategorias
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
            dgvCategorias = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnGuardarImagen = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            label2 = new Label();
            txtEstado = new TextBox();
            bindingSource1 = new BindingSource(components);
            txtDescripcion = new TextBox();
            txtNombreCategoria = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Dock = DockStyle.Fill;
            dgvCategorias.Location = new Point(224, 0);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(1027, 615);
            dgvCategorias.TabIndex = 0;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnGuardarImagen);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEstado);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtNombreCategoria);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtId);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 615);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnGuardarImagen
            // 
            btnGuardarImagen.Cursor = Cursors.Hand;
            btnGuardarImagen.Font = new Font("Times New Roman", 12F);
            btnGuardarImagen.Location = new Point(3, 473);
            btnGuardarImagen.Name = "btnGuardarImagen";
            btnGuardarImagen.Size = new Size(206, 32);
            btnGuardarImagen.TabIndex = 10;
            btnGuardarImagen.Text = "Asignar Imagen";
            btnGuardarImagen.UseVisualStyleBackColor = true;
            btnGuardarImagen.Click += btnGuardarImagen_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Times New Roman", 12F);
            btnEliminar.Location = new Point(3, 581);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(206, 32);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Times New Roman", 12F);
            btnAgregar.Location = new Point(3, 511);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(206, 32);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Times New Roman", 12F);
            btnGuardar.Location = new Point(3, 546);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(206, 32);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(3, 395);
            label3.Name = "label3";
            label3.Size = new Size(64, 22);
            label3.TabIndex = 5;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(3, 337);
            label2.Name = "label2";
            label2.Size = new Size(107, 22);
            label2.TabIndex = 4;
            label2.Text = "Descripcion";
            // 
            // txtEstado
            // 
            txtEstado.DataBindings.Add(new Binding("Text", bindingSource1, "C_EstadoId", true));
            txtEstado.Font = new Font("Times New Roman", 12F);
            txtEstado.Location = new Point(3, 420);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(125, 30);
            txtEstado.TabIndex = 3;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(categoriasFrmViewModel);
            // 
            // txtDescripcion
            // 
            txtDescripcion.DataBindings.Add(new Binding("Text", bindingSource1, "Descripcion", true));
            txtDescripcion.Font = new Font("Times New Roman", 12F);
            txtDescripcion.Location = new Point(3, 362);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(206, 30);
            txtDescripcion.TabIndex = 2;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.DataBindings.Add(new Binding("Text", bindingSource1, "Nombre_Categoria", true));
            txtNombreCategoria.Font = new Font("Times New Roman", 12F);
            txtNombreCategoria.Location = new Point(3, 301);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(125, 30);
            txtNombreCategoria.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(3, 276);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.DataBindings.Add(new Binding("Text", bindingSource1, "id_Categorias", true));
            txtId.Location = new Point(71, 174);
            txtId.Name = "txtId";
            txtId.Size = new Size(18, 27);
            txtId.TabIndex = 8;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 615);
            Controls.Add(dgvCategorias);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCategorias";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategorias;
        private Panel panel1;
        private TextBox txtEstado;
        private TextBox txtDescripcion;
        private TextBox txtNombreCategoria;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btnGuardar;
        private BindingSource bindingSource1;
        private Button btnAgregar;
        private TextBox txtId;
        private Button btnEliminar;
        private Button btnGuardarImagen;
        private PictureBox pictureBox1;
    }
}