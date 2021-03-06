﻿
namespace RehaciendoElDetalle.UI.Consultas
{
    partial class cUsuarios
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
            this.FiltroActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DetalleUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EsActivoGroupBox = new System.Windows.Forms.GroupBox();
            this.TodosRadioButton = new System.Windows.Forms.RadioButton();
            this.InactivosRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivosRadioButton = new System.Windows.Forms.RadioButton();
            this.FiltroFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleUsuariosDataGridView)).BeginInit();
            this.EsActivoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltroActivoCheckBox
            // 
            this.FiltroActivoCheckBox.AutoSize = true;
            this.FiltroActivoCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FiltroActivoCheckBox.Location = new System.Drawing.Point(12, 41);
            this.FiltroActivoCheckBox.Name = "FiltroActivoCheckBox";
            this.FiltroActivoCheckBox.Size = new System.Drawing.Size(155, 23);
            this.FiltroActivoCheckBox.TabIndex = 26;
            this.FiltroActivoCheckBox.Text = "Usar Filtro de Fechas";
            this.FiltroActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DesdeDateTimePicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.HastaDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(173, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 33);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(55, 4);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(99, 23);
            this.DesdeDateTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(160, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(210, 4);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(95, 23);
            this.HastaDateTimePicker.TabIndex = 4;
            // 
            // DetalleUsuariosDataGridView
            // 
            this.DetalleUsuariosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalleUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleUsuariosDataGridView.Location = new System.Drawing.Point(12, 105);
            this.DetalleUsuariosDataGridView.Name = "DetalleUsuariosDataGridView";
            this.DetalleUsuariosDataGridView.RowTemplate.Height = 25;
            this.DetalleUsuariosDataGridView.Size = new System.Drawing.Size(666, 258);
            this.DetalleUsuariosDataGridView.TabIndex = 24;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(173, 70);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(318, 23);
            this.CriterioTextBox.TabIndex = 23;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Location = new System.Drawing.Point(61, 70);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(106, 23);
            this.FiltroComboBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Filtro";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuscarButton.Image = global::RehaciendoElDetalle.Properties.Resources.lupa;
            this.BuscarButton.Location = new System.Drawing.Point(596, 13);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(82, 81);
            this.BuscarButton.TabIndex = 20;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EsActivoGroupBox
            // 
            this.EsActivoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EsActivoGroupBox.Controls.Add(this.TodosRadioButton);
            this.EsActivoGroupBox.Controls.Add(this.InactivosRadioButton);
            this.EsActivoGroupBox.Controls.Add(this.ActivosRadioButton);
            this.EsActivoGroupBox.Location = new System.Drawing.Point(501, 7);
            this.EsActivoGroupBox.Name = "EsActivoGroupBox";
            this.EsActivoGroupBox.Size = new System.Drawing.Size(89, 89);
            this.EsActivoGroupBox.TabIndex = 19;
            this.EsActivoGroupBox.TabStop = false;
            this.EsActivoGroupBox.Text = "esActivo?";
            // 
            // TodosRadioButton
            // 
            this.TodosRadioButton.AutoSize = true;
            this.TodosRadioButton.Checked = true;
            this.TodosRadioButton.Location = new System.Drawing.Point(6, 17);
            this.TodosRadioButton.Name = "TodosRadioButton";
            this.TodosRadioButton.Size = new System.Drawing.Size(56, 19);
            this.TodosRadioButton.TabIndex = 8;
            this.TodosRadioButton.TabStop = true;
            this.TodosRadioButton.Text = "Todos";
            this.TodosRadioButton.UseVisualStyleBackColor = true;
            // 
            // InactivosRadioButton
            // 
            this.InactivosRadioButton.AutoSize = true;
            this.InactivosRadioButton.Location = new System.Drawing.Point(6, 67);
            this.InactivosRadioButton.Name = "InactivosRadioButton";
            this.InactivosRadioButton.Size = new System.Drawing.Size(72, 19);
            this.InactivosRadioButton.TabIndex = 6;
            this.InactivosRadioButton.TabStop = true;
            this.InactivosRadioButton.Text = "Inactivos";
            this.InactivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // ActivosRadioButton
            // 
            this.ActivosRadioButton.AutoSize = true;
            this.ActivosRadioButton.Location = new System.Drawing.Point(6, 42);
            this.ActivosRadioButton.Name = "ActivosRadioButton";
            this.ActivosRadioButton.Size = new System.Drawing.Size(64, 19);
            this.ActivosRadioButton.TabIndex = 7;
            this.ActivosRadioButton.TabStop = true;
            this.ActivosRadioButton.Text = "Activos";
            this.ActivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // FiltroFechaCheckBox
            // 
            this.FiltroFechaCheckBox.AutoSize = true;
            this.FiltroFechaCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FiltroFechaCheckBox.Location = new System.Drawing.Point(12, 15);
            this.FiltroFechaCheckBox.Name = "FiltroFechaCheckBox";
            this.FiltroFechaCheckBox.Size = new System.Drawing.Size(155, 23);
            this.FiltroFechaCheckBox.TabIndex = 18;
            this.FiltroFechaCheckBox.Text = "Usar Filtro de Fechas";
            this.FiltroFechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Image = global::RehaciendoElDetalle.Properties.Resources.impresora;
            this.ImprimirButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImprimirButton.Location = new System.Drawing.Point(12, 369);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(70, 55);
            this.ImprimirButton.TabIndex = 27;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 427);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.FiltroActivoCheckBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DetalleUsuariosDataGridView);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EsActivoGroupBox);
            this.Controls.Add(this.FiltroFechaCheckBox);
            this.Name = "cUsuarios";
            this.Text = "Consulta Usuarios";
            this.Load += new System.EventHandler(this.cUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleUsuariosDataGridView)).EndInit();
            this.EsActivoGroupBox.ResumeLayout(false);
            this.EsActivoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FiltroActivoCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DataGridView DetalleUsuariosDataGridView;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.GroupBox EsActivoGroupBox;
        private System.Windows.Forms.RadioButton TodosRadioButton;
        private System.Windows.Forms.RadioButton InactivosRadioButton;
        private System.Windows.Forms.RadioButton ActivosRadioButton;
        private System.Windows.Forms.CheckBox FiltroFechaCheckBox;
        private System.Windows.Forms.Button ImprimirButton;
    }
}