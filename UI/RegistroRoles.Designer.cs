
namespace RehaciendoElDetalle.UI
{
    partial class RegistroRoles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroRoles));
            this.PermisoIdComboBox = new System.Windows.Forms.ComboBox();
            this.PermisoIdLabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.IdRolNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.IdRolLabel = new System.Windows.Forms.Label();
            this.EsAsignadoCheckBox = new System.Windows.Forms.CheckBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.RolesDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.IdRolNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PermisoIdComboBox
            // 
            this.PermisoIdComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PermisoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PermisoIdComboBox.FormattingEnabled = true;
            this.PermisoIdComboBox.Location = new System.Drawing.Point(149, 148);
            this.PermisoIdComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PermisoIdComboBox.Name = "PermisoIdComboBox";
            this.PermisoIdComboBox.Size = new System.Drawing.Size(170, 23);
            this.PermisoIdComboBox.TabIndex = 38;
            // 
            // PermisoIdLabel
            // 
            this.PermisoIdLabel.AutoSize = true;
            this.PermisoIdLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PermisoIdLabel.Location = new System.Drawing.Point(27, 148);
            this.PermisoIdLabel.Name = "PermisoIdLabel";
            this.PermisoIdLabel.Size = new System.Drawing.Size(80, 20);
            this.PermisoIdLabel.TabIndex = 37;
            this.PermisoIdLabel.Text = "Permiso ID";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(130, 50);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(307, 23);
            this.DescripcionTextBox.TabIndex = 36;
            // 
            // IdRolNumericUpDown
            // 
            this.IdRolNumericUpDown.Location = new System.Drawing.Point(130, 13);
            this.IdRolNumericUpDown.Name = "IdRolNumericUpDown";
            this.IdRolNumericUpDown.Size = new System.Drawing.Size(139, 23);
            this.IdRolNumericUpDown.TabIndex = 34;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescripcionLabel.Location = new System.Drawing.Point(20, 53);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(87, 20);
            this.DescripcionLabel.TabIndex = 33;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // IdRolLabel
            // 
            this.IdRolLabel.AutoSize = true;
            this.IdRolLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdRolLabel.Location = new System.Drawing.Point(20, 14);
            this.IdRolLabel.Name = "IdRolLabel";
            this.IdRolLabel.Size = new System.Drawing.Size(48, 20);
            this.IdRolLabel.TabIndex = 31;
            this.IdRolLabel.Text = "Id Rol";
            // 
            // EsAsignadoCheckBox
            // 
            this.EsAsignadoCheckBox.AutoSize = true;
            this.EsAsignadoCheckBox.Location = new System.Drawing.Point(347, 150);
            this.EsAsignadoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EsAsignadoCheckBox.Name = "EsAsignadoCheckBox";
            this.EsAsignadoCheckBox.Size = new System.Drawing.Size(90, 19);
            this.EsAsignadoCheckBox.TabIndex = 39;
            this.EsAsignadoCheckBox.Text = "Es Asignado";
            this.EsAsignadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(289, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(67, 25);
            this.BuscarButton.TabIndex = 40;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(20, 425);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 60);
            this.NuevoButton.TabIndex = 41;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(130, 425);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 60);
            this.GuardarButton.TabIndex = 42;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(244, 425);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 60);
            this.EliminarButton.TabIndex = 43;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(20, 376);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 30);
            this.AgregarButton.TabIndex = 44;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(130, 376);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(75, 30);
            this.RemoverButton.TabIndex = 45;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // RolesDataGridView
            // 
            this.RolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesDataGridView.Location = new System.Drawing.Point(20, 190);
            this.RolesDataGridView.Name = "RolesDataGridView";
            this.RolesDataGridView.RowTemplate.Height = 25;
            this.RolesDataGridView.Size = new System.Drawing.Size(417, 170);
            this.RolesDataGridView.TabIndex = 46;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Checked = true;
            this.ActivoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActivoCheckBox.Location = new System.Drawing.Point(377, 15);
            this.ActivoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.ActivoCheckBox.TabIndex = 47;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegistroRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 502);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.RolesDataGridView);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EsAsignadoCheckBox);
            this.Controls.Add(this.PermisoIdComboBox);
            this.Controls.Add(this.PermisoIdLabel);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.IdRolNumericUpDown);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.IdRolLabel);
            this.Name = "RegistroRoles";
            this.Text = "RegistroRoles";
            this.Load += new System.EventHandler(this.RegistroRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdRolNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PermisoIdComboBox;
        private System.Windows.Forms.Label PermisoIdLabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown IdRolNumericUpDown;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label IdRolLabel;
        private System.Windows.Forms.CheckBox EsAsignadoCheckBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView RolesDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
    }
}