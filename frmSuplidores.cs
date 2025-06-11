using FluentValidation;

namespace Proyecto_1_PAvanzada
{
    public partial class frmSuplidores : Form
    {
        private readonly SuplidorFormViewModel ViewModel = new SuplidorFormViewModel();
        private readonly SuplidoresRepo suplidoresRepo;
        private readonly SuplidoresFormValidator _Validator;

        public frmSuplidores(SuplidoresRepo suplidoresRepo, SuplidoresFormValidator validator)
        {
            InitializeComponent();
            this.suplidoresRepo = suplidoresRepo;
            this._Validator = validator;
            Load += FrmSuplidores;
        }
        private void FrmSuplidores(object? sender, EventArgs e)
        {
            CargarDatos();
            bindingSource1.Add(ViewModel);
            cargarcmb();
        }
        private void dgvSuplidores_CellCtClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSuplidores.Rows[e.RowIndex];
                ViewModel.id_Suplidores = int.Parse(txtid.Text = row.Cells[0].Value.ToString());
                ViewModel.Nombre_Empresa = txtEmpresa.Text = row.Cells[1].Value.ToString();
                ViewModel.Nombre_Contacto = txtContacto.Text = row.Cells[2].Value.ToString();
                ViewModel.Telefono = txtTelefono.Text = row.Cells[3].Value.ToString();
                ViewModel.Correo = txtCorreo.Text = row.Cells[4].Value.ToString();
                ViewModel.Sitio_Web = txtSitio_Web.Text = row.Cells[5].Value.ToString();
                cmbEstado.SelectedValue = ViewModel.S_EstadoId = int.Parse(row.Cells[8].Value.ToString());
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "0")
            {
                bool validation = Validar();
                if (!validation)
                {
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Esta seguro de querer agregar este nuevo suplidor?", "Seguro?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {

                    suplidoresRepo.Create(new C_Suplidoress
                    {
                        Nombre_Empresa = ViewModel.Nombre_Empresa,
                        Nombre_Contacto = ViewModel.Nombre_Contacto,
                        Telefono = ViewModel.Telefono,
                        Correo = ViewModel.Correo,
                        Sitio_Web = ViewModel.Sitio_Web,
                        S_EstadoId = ViewModel.S_EstadoId
                    });
                    CargarDatos();
                    dgvSuplidores.Refresh();
                    dgvSuplidores.AutoResizeColumns();
                }
            }
            else
            {
                bool validation = Validar();

                if (!validation)
                {
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Esta seguro de querer Modificar este nuevo suplidor?", "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (dgvSuplidores.SelectedRows.Count <= 0)
                    {
                        MessageBox.Show("Debe serelccionar un Suplidor, el cual eliminar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        suplidoresRepo.Update(new C_Suplidoress
                        {
                            id_Suplidores = ViewModel.id_Suplidores,
                            Nombre_Empresa = ViewModel.Nombre_Empresa,
                            Nombre_Contacto = ViewModel.Nombre_Contacto,
                            Telefono = ViewModel.Telefono,
                            Correo = ViewModel.Correo,
                            Sitio_Web = ViewModel.Sitio_Web,
                            S_EstadoId = ViewModel.S_EstadoId
                        });

                        CargarDatos();
                        dgvSuplidores.Refresh();
                        dgvSuplidores.AutoResizeColumns();
                    }
                }
            }
        }
        public void cargarcmb()
        {

            var Estados = suplidoresRepo.GetEstados();
            cmbEstado.DataSource = Estados;
            cmbEstado.DisplayMember = "Nombre_Estado";
            cmbEstado.ValueMember = "id_Estado";

        }
        private bool Validar()
        {
            var validationResult = _Validator.Validate(ViewModel);
            if (!validationResult.IsValid)
            {
                var mensaje = string.Join('\n', validationResult.Errors.Select(a => a.ErrorMessage).ToList());
                MessageBox.Show(mensaje, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void btnElimiar_Click(object sender, EventArgs e)
        {
            bool Validation = Validar();
            if (!Validation)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Esta seguro de querer Eliminar este  suplidor?", "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (dgvSuplidores.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Debe serelccionar un Suplidor, el cual eliminar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    var suplidoress = (C_Suplidoress)dgvSuplidores.SelectedRows[0].DataBoundItem;
                    suplidoresRepo.Delete(suplidoress.id_Suplidores);
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("La operacion ha sido cancelada", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CargarDatos()
        {
            var Suplidoress = suplidoresRepo.GetSuplidores();
            dgvSuplidores.DataSource = Suplidoress;
            dgvSuplidores.AutoResizeColumns();
            dgvSuplidores.CellClick += dgvSuplidores_CellCtClick;
            dgvSuplidores.AutoResizeColumnHeadersHeight();
            dgvSuplidores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuplidores.ReadOnly = true;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtContacto.Text = "";
            txtCorreo.Text = "";
            txtEmpresa.Text = "";
            txtSitio_Web.Text = "";
            txtid.Text = "0";
            txtTelefono.Text = "";
            ViewModel.id_Suplidores = 0;
            ViewModel.Nombre_Contacto = "";
            ViewModel.Nombre_Empresa = "";
            ViewModel.Telefono = "";
            ViewModel.Correo = "";
            ViewModel.Sitio_Web = "";
            cmbEstado.SelectedIndex = 0;
        }

    }
    public class SuplidorFormViewModel
    {
        public int id_Suplidores { get; set; }
        public string Nombre_Empresa { get; set; }
        public string Nombre_Contacto { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Sitio_Web { get; set; }
        public DateTime S_Fecha_Creacion { get; set; }
        public DateTime S_Fecha_Modificacion { get; set; }
        public int S_EstadoId { get; set; }

    }
    public class SuplidoresFormValidator : AbstractValidator<SuplidorFormViewModel>
    {
        public SuplidoresFormValidator()
        {
            RuleFor(a => a.Nombre_Empresa).NotEmpty().Length(1, 49).WithMessage("El nombre de la empresa es requerido");
            RuleFor(a => a.Nombre_Contacto).NotEmpty().Length(1, 49).WithMessage("El nombre del contacto es requerido");
            RuleFor(a => a.Nombre_Contacto).MaximumLength(50).WithMessage("El nombre del contacto no puede superar los 50 caracteres (espacion cuentan)");
            RuleFor(a => a.Nombre_Empresa).MaximumLength(50).WithMessage("El nombre de la empresa no puede superar los 50 caracteres (espacion cuentan)");
            RuleFor(a => a.S_EstadoId).NotEmpty().WithMessage("El estado es requerido");
            RuleFor(a => a.Correo).NotEmpty().WithMessage("El correo es requerido");
            RuleFor(a => a.Telefono).NotEmpty().WithMessage("El telefono es requerido");
            RuleFor(a => a.Sitio_Web).NotEmpty().WithMessage("El sitio web es requerido");
            RuleFor(a => a.Telefono).Matches(@"^8[024]9-[0-9]{3}-[0-9]{4}$").WithMessage("Formato Telefonico invalido");
            RuleFor(a => a.Correo).NotEmpty().EmailAddress().WithMessage("Formato de  correo Invalido");

        }
    }
}
