using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OtroRegistroCompleto.BLL;
using OtroRegistroCompleto.Entidades;

namespace OtroRegistroCompleto.IU.Registros
{
    public partial class RegistroRoles : Form
    {
        public List<RolesDetalle> rolDetalle { get; set; }

        public RegistroRoles()
        {
            InitializeComponent();
            this.rolDetalle = new List<RolesDetalle>();
            FechaCreacionDateTimePicker.Format = DateTimePickerFormat.Custom;
            FechaCreacionDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private Roles LlenaClase()
        {
            Roles roles = new Roles();
            roles.RolId = Convert.ToInt32(IdRolNumericUpDown.Value);
            roles.Descripcion = DescripcionTextBox.Text;
            roles.FechaCreacion = FechaCreacionDateTimePicker.Value;
            roles.RolesDetalle = this.rolDetalle;
            LlenarGrid();

            return roles;
        }

        private void LlenarGrid()
        {
            RolesDataGridView.DataSource = null;
            RolesDataGridView.DataSource = rolDetalle;
        }

        private void LLenaCampos(Roles roles)
        {
            IdRolNumericUpDown.Value = roles.RolId;
            DescripcionTextBox.Text = roles.Descripcion;
            this.rolDetalle = roles.RolesDetalle;
            LlenarGrid();

        }

        private bool ExisteEnBaseDeDatos()
        {
            var roles = new Roles();
            roles = RolesBLL.Buscar((int)IdRolNumericUpDown.Value);
            return (roles != null);
        }

        private bool Validar()
        {
            bool paso = true;

            if (DescripcionTextBox.Text == "")
            {
                RolErrorProvider.SetError(DescripcionTextBox, "Obligatorio");
                paso = false;
            }

            return paso;
        }

        void Limpiar()
        {
            IdRolNumericUpDown.Value = 0;
            FechaCreacionDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles roles;
            bool paso = false;

            if (!Validar())
                return;

            roles = LlenaClase();

            //Determinar si es guardar o modificar
            if (IdRolNumericUpDown.Value == 0)
            {
                paso = RolesBLL.Guardar(roles, DescripcionTextBox.Text);
                MessageBox.Show("Se ha guardado correctamente");
            }
            else
            {
                if (!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe");
                    return;
                }
                paso = RolesBLL.Modificar(roles);

            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)IdRolNumericUpDown.Value;
            RolErrorProvider.Clear();

            if (RolesBLL.Eliminar(id))
            {
                MessageBox.Show("El rol ha sido eliminado", "Logrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                RolErrorProvider.SetError(IdRolNumericUpDown, "Este rol no existe");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            int id = (int)IdRolNumericUpDown.Value;

            Limpiar();
            roles = RolesBLL.Buscar(id);
            if (roles != null)
                LLenaCampos(roles);
            else
                MessageBox.Show("Usuario no encontrado");
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (RolesDataGridView.DataSource != null)
                this.rolDetalle = (List<RolesDetalle>)RolesDataGridView.DataSource;

            this.rolDetalle.Add(
                new RolesDetalle(
                    rolId: (int)IdRolNumericUpDown.Value,
                    permisoId: Convert.ToInt32(PermisoIdComboBox.Text),
                    esAsignado: EsAsignadoCheckBox.Checked)
                );
            LlenarGrid();
            EsAsignadoCheckBox.Checked = false;
        }

        private void QuitarButton_Click(object sender, EventArgs e)
        {
            if (RolesDataGridView.Rows.Count > 0 && RolesDataGridView.CurrentRow != null)
            {
                rolDetalle.RemoveAt(RolesDataGridView.CurrentRow.Index);
                LlenarGrid();
            }
        }
    }
}
