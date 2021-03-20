using RehaciendoElDetalle.UI;
using RehaciendoElDetalle.UI.Consultas;
using RehaciendoElDetalle.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehaciendoElDetalle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.RolesToolStripMenuItem.Click += new EventHandler(this.RolesToolStripMenuItem_ItemClicked);
            this.UsuariosToolStripMenuItem.Click += new EventHandler(this.UsuariosToolStripMenuItem_ItemClicked);


            this.ConsultaRolesToolStripMenuItem.Click += new EventHandler(this.ConsultaRolesToolStripMenuItem_ItemClicked);
            this.ConsultaUsuariosToolStripMenuItem.Click += new EventHandler(this.ConsultaUsuariosToolStripMenuItem_ItemClicked);
        }

        private void RolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Roles = new rRoles();
            Roles.Show();
        }

        private void UsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Usuarios = new rUsuarios();
            Usuarios.Show();
        }

        private void ConsultaRolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Roles = new cRoles();
            Roles.Show();
        }

        private void ConsultaUsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Usuarios = new cUsuarios();
            Usuarios.Show();
        }

    }
}
