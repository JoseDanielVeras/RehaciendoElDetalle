using RehaciendoElDetalle.UI;
using RehaciendoElDetalle.UI.Consultas;
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


            this.ConsultaRolesToolStripMenuItem.Click += new EventHandler(this.ConsultaRolesToolStripMenuItem_ItemClicked);
        }

        private void RolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Roles = new RegistroRoles();
            Roles.Show();
        }

        private void ConsultaRolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Roles = new cRoles();
            Roles.Show();
        }

    }
}
