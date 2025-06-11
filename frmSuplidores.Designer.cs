namespace Proyecto_1_PAvanzada
{
    partial class frmSuplidores
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
            dgvSuplidores = new DataGridView();
            txtid = new TextBox();
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            cmbEstado = new ComboBox();
            btnLimpiar = new Button();
            btnElimiar = new Button();
            btnGuardar = new Button();
            txtEmpresa = new TextBox();
            txtContacto = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtSitio_Web = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSuplidores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSuplidores
            // 
            dgvSuplidores.BackgroundColor = Color.DarkGray;
            dgvSuplidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuplidores.Dock = DockStyle.Fill;
            dgvSuplidores.Location = new Point(246, 0);
            dgvSuplidores.Name = "dgvSuplidores";
            dgvSuplidores.RowHeadersWidth = 51;
            dgvSuplidores.Size = new Size(1387, 652);
            dgvSuplidores.TabIndex = 0;
            dgvSuplidores.CellContentClick += dgvSuplidores_CellCtClick;
            // 
            // txtid
            // 
            txtid.DataBindings.Add(new Binding("Text", bindingSource1, "id_Suplidores", true));
            txtid.Font = new Font("Times New Roman", 12F);
            txtid.Location = new Point(152, 474);
            txtid.Name = "txtid";
            txtid.Size = new Size(10, 30);
            txtid.TabIndex = 4;
            txtid.Visible = false;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(SuplidorFormViewModel);
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnElimiar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtEmpresa);
            panel1.Controls.Add(txtContacto);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtSitio_Web);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtid);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 652);
            panel1.TabIndex = 5;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(12, 413);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 28);
            cmbEstado.TabIndex = 24;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightSeaGreen;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Times New Roman", 16.2F);
            btnLimpiar.Location = new Point(8, 565);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(232, 47);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnElimiar
            // 
            btnElimiar.BackColor = Color.DarkRed;
            btnElimiar.FlatStyle = FlatStyle.Flat;
            btnElimiar.Font = new Font("Times New Roman", 16.2F);
            btnElimiar.Location = new Point(8, 514);
            btnElimiar.Name = "btnElimiar";
            btnElimiar.Size = new Size(232, 45);
            btnElimiar.TabIndex = 22;
            btnElimiar.Text = "Eliminar";
            btnElimiar.UseVisualStyleBackColor = false;
            btnElimiar.Click += btnElimiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MediumSeaGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(8, 462);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(232, 46);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Save";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEmpresa
            // 
            txtEmpresa.DataBindings.Add(new Binding("Text", bindingSource1, "Nombre_Empresa", true));
            txtEmpresa.Font = new Font("Times New Roman", 12F);
            txtEmpresa.Location = new Point(12, 103);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(151, 30);
            txtEmpresa.TabIndex = 20;
            // 
            // txtContacto
            // 
            txtContacto.DataBindings.Add(new Binding("Text", bindingSource1, "Nombre_Contacto", true));
            txtContacto.Font = new Font("Times New Roman", 12F);
            txtContacto.Location = new Point(12, 165);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(151, 30);
            txtContacto.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.DataBindings.Add(new Binding("Text", bindingSource1, "Telefono", true));
            txtTelefono.Font = new Font("Times New Roman", 12F);
            txtTelefono.Location = new Point(12, 227);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(151, 30);
            txtTelefono.TabIndex = 18;
            // 
            // txtCorreo
            // 
            txtCorreo.DataBindings.Add(new Binding("Text", bindingSource1, "Correo", true));
            txtCorreo.Font = new Font("Times New Roman", 12F);
            txtCorreo.Location = new Point(11, 289);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(151, 30);
            txtCorreo.TabIndex = 17;
            // 
            // txtSitio_Web
            // 
            txtSitio_Web.DataBindings.Add(new Binding("Text", bindingSource1, "Sitio_Web", true));
            txtSitio_Web.Font = new Font("Times New Roman", 12F);
            txtSitio_Web.Location = new Point(12, 351);
            txtSitio_Web.Name = "txtSitio_Web";
            txtSitio_Web.Size = new Size(151, 30);
            txtSitio_Web.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F);
            label10.Location = new Point(12, 384);
            label10.Name = "label10";
            label10.Size = new Size(74, 26);
            label10.TabIndex = 12;
            label10.Text = "Estado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(42, 0);
            label9.Name = "label9";
            label9.Size = new Size(170, 38);
            label9.TabIndex = 11;
            label9.Text = "Suplidores";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F);
            label7.Location = new Point(11, 322);
            label7.Name = "label7";
            label7.Size = new Size(102, 26);
            label7.TabIndex = 9;
            label7.Text = "Sitio Web";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F);
            label6.Location = new Point(11, 260);
            label6.Name = "label6";
            label6.Size = new Size(77, 26);
            label6.TabIndex = 8;
            label6.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(11, 198);
            label4.Name = "label4";
            label4.Size = new Size(94, 26);
            label4.TabIndex = 6;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(95, 26);
            label3.TabIndex = 5;
            label3.Text = "Contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(92, 26);
            label2.TabIndex = 4;
            label2.Text = "Empresa";
            // 
            // frmSuplidores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1633, 652);
            Controls.Add(dgvSuplidores);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "frmSuplidores";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSuplidores";
            ((System.ComponentModel.ISupportInitialize)dgvSuplidores).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSuplidores;
        private TextBox txtid;
        private Panel panel1;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmpresa;
        private TextBox txtContacto;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtSitio_Web;
        private Button btnElimiar;
        private Button btnGuardar;
        private BindingSource bindingSource1;
        private Button btnLimpiar;
        private ComboBox cmbEstado;
    }
}