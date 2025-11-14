namespace cancha
{
    partial class AdministradorCliente
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
            id_cliente = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            num_tel = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            LblAdClientes = new Label();
            BtnAgregarCl = new Button();
            BtnEditarCl = new Button();
            BtnEliminarCl = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvCancha).BeginInit();
            SuspendLayout();
            // 
            // DgvCancha
            // 
            DgvCancha.AllowUserToAddRows = false;
            DgvCancha.AllowUserToDeleteRows = false;
            DgvCancha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCancha.Columns.AddRange(new DataGridViewColumn[] { id_cliente, nombre, apellido, num_tel });
            DgvCancha.Location = new Point(28, 53);
            DgvCancha.MultiSelect = false;
            DgvCancha.Name = "DgvCancha";
            DgvCancha.ReadOnly = true;
            DgvCancha.RowHeadersWidth = 51;
            DgvCancha.Size = new Size(428, 317);
            DgvCancha.TabIndex = 1;
            // 
            // id_cliente
            // 
            id_cliente.HeaderText = "id";
            id_cliente.MinimumWidth = 6;
            id_cliente.Name = "id_cliente";
            id_cliente.ReadOnly = true;
            id_cliente.Visible = false;
            id_cliente.Width = 125;
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
            // num_tel
            // 
            num_tel.HeaderText = "Numero: ";
            num_tel.MinimumWidth = 6;
            num_tel.Name = "num_tel";
            num_tel.ReadOnly = true;
            num_tel.Width = 125;
            // 
            // LblAdClientes
            // 
            LblAdClientes.AutoSize = true;
            LblAdClientes.Location = new Point(367, 9);
            LblAdClientes.Name = "LblAdClientes";
            LblAdClientes.Size = new Size(181, 20);
            LblAdClientes.TabIndex = 6;
            LblAdClientes.Text = "Administrador de Clientes";
            // 
            // BtnAgregarCl
            // 
            BtnAgregarCl.Location = new Point(543, 53);
            BtnAgregarCl.Name = "BtnAgregarCl";
            BtnAgregarCl.Size = new Size(172, 72);
            BtnAgregarCl.TabIndex = 7;
            BtnAgregarCl.Text = "Agregar";
            BtnAgregarCl.UseVisualStyleBackColor = true;
            // 
            // BtnEditarCl
            // 
            BtnEditarCl.Location = new Point(543, 173);
            BtnEditarCl.Name = "BtnEditarCl";
            BtnEditarCl.Size = new Size(172, 72);
            BtnEditarCl.TabIndex = 8;
            BtnEditarCl.Text = "Editar";
            BtnEditarCl.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarCl
            // 
            BtnEliminarCl.Location = new Point(543, 298);
            BtnEliminarCl.Name = "BtnEliminarCl";
            BtnEliminarCl.Size = new Size(172, 72);
            BtnEliminarCl.TabIndex = 10;
            BtnEliminarCl.Text = "Eliminar";
            BtnEliminarCl.UseVisualStyleBackColor = true;
            // 
            // AdministradorCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEliminarCl);
            Controls.Add(BtnEditarCl);
            Controls.Add(BtnAgregarCl);
            Controls.Add(LblAdClientes);
            Controls.Add(DgvCancha);
            Name = "AdministradorCliente";
            Text = "AdministradorCliente";
            ((System.ComponentModel.ISupportInitialize)DgvCancha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvCancha;
        private DataGridViewTextBoxColumn id_cliente;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn num_tel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label LblAdClientes;
        private Button BtnAgregarCl;
        private Button BtnEditarCl;
        private Button BtnEliminarCl;
    }
}