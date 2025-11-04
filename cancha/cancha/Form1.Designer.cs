namespace cancha
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblTitulo = new Label();
            BtnCancha = new Button();
            BtnEmpleado = new Button();
            BtnTurno = new Button();
            BtnCliente = new Button();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Location = new Point(324, 62);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(94, 15);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Gestor de Predio";
            // 
            // BtnCancha
            // 
            BtnCancha.Location = new Point(29, 121);
            BtnCancha.Name = "BtnCancha";
            BtnCancha.Size = new Size(165, 71);
            BtnCancha.TabIndex = 1;
            BtnCancha.Text = "Administrar Canchas";
            BtnCancha.UseVisualStyleBackColor = true;
            // 
            // BtnEmpleado
            // 
            BtnEmpleado.Location = new Point(291, 121);
            BtnEmpleado.Name = "BtnEmpleado";
            BtnEmpleado.Size = new Size(165, 71);
            BtnEmpleado.TabIndex = 2;
            BtnEmpleado.Text = "Administrar Empleados";
            BtnEmpleado.UseVisualStyleBackColor = true;
            // 
            // BtnTurno
            // 
            BtnTurno.Location = new Point(549, 121);
            BtnTurno.Name = "BtnTurno";
            BtnTurno.Size = new Size(165, 71);
            BtnTurno.TabIndex = 3;
            BtnTurno.Text = "Administrar Turnos";
            BtnTurno.UseVisualStyleBackColor = true;
            // 
            // BtnCliente
            // 
            BtnCliente.Location = new Point(291, 275);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(165, 71);
            BtnCliente.TabIndex = 4;
            BtnCliente.Text = "Administrar Clientes";
            BtnCliente.UseVisualStyleBackColor = true;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCliente);
            Controls.Add(BtnTurno);
            Controls.Add(BtnEmpleado);
            Controls.Add(BtnCancha);
            Controls.Add(LblTitulo);
            Name = "FrmInicio";
            Text = "FrmInicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private Button BtnCancha;
        private Button BtnEmpleado;
        private Button BtnTurno;
        private Button BtnCliente;
    }
}
