﻿namespace FormEntityFramework.Forms.ABMProductos
{
    partial class ViewABMProductos
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
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtId = new TextBox();
            btnBuscarId = new Button();
            btnList = new Button();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(10, 311);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 50);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(10, 388);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(111, 50);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(10, 233);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 50);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(146, 158);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 10;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new Point(10, 133);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(111, 77);
            btnBuscarId.TabIndex = 9;
            btnBuscarId.Text = "Buscar por ID";
            btnBuscarId.UseVisualStyleBackColor = true;
            btnBuscarId.Click += btnBuscarId_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(10, 24);
            btnList.Name = "btnList";
            btnList.Size = new Size(111, 60);
            btnList.TabIndex = 8;
            btnList.Text = "Cargar Lista";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeight = 29;
            dgvDatos.Location = new Point(318, 24);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(583, 414);
            dgvDatos.TabIndex = 14;
            dgvDatos.SelectionChanged += dgvDatos_SelectionChanged;
            // 
            // ViewABMProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 450);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(txtId);
            Controls.Add(btnBuscarId);
            Controls.Add(btnList);
            Controls.Add(dgvDatos);
            Name = "ViewABMProductos";
            Text = "ViewABMProductos";
            Load += ViewABMProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtId;
        private Button btnBuscarId;
        private Button btnList;
        private DataGridView dgvDatos;
    }
}