using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RehaciendoElDetalle.BLL;
using RehaciendoElDetalle.Entidades;


namespace RehaciendoElDetalle.UI
{
    public partial class RegistroRoles : Form
    {
        public List<RolesDetalle> rolesDetalles { get; set; }

        public RegistroRoles()
        {
            InitializeComponent();
            this.rolesDetalles = new List<RolesDetalle>();
        }

        private void LlenarGrid()
        {
            RolesDataGridView.DataSource = null;
            RolesDataGridView.DataSource = rolesDetalles;
        }

        private void Limpiar()
        {
            IdRolNumericUpDown.Value = 0;
            FechaCreacionDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();
            RolesDataGridView.DataSource = null;
        }

        private bool Validar()
        {
            bool paso = true;

            if (DescripcionTextBox.Text == "")
            {
                errorProvider.SetError(DescripcionTextBox, "Obligatorio");
                paso = false;
            }

            return paso;
        }

        private Roles LlenaClase()
        {
            Roles roles = new Roles();
            roles.RolId = (int)IdRolNumericUpDown.Value;
            roles.Descripcion = DescripcionTextBox.Text;
            roles.FechaCreacion = FechaCreacionDateTimePicker.Value;
            roles.RolesDetalle = this.rolesDetalles;
            LlenarGrid();

            return roles;
        }

        private void LlenaCampos(Roles roles)
        {
            IdRolNumericUpDown.Value = roles.RolId;
            DescripcionTextBox.Text = roles.Descripcion;
            this.rolesDetalles = roles.RolesDetalle;
            LlenarGrid();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles roles;

            if (!Validar())
                return;

            roles = LlenaClase();

            var paso = RolesBLL.Guardar(roles);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("El rol ha sido guardado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El rol no ha sido guardado", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)IdRolNumericUpDown.Value;
            errorProvider.Clear();

            if (RolesBLL.Eliminar(id))
            {
                MessageBox.Show("El rol ha sido eliminado", "Logrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                errorProvider.SetError(IdRolNumericUpDown, "El id no existe");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            int id = (int)IdRolNumericUpDown.Value;

            Limpiar();

            roles = RolesBLL.Buscar(id);

            if (roles != null)
                LlenaCampos(roles);
            else
                MessageBox.Show("Rol no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (RolesDataGridView.DataSource != null)
                this.rolesDetalles = (List<RolesDetalle>)RolesDataGridView.DataSource;

            this.rolesDetalles.Add(
                new RolesDetalle(
                    id: 0,
                    rolId: (int)IdRolNumericUpDown.Value,
                    permisoId: Convert.ToInt32(PermisoIdComboBox.Text),
                    esAsignado: EsAsignadoCheckBox.Checked)
                );
            LlenarGrid();
            EsAsignadoCheckBox.Checked = false;
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if(RolesDataGridView.Rows.Count > 0 && RolesDataGridView.CurrentRow != null)
            {
                rolesDetalles.RemoveAt(RolesDataGridView.CurrentRow.Index);
                LlenarGrid();
            }
        }

        private void RegistroRoles_Load(object sender, EventArgs e)
        {
            PermisoIdComboBox.DataSource = PermisosBLL.GetPermisos();
            PermisoIdComboBox.DisplayMember = "PermisoId";
            PermisoIdComboBox.ValueMember = "PermisoId";
        }

        
    }
}
