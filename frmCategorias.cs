using FluentValidation;
using System.Windows.Forms;
namespace Proyecto_1_PAvanzada
{
    public partial class frmCategorias : Form
    {

        //Instancias, load 
        #region
        private readonly categoriasFrmViewModel viewModel = new categoriasFrmViewModel();
        private readonly CategoriasRepo categoriasRepo;
        categoriasFormValidation validation;
        private ImagenRepo ImagenRepo;
        private List<byte[]> imagenesCategoria = new List<byte[]>();
        private int indiceActual = 0;

        public frmCategorias(CategoriasRepo categoriasRepo, ImagenRepo imagenRepo, categoriasFormValidation validations)
        {
            InitializeComponent();
            this.categoriasRepo = categoriasRepo;
            this.ImagenRepo = imagenRepo;
            this.validation = validations;

            Load += FrmCategorias_Load;

        }

        private void FrmCategorias_Load(object? sender, EventArgs e)
        {

            bindingSource1.Add(viewModel);
            CargarDatos();

        }
        #endregion

        //Extraccion de datos atraves del dgv
        #region
        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategorias.Rows[e.RowIndex];
                viewModel.Nombre_Categoria = txtNombreCategoria.Text = row.Cells[1].Value.ToString();
                viewModel.Descripcion = txtDescripcion.Text = row.Cells[2].Value.ToString();
                viewModel.C_EstadoId = int.Parse(txtEstado.Text = row.Cells[5].Value.ToString());
                viewModel.id_Categorias = int.Parse(txtId.Text = row.Cells[0].Value.ToString());
            }
        }
        #endregion

        //Botones
        #region
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool flowControl = GuardarCategoria();
            if (!flowControl)
            {
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool flowControl = EliminarCategoria();
            if (!flowControl)
            {
                return;
            }
        }
        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] imagenBytes = File.ReadAllBytes(ofd.FileName);
                if (!int.TryParse(txtId.Text, out int idCategoria))
                {
                    MessageBox.Show("Ingrese un ID de categoría válido.");
                    return;
                }

                ImagenRepo.InsertarImagenYCategoria(imagenBytes, idCategoria);
                MessageBox.Show("Imagen guardada correctamente.");
                byte[] imagen = ImagenRepo.GetImagenPorCategoria(idCategoria).FirstOrDefault();

                if (imagen != null)
                {
                    using (var ms = new MemoryStream(imagen))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }



        }

        #endregion

        //Metodos
        #region
        private void MostrarImagen(int indice)
        {
            if (imagenesCategoria == null || imagenesCategoria.Count == 0)
            {
                pictureBox1.Image = null;
                return;
            }

            if (indice < 0 || indice >= imagenesCategoria.Count)
            {
                MessageBox.Show("Índice de imagen fuera de rango.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var ms = new MemoryStream(imagenesCategoria[indice]))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
        }
        private bool GuardarCategoria()
        {
            if (!Validar())
            {
                return false;
            }
            if (viewModel.id_Categorias == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro de querer agregar esta nueva categoria?", "Seguro?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {


                    categoriasRepo.Create(new C_Categorias
                    {
                        Nombre_Categoria = viewModel.Nombre_Categoria,
                        Descripcion = viewModel.Descripcion,
                        C_EstadoId = viewModel.C_EstadoId,
                    });
                    CargarDatos();
                }
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Esta seguro de querer Modificar esta  Categoria?", "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (dgvCategorias.SelectedRows.Count <= 0)
                    {
                        MessageBox.Show("Debe seleccionar una categoria, la cual eliminar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        categoriasRepo.Update(new C_Categorias
                        {
                            id_Categorias = viewModel.id_Categorias,
                            Nombre_Categoria = viewModel.Nombre_Categoria,
                            Descripcion = viewModel.Descripcion,
                            C_EstadoId = viewModel.C_EstadoId
                        });
                        CargarDatos();
                    }

                }
            }

            return true;
        }
        private void CargarDatos()
        {
            var categorias = categoriasRepo.GetCategorias();
            dgvCategorias.DataSource = categorias;
            dgvCategorias.AutoResizeColumns();
            dgvCategorias.Refresh();
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.AutoResizeColumnHeadersHeight();
            dgvCategorias.ReadOnly = true;
        }
        private void MostrarImagenPorCategoria(int idCategoria)
        {
            imagenesCategoria = ImagenRepo.GetImagenPorCategoria(idCategoria).ToList();

            if (imagenesCategoria.Count > 0)
            {
                indiceActual = 0;
                MostrarImagen(indiceActual);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (imagenesCategoria.Count >= 1)
            {
                indiceActual = (indiceActual + 1) % imagenesCategoria.Count; // Círculo infinito
                MostrarImagen(indiceActual);
            }
        }
        private bool Validar()
        {
            var validationResult = validation.Validate(viewModel);
            if (!validationResult.IsValid)
            {
                var mensaje = string.Join('\n', validationResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void LimpiarFormulario()
        {
            txtDescripcion.Text = "";
            txtEstado.Text = "";
            txtNombreCategoria.Text = "";
            viewModel.id_Categorias = 0;
            viewModel.Descripcion = "";
            viewModel.C_EstadoId = 1;
        }
        private bool EliminarCategoria()
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro de querer Eliminar esta  categoria?", "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (dgvCategorias.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Debe serelccionar una categoria la cual eliminar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {

                    var categorias = (C_Categorias)dgvCategorias.SelectedRows[0].DataBoundItem;
                    categoriasRepo.Delete(categorias.id_Categorias);
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("La operacion ha sido cancelada", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return true;
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            MostrarImagenPorCategoria(int.Parse(txtId.Text));
        }
        #endregion

        public class categoriasFrmViewModel
        {
            public int id_Categorias { get; set; }
            public string Nombre_Categoria { get; set; }
            public string Descripcion { get; set; }
            public DateTime C_Fecha_Creacion { get; set; }
            public DateTime C_Fecha_Modificacion { get; set; }
            public int C_EstadoId { get; set; }
        }
        public class categoriasFormValidation : AbstractValidator<categoriasFrmViewModel>
        {
            public categoriasFormValidation()
            {
                RuleFor(a => a.Nombre_Categoria).NotEmpty().WithMessage("El nombre de la categoria es necesario");
                RuleFor(a => a.Descripcion).NotEmpty().WithMessage("La descripcion de la categoria es necesaria");
                RuleFor(a => a.C_EstadoId).NotEmpty().WithMessage("La categoria debe estar en un estado");

            }
        }
    }
}





