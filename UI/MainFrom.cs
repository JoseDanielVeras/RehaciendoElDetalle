using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtroRegistroCompleto.IU.Registros;

namespace OtroRegistroCompleto.IU.Registros.Menu
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
            this.UsuariosToolStripMenuItem.Click += new EventHandler(this.UsuariostoolStripMenuItem_ItemClicked);
            this.RolesToolStripMenuItem.Click += new EventHandler(this.RolestoolStripMenuItem_ItemClicked);
        }

        private void UsuariostoolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var RegistroUsuariosForm = new RegistroUsuariosForm();
            RegistroUsuariosForm.Show();
        }

        private void RolestoolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var RegistroRoles = new RegistroRoles();
            RegistroRoles.Show();
        }

        private void RegistroRolesButton_Click(object sender, EventArgs e)
        {
            var RegistroRoles = new RegistroRoles();
            RegistroRoles.Show();
        }

        private void RegistroUsuariosButton_Click(object sender, EventArgs e)
        {
            RegistroUsuariosForm registroUsuariosForm = new RegistroUsuariosForm();
            registroUsuariosForm.Show();
        }
    }
}
