using RehaciendoElDetalle.BLL;
using RehaciendoElDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RehaciendoElDetalle.UI.Consultas
{
    public partial class cRoles : Form
    {
        public cRoles()
        {
            InitializeComponent();
        }

        private void cRoles_Load(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Roles>();

            if (FiltroActivoCheckBox.Checked)
            {
                if (TodosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text));
                                break;

                            case 1:
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                                break;

                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => true);
                }
                else if (ActivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && r.EsActivo);
                                break;
                            case 1:
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text.ToUpper()) && r.EsActivo || r.Descripcion.Contains(CriterioTextBox.Text.ToLower()) && r.EsActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => r.EsActivo);
                }
                else if (InactivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && !r.EsActivo);
                                break;
                            case 1:
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text.ToUpper()) && !r.EsActivo || r.Descripcion.Contains(CriterioTextBox.Text.ToLower()) && !r.EsActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => !r.EsActivo);
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0:
                            lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text));
                            break;
                        case 1:
                            lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
                else
                    lista = RolesBLL.GetList(r => true);
            }

            if (FiltroFechaCheckBox.Checked)
            {
                lista = RolesBLL.GetList(l => l.FechaCreacion >= DesdeDateTimePicker.Value && l.FechaCreacion <= HastaDateTimePicker.Value);
            }

            DetalleRolesDataGridView.DataSource = null;
            DetalleRolesDataGridView.DataSource = lista;
        } //BuscarButton_Click

        private void FiltroActivoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FiltroActivoCheckBox.Checked)
            {
                EsActivoGroupBox.Enabled = true;
            }
            else
            {
                EsActivoGroupBox.Enabled = false;
            }
        }
    }
}
