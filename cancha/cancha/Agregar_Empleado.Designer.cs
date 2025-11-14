namespace cancha
{
    partial class Agregar_Empleado
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
            LblCargoEmpleado = new Label();
            TxtNumTel = new TextBox();
            LblModEmpleado = new Label();
            BtnModificarEmpleado = new Button();
            BtnAgregarEmplado = new Button();
            LblTituloEmpleado = new Label();
            LblApellidoEmpleado = new Label();
            LblNombreEmpleado = new Label();
            TxtApellidoCliente = new TextBox();
            TxtNombreCliente = new TextBox();
            LblSueldo = new Label();
            TxtSueldo = new TextBox();
            SuspendLayout();
            // 
            // LblCargoEmpleado
            // 
            LblCargoEmpleado.AutoSize = true;
            LblCargoEmpleado.Location = new Point(490, 75);
            LblCargoEmpleado.Name = "LblCargoEmpleado";
            LblCargoEmpleado.Size = new Size(42, 15);
            LblCargoEmpleado.TabIndex = 34;
            LblCargoEmpleado.Text = "Cargo:";
            // 
            // TxtNumTel
            // 
            TxtNumTel.Location = new Point(462, 102);
            TxtNumTel.Name = "TxtNumTel";
            TxtNumTel.Size = new Size(167, 23);
            TxtNumTel.TabIndex = 33;
            // 
            // LblModEmpleado
            // 
            LblModEmpleado.AutoSize = true;
            LblModEmpleado.Location = new Point(312, 20);
            LblModEmpleado.Name = "LblModEmpleado";
            LblModEmpleado.Size = new Size(114, 15);
            LblModEmpleado.TabIndex = 32;
            LblModEmpleado.Text = "Modificar Empleado";
            // 
            // BtnModificarEmpleado
            // 
            BtnModificarEmpleado.Location = new Point(388, 226);
            BtnModificarEmpleado.Name = "BtnModificarEmpleado";
            BtnModificarEmpleado.Size = new Size(144, 43);
            BtnModificarEmpleado.TabIndex = 31;
            BtnModificarEmpleado.Text = "Modificar Empleado";
            BtnModificarEmpleado.UseVisualStyleBackColor = true;
            BtnModificarEmpleado.Visible = false;
            // 
            // BtnAgregarEmplado
            // 
            BtnAgregarEmplado.Location = new Point(202, 226);
            BtnAgregarEmplado.Name = "BtnAgregarEmplado";
            BtnAgregarEmplado.Size = new Size(144, 43);
            BtnAgregarEmplado.TabIndex = 30;
            BtnAgregarEmplado.Text = "Agregar Empleado";
            BtnAgregarEmplado.UseVisualStyleBackColor = true;
            // 
            // LblTituloEmpleado
            // 
            LblTituloEmpleado.AutoSize = true;
            LblTituloEmpleado.Location = new Point(314, 35);
            LblTituloEmpleado.Name = "LblTituloEmpleado";
            LblTituloEmpleado.Size = new Size(105, 15);
            LblTituloEmpleado.TabIndex = 29;
            LblTituloEmpleado.Text = "Agregar Empleado";
            LblTituloEmpleado.Click += LblTituloCliente_Click;
            // 
            // LblApellidoEmpleado
            // 
            LblApellidoEmpleado.AutoSize = true;
            LblApellidoEmpleado.Location = new Point(331, 75);
            LblApellidoEmpleado.Name = "LblApellidoEmpleado";
            LblApellidoEmpleado.Size = new Size(54, 15);
            LblApellidoEmpleado.TabIndex = 28;
            LblApellidoEmpleado.Text = "Apellido:";
            // 
            // LblNombreEmpleado
            // 
            LblNombreEmpleado.AutoSize = true;
            LblNombreEmpleado.Location = new Point(150, 75);
            LblNombreEmpleado.Name = "LblNombreEmpleado";
            LblNombreEmpleado.Size = new Size(54, 15);
            LblNombreEmpleado.TabIndex = 27;
            LblNombreEmpleado.Text = "Nombre:";
            // 
            // TxtApellidoCliente
            // 
            TxtApellidoCliente.Location = new Point(301, 102);
            TxtApellidoCliente.Name = "TxtApellidoCliente";
            TxtApellidoCliente.Size = new Size(125, 23);
            TxtApellidoCliente.TabIndex = 26;
            // 
            // TxtNombreCliente
            // 
            TxtNombreCliente.Location = new Point(119, 102);
            TxtNombreCliente.Name = "TxtNombreCliente";
            TxtNombreCliente.Size = new Size(123, 23);
            TxtNombreCliente.TabIndex = 25;
            // 
            // LblSueldo
            // 
            LblSueldo.AutoSize = true;
            LblSueldo.Location = new Point(332, 148);
            LblSueldo.Name = "LblSueldo";
            LblSueldo.Size = new Size(46, 15);
            LblSueldo.TabIndex = 36;
            LblSueldo.Text = "Sueldo:";
            // 
            // TxtSueldo
            // 
            TxtSueldo.Location = new Point(281, 175);
            TxtSueldo.Name = "TxtSueldo";
            TxtSueldo.Size = new Size(167, 23);
            TxtSueldo.TabIndex = 35;
            // 
            // Agregar_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblSueldo);
            Controls.Add(TxtSueldo);
            Controls.Add(LblCargoEmpleado);
            Controls.Add(TxtNumTel);
            Controls.Add(LblModEmpleado);
            Controls.Add(BtnModificarEmpleado);
            Controls.Add(BtnAgregarEmplado);
            Controls.Add(LblTituloEmpleado);
            Controls.Add(LblApellidoEmpleado);
            Controls.Add(LblNombreEmpleado);
            Controls.Add(TxtApellidoCliente);
            Controls.Add(TxtNombreCliente);
            Name = "Agregar_Empleado";
            Text = "Agregar_Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCargoEmpleado;
        private TextBox TxtNumTel;
        private Label LblModEmpleado;
        private Button BtnModificarEmpleado;
        private Button BtnAgregarEmplado;
        private Label LblTituloEmpleado;
        private Label LblApellidoEmpleado;
        private Label LblNombreEmpleado;
        private TextBox TxtApellidoCliente;
        private TextBox TxtNombreCliente;
        private Label LblSueldo;
        private TextBox TxtSueldo;
    }
}