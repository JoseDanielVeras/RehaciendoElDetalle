using RehaciendoElDetalle.BLL;
using RehaciendoElDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RehaciendoElDetalle.UI.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            UsuarioIdNumericUpDown.Value = 0;
            aliasTextBox.Clear();
            nombresTextBox.Clear();
            claveTextBox.Clear();
            confirmarTextBox.Clear();
            emailTextBox.Clear();
            activoCheckBox.Checked = false;
        }

        private void LlenaCampos(Usuarios usuarios)
        {
            UsuarioIdNumericUpDown.Value = usuarios.UsuarioId;
            aliasTextBox.Text = usuarios.Alias;
            nombresTextBox.Text = usuarios.Nombres;
            RolComboBox.SelectedIndex = usuarios.RolId;
            emailTextBox.Text = usuarios.Email;
            activoCheckBox.Checked = usuarios.Activo;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = (int)UsuarioIdNumericUpDown.Value;
            usuarios.Nombres = nombresTextBox.Text;
            usuarios.Alias = aliasTextBox.Text;
            usuarios.Clave = Utilitarios.GetSHA256(claveTextBox.Text);
            usuarios.RolId = RolComboBox.SelectedIndex;
            usuarios.Email = emailTextBox.Text;
            usuarios.FechaIngreso = DateTime.Now;
            usuarios.Activo = activoCheckBox.Checked;

            return usuarios;
        }

        private bool Validar()
        {
            bool paso = true;

            if (nombresTextBox.Text == "")
            {
                errorProvider1.SetError(nombresTextBox, "Obligatorio");
                paso = false;
            }

            if (claveTextBox.Text == "")
            {
                errorProvider1.SetError(claveTextBox, "Obligatorio");
                paso = false;
            }

            if (confirmarTextBox.Text == "")
            {
                errorProvider1.SetError(confirmarTextBox, "Obligatorio");
                paso = false;
            }

            if (emailTextBox.Text == "")
            {
                errorProvider1.SetError(emailTextBox, "Obligatorio");
                paso = false;
            }

            if (RolComboBox.Text == "")
            {
                errorProvider1.SetError(RolComboBox, "Obligatorio");
                paso = false;
            }

            if (confirmarTextBox.Text != claveTextBox.Text && confirmarTextBox.Text != "")
            {
                errorProvider1.SetError(confirmarTextBox, "No Coinciden");
                paso = false;
            }

            return paso;
        }

        

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            int id = (int)UsuarioIdNumericUpDown.Value;

            Limpiar();

            var usuarios = UsuariosBLL.Buscar(id);

            if (usuarios != null)
                LlenaCampos(usuarios);
            else
                MessageBox.Show("No Encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios;

            if (!Validar())
                return;

            usuarios = LlenaClase();
            var paso = UsuariosBLL.Guardar(usuarios);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No ha sido guardado con exito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            int id = (int)UsuarioIdNumericUpDown.Value;
            Limpiar();

            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider1.SetError(UsuarioIdNumericUpDown, "No se puede eliminar un usuario que no existe");
        }

        private void rUsuarios_Load(object sender, EventArgs e)
        {
            RolComboBox.DataSource = RolesBLL.GetRoles();
            RolComboBox.DisplayMember = "Descripcion";
            RolComboBox.ValueMember = "RolId";
        }
    }
}
