namespace cancha
{
    partial class AdministrarEmpleado
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
            DgvCancha = new DataGridView();
            id_empleado = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            cargo = new DataGridViewTextBoxColumn();
            sueldo = new DataGridViewTextBoxColumn();
            BtnEditarEm = new Button();
            LblAdEmpleados = new Label();
            BtnAgregarEm = new Button();
            BtnEliminaEm = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvCancha).BeginInit();
            SuspendLayout();
            // 
            // DgvCancha
            // 
            DgvCancha.AllowUserToAddRows = false;
            DgvCancha.AllowUserToDeleteRows = false;
            DgvCancha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCancha.Columns.AddRange(new DataGridViewColumn[] { id_empleado, nombre, apellido, cargo, sueldo });
            DgvCancha.Location = new Point(12, 57);
            DgvCancha.MultiSelect = false;
            DgvCancha.Name = "DgvCancha";
            DgvCancha.ReadOnly = true;
            DgvCancha.RowHeadersWidth = 51;
            DgvCancha.Size = new Size(553, 317);
            DgvCancha.TabIndex = 2;
            // 
            // id_empleado
            // 
            id_empleado.HeaderText = "id";
            id_empleado.MinimumWidth = 6;
            id_empleado.Name = "id_empleado";
            id_empleado.ReadOnly = true;
            id_empleado.Visible = false;
            id_empleado.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre: ";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 125;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido: ";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Width = 125;
            // 
            // cargo
            // 
            cargo.HeaderText = "cargo: ";
            cargo.MinimumWidth = 6;
            cargo.Name = "cargo";
            cargo.ReadOnly = true;
            cargo.Width = 125;
            // 
            // sueldo
            // 
            sueldo.HeaderText = "sueldo: ";
            sueldo.MinimumWidth = 6;
            sueldo.Name = "sueldo";
            sueldo.ReadOnly = true;
            sueldo.Width = 125;
            // 
            // BtnEditarEm
            // 
            BtnEditarEm.Location = new Point(616, 181);
            BtnEditarEm.Name = "BtnEditarEm";
            BtnEditarEm.Size = new Size(172, 72);
            BtnEditarEm.TabIndex = 4;
            BtnEditarEm.Text = "Editar";
            BtnEditarEm.UseVisualStyleBackColor = true;
            // 
            // LblAdEmpleados
            // 
            LblAdEmpleados.AutoSize = true;
            LblAdEmpleados.Location = new Point(290, 9);
            LblAdEmpleados.Name = "LblAdEmpleados";
            LblAdEmpleados.Size = new Size(203, 20);
            LblAdEmpleados.TabIndex = 7;
            LblAdEmpleados.Text = "Administrador de Empleados";
            // 
            // BtnAgregarEm
            // 
            BtnAgregarEm.Location = new Point(616, 57);
            BtnAgregarEm.Name = "BtnAgregarEm";
            BtnAgregarEm.Size = new Size(172, 72);
            BtnAgregarEm.TabIndex = 8;
            BtnAgregarEm.Text = "Agregar";
            BtnAgregarEm.UseVisualStyleBackColor = true;
            // 
            // BtnEliminaEm
            // 
            BtnEliminaEm.Location = new Point(616, 302);
            BtnEliminaEm.Name = "BtnEliminaEm";
            BtnEliminaEm.Size = new Size(172, 72);
            BtnEliminaEm.TabIndex = 9;
            BtnEliminaEm.Text = "Eliminar";
            BtnEliminaEm.UseVisualStyleBackColor = true;
            // 
            // AdministrarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEliminaEm);
            Controls.Add(BtnAgregarEm);
            Controls.Add(LblAdEmpleados);
            Controls.Add(BtnEditarEm);
            Controls.Add(DgvCancha);
            Name = "AdministrarEmpleado";
            Text = "AdministrarEmpleado";
            ((System.ComponentModel.ISupportInitialize)DgvCancha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvCancha;
        private DataGridViewTextBoxColumn id_empleado;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn cargo;
        private DataGridViewTextBoxColumn sueldo;
        private Button BtnEditarEm;
        private Label LblAdEmpleados;
        private Button BtnAgregarEm;
        private Button BtnEliminaEm;
    }
}