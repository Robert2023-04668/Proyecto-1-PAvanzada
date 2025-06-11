using FluentValidation;
using System.Data;

namespace Proyecto_1_PAvanzada
{
    public partial class frmProductos : Form
    {
        //Instancias, load 
        #region
        private readonly ProductoRepo productoRepo;
        private readonly ProductosFormViewModel viewModel = new ProductosFormViewModel();
        private readonly ProdutosformValidation _validator;
    
        public frmProductos(ProductoRepo productoRepo, ProdutosformValidation validation)
        {
            InitializeComponent();
            this.productoRepo = productoRepo;
            this._validator = validation;
            Load += FrmProductos_Load;
        }
      

        private void FrmProductos_Load(object? sender, EventArgs e)
        {
            CargarDatos();
            cargarcmb();
            bindingSource1.Add(viewModel);
           
        }

        #endregion

        //Extraccion de datos atraves del dgv
        #region
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];


                viewModel.Id = int.Parse(textBox7.Text = row.Cells[0].Value.ToString());
                viewModel.Nombre_Producto = txtNombre.Text = row.Cells[1].Value.ToString();
                viewModel.Descripcion_Producto = txtDescripcion.Text = row.Cells[2].Value.ToString();
                viewModel.Precio_Unitario = decimal.Parse(txtPrecioUnitario.Text = row.Cells[3].Value.ToString());
                cmbEstados.SelectedValue = viewModel.P_EstadoId = Convert.ToInt32(row.Cells[6].Value);
                cmbCategoria.SelectedValue = viewModel.id_Categoria = Convert.ToInt32(row.Cells[7].Value);
                cmbSuplidores.SelectedValue = viewModel.id_Suplidor = Convert.ToInt32(row.Cells[8].Value);
            }
        }
        #endregion

        // Botones
        #region
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            viewModel.P_EstadoId = (int)cmbEstados.SelectedValue;
            viewModel.id_Categoria = (int)cmbCategoria.SelectedValue;
            viewModel.id_Suplidor = (int)cmbSuplidores.SelectedValue;
            bool flowControl = GuardarProducto();
            if (!flowControl)
            {
                return;
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool flowControl = EliminarProducto();
            if (!flowControl)
            {
                return;
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        #endregion

        //Metodos
        #region 
        private void CargarDatos()
        {
            dgvProductos.DataSource = productoRepo.GetProductos();
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoResizeColumns();
            dgvProductos.AutoResizeColumnHeadersHeight();
            dgvProductos.ReadOnly = true;
        }
        private bool GuardarProducto()
        {
            if (!Validar()) return false;



            if (viewModel.Id == 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea agregar este nuevo producto?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    productoRepo.create(new C_Productos
                    {
                        Nombre_Producto = viewModel.Nombre_Producto,
                        Descripcion_Producto = viewModel.Descripcion_Producto,
                        Precio_Unitario = viewModel.Precio_Unitario,
                        P_EstadoId = viewModel.P_EstadoId,
                        id_Categoria = viewModel.id_Categoria,
                        id_Suplidor = viewModel.id_Suplidor
                    });

                    CargarDatos();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea modificar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (dgvProductos.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar un producto para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    productoRepo.Update(new C_Productos
                    {
                        Id = viewModel.Id,
                        Nombre_Producto = viewModel.Nombre_Producto,
                        Descripcion_Producto = viewModel.Descripcion_Producto,
                        Precio_Unitario = viewModel.Precio_Unitario,
                        P_EstadoId = viewModel.P_EstadoId,
                        id_Categoria = viewModel.id_Categoria,
                        id_Suplidor = viewModel.id_Suplidor
                    });

                    CargarDatos();
                }
            }

            return true;
        }
        private bool Validar()
        {
            var validationResult = _validator.Validate(viewModel);
            if (!validationResult.IsValid)
            {
                var mensaje = string.Join('\n', validationResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool EliminarProducto()
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (dgvProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                var producto = (C_Productos)dgvProductos.SelectedRows[0].DataBoundItem;
                productoRepo.Delete(producto.Id);
                CargarDatos();
            }
            else
            {
                MessageBox.Show("La operación ha sido cancelada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return true;
        }
        public void cargarcmb()
        {
            var categorias = productoRepo.GetCategorias();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre_Categoria";
            cmbCategoria.ValueMember = "id_Categorias";

            var suplidores = productoRepo.GetSuplidores();
            cmbSuplidores.DataSource = suplidores;
            cmbSuplidores.DisplayMember = "Nombre_Empresa";
            cmbSuplidores.ValueMember = "id_Suplidores";

            var Estados = productoRepo.GetEstados();
            cmbEstados.DataSource = Estados;
            cmbEstados.DisplayMember = "Nombre_Estado";
            cmbEstados.ValueMember = "id_Estado";

        }
        private void LimpiarFormulario()
        {
           
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtPrecioUnitario.Text = "";
            viewModel.Id = 0;
            viewModel.Nombre_Producto = "";
            viewModel.Descripcion_Producto = "";
            viewModel.Precio_Unitario = 0;
            cmbCategoria.SelectedIndex = 0;
            cmbEstados.SelectedIndex = 0;
            cmbSuplidores.SelectedIndex = 0;
        }
        #endregion
    }
    public class ProductosFormViewModel
    {
        public int Id { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public decimal Precio_Unitario { get; set; }
        public int P_EstadoId { get; set; }
        public int id_Categoria { get; set; }
        public int id_Suplidor { get; set; }
        public string Nombre_Categoria { get; set; }
        public string Nombre_Empresa { get; set; }
        public string Nombre_Estado { get; set; }
    }
    public class ProdutosformValidation : AbstractValidator<ProductosFormViewModel>
    {
        public ProdutosformValidation()
        {
            RuleFor(a => a.Nombre_Producto).NotEmpty().WithMessage("El nombre del producto es requerido");
            RuleFor(a => a.Descripcion_Producto).NotEmpty().WithMessage("La descripción del producto es requerida");
            RuleFor(a => a.Precio_Unitario).NotEmpty().WithMessage("El precio del producto es requerido");
            RuleFor(a => a.P_EstadoId).NotEmpty().WithMessage("El estado del producto es requerido");
            RuleFor(a => a.id_Categoria).NotEmpty().WithMessage("La categoría del producto es requerida");
            RuleFor(a => a.id_Suplidor).NotEmpty().WithMessage("El suplidor del producto es requerido");
        }
    }
}
