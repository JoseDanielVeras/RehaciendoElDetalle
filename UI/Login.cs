using RehaciendoElDetalle.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RehaciendoElDetalle.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsuariosBLL.ExisteCorreo(CorreoTextBox.Text, ContraseñaTextBox.Text))
            {
                var ventana = new MainForm();
                ventana.Show();
            }
            else
            {
                errorProvider1.SetError(CorreoTextBox, "Usuario o contraseña erroneos");
                errorProvider1.SetError(ContraseñaTextBox, "Usuario o contraseña erroneos");
                ContraseñaTextBox.Clear();
            }
        }
    }
}
