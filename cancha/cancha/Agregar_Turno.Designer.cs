namespace cancha
{
    partial class Agregar_Turno
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
            DgvCanchaSeleccionar = new DataGridView();
            DgvSeleccionarEmpleado = new DataGridView();
            LblDiaYHora = new Label();
            ModificarTurno = new Label();
            LblTituloEmpleado = new Label();
            LblSeleccionarCancha = new Label();
            LblSeleccionarEmpleado = new Label();
            DatetDiaYHora = new DateTimePicker();
            DgvSeleccionarCliente = new DataGridView();
            LblSeleccionarCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvCanchaSeleccionar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvSeleccionarEmpleado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvSeleccionarCliente).BeginInit();
            SuspendLayout();
            // 
            // DgvCanchaSeleccionar
            // 
            DgvCanchaSeleccionar.AllowUserToAddRows = false;
            DgvCanchaSeleccionar.AllowUserToDeleteRows = false;
            DgvCanchaSeleccionar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCanchaSeleccionar.Location = new Point(598, 136);
            DgvCanchaSeleccionar.MultiSelect = false;
            DgvCanchaSeleccionar.Name = "DgvCanchaSeleccionar";
            DgvCanchaSeleccionar.ReadOnly = true;
            DgvCanchaSeleccionar.Size = new Size(204, 205);
            DgvCanchaSeleccionar.TabIndex = 0;
            // 
            // DgvSeleccionarEmpleado
            // 
            DgvSeleccionarEmpleado.AllowUserToAddRows = false;
            DgvSeleccionarEmpleado.AllowUserToDeleteRows = false;
            DgvSeleccionarEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSeleccionarEmpleado.Location = new Point(304, 183);
            DgvSeleccionarEmpleado.MultiSelect = false;
            DgvSeleccionarEmpleado.Name = "DgvSeleccionarEmpleado";
            DgvSeleccionarEmpleado.ReadOnly = true;
            DgvSeleccionarEmpleado.Size = new Size(261, 158);
            DgvSeleccionarEmpleado.TabIndex = 1;
            // 
            // LblDiaYHora
            // 
            LblDiaYHora.AutoSize = true;
            LblDiaYHora.Location = new Point(29, 63);
            LblDiaYHora.Name = "LblDiaYHora";
            LblDiaYHora.Size = new Size(124, 15);
            LblDiaYHora.TabIndex = 39;
            LblDiaYHora.Text = "Seleccione Dia y Hora:";
            // 
            // ModificarTurno
            // 
            ModificarTurno.AutoSize = true;
            ModificarTurno.Location = new Point(340, 9);
            ModificarTurno.Name = "ModificarTurno";
            ModificarTurno.Size = new Size(93, 15);
            ModificarTurno.TabIndex = 38;
            ModificarTurno.Text = "Modificar Turno";
            // 
            // LblTituloEmpleado
            // 
            LblTituloEmpleado.AutoSize = true;
            LblTituloEmpleado.Location = new Point(342, 24);
            LblTituloEmpleado.Name = "LblTituloEmpleado";
            LblTituloEmpleado.Size = new Size(84, 15);
            LblTituloEmpleado.TabIndex = 37;
            LblTituloEmpleado.Text = "Agregar Turno";
            // 
            // LblSeleccionarCancha
            // 
            LblSeleccionarCancha.AutoSize = true;
            LblSeleccionarCancha.Location = new Point(598, 118);
            LblSeleccionarCancha.Name = "LblSeleccionarCancha";
            LblSeleccionarCancha.Size = new Size(135, 15);
            LblSeleccionarCancha.TabIndex = 36;
            LblSeleccionarCancha.Text = "Selecciona una Cancha: ";
            // 
            // LblSeleccionarEmpleado
            // 
            LblSeleccionarEmpleado.AutoSize = true;
            LblSeleccionarEmpleado.Location = new Point(304, 165);
            LblSeleccionarEmpleado.Name = "LblSeleccionarEmpleado";
            LblSeleccionarEmpleado.Size = new Size(142, 15);
            LblSeleccionarEmpleado.TabIndex = 35;
            LblSeleccionarEmpleado.Text = "Selecciona un Empleado: ";
            // 
            // DatetDiaYHora
            // 
            DatetDiaYHora.Location = new Point(29, 92);
            DatetDiaYHora.Name = "DatetDiaYHora";
            DatetDiaYHora.Size = new Size(220, 23);
            DatetDiaYHora.TabIndex = 40;
            // 
            // DgvSeleccionarCliente
            // 
            DgvSeleccionarCliente.AllowUserToAddRows = false;
            DgvSeleccionarCliente.AllowUserToDeleteRows = false;
            DgvSeleccionarCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSeleccionarCliente.Location = new Point(29, 183);
            DgvSeleccionarCliente.MultiSelect = false;
            DgvSeleccionarCliente.Name = "DgvSeleccionarCliente";
            DgvSeleccionarCliente.ReadOnly = true;
            DgvSeleccionarCliente.Size = new Size(250, 158);
            DgvSeleccionarCliente.TabIndex = 41;
            // 
            // LblSeleccionarCliente
            // 
            LblSeleccionarCliente.AutoSize = true;
            LblSeleccionarCliente.Location = new Point(29, 156);
            LblSeleccionarCliente.Name = "LblSeleccionarCliente";
            LblSeleccionarCliente.Size = new Size(123, 15);
            LblSeleccionarCliente.TabIndex = 42;
            LblSeleccionarCliente.Text = "Selecciona un Cliente:";
            // 
            // Agregar_Turno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 375);
            Controls.Add(LblSeleccionarCliente);
            Controls.Add(DgvSeleccionarCliente);
            Controls.Add(DatetDiaYHora);
            Controls.Add(LblDiaYHora);
            Controls.Add(ModificarTurno);
            Controls.Add(LblTituloEmpleado);
            Controls.Add(LblSeleccionarCancha);
            Controls.Add(LblSeleccionarEmpleado);
            Controls.Add(DgvSeleccionarEmpleado);
            Controls.Add(DgvCanchaSeleccionar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Agregar_Turno";
            Text = "Agregar_Turno";
            ((System.ComponentModel.ISupportInitialize)DgvCanchaSeleccionar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvSeleccionarEmpleado).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvSeleccionarCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvCanchaSeleccionar;
        private DataGridView DgvSeleccionarEmpleado;
        private Label LblDiaYHora;
        private Label ModificarTurno;
        private Label LblTituloEmpleado;
        private Label LblSeleccionarCancha;
        private Label LblSeleccionarEmpleado;
        private DateTimePicker DatetDiaYHora;
        private DataGridView DgvSeleccionarCliente;
        private Label LblSeleccionarCliente;
    }
}