namespace cancha
{
    partial class Form2
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
            LblModCliente = new Label();
            BtnModificarCliente = new Button();
            BtnAgregarCliente = new Button();
            LblTituloCliente = new Label();
            LblApellidoCliente = new Label();
            LblNombreCliente = new Label();
            TxtApellidoCliente = new TextBox();
            TxtNombreCliente = new TextBox();
            LblNumTel = new Label();
            TxtNumTel = new TextBox();
            SuspendLayout();
            // 
            // LblModCliente
            // 
            LblModCliente.AutoSize = true;
            LblModCliente.Location = new Point(358, 35);
            LblModCliente.Name = "LblModCliente";
            LblModCliente.Size = new Size(98, 15);
            LblModCliente.TabIndex = 22;
            LblModCliente.Text = "Modificar Cliente";
            // 
            // BtnModificarCliente
            // 
            BtnModificarCliente.Location = new Point(398, 237);
            BtnModificarCliente.Name = "BtnModificarCliente";
            BtnModificarCliente.Size = new Size(144, 43);
            BtnModificarCliente.TabIndex = 21;
            BtnModificarCliente.Text = "Modificar Cliente";
            BtnModificarCliente.UseVisualStyleBackColor = true;
            BtnModificarCliente.Visible = false;
            // 
            // BtnAgregarCliente
            // 
            BtnAgregarCliente.Location = new Point(212, 237);
            BtnAgregarCliente.Name = "BtnAgregarCliente";
            BtnAgregarCliente.Size = new Size(144, 43);
            BtnAgregarCliente.TabIndex = 20;
            BtnAgregarCliente.Text = "Agregar Cliente";
            BtnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // LblTituloCliente
            // 
            LblTituloCliente.AutoSize = true;
            LblTituloCliente.Location = new Point(358, 50);
            LblTituloCliente.Name = "LblTituloCliente";
            LblTituloCliente.Size = new Size(89, 15);
            LblTituloCliente.TabIndex = 19;
            LblTituloCliente.Text = "Agregar Cliente";
            // 
            // LblApellidoCliente
            // 
            LblApellidoCliente.AutoSize = true;
            LblApellidoCliente.Location = new Point(325, 82);
            LblApellidoCliente.Name = "LblApellidoCliente";
            LblApellidoCliente.Size = new Size(54, 15);
            LblApellidoCliente.TabIndex = 18;
            LblApellidoCliente.Text = "Apellido:";
            // 
            // LblNombreCliente
            // 
            LblNombreCliente.AutoSize = true;
            LblNombreCliente.Location = new Point(104, 82);
            LblNombreCliente.Name = "LblNombreCliente";
            LblNombreCliente.Size = new Size(54, 15);
            LblNombreCliente.TabIndex = 17;
            LblNombreCliente.Text = "Nombre:";
            // 
            // TxtApellidoCliente
            // 
            TxtApellidoCliente.Location = new Point(295, 109);
            TxtApellidoCliente.Name = "TxtApellidoCliente";
            TxtApellidoCliente.Size = new Size(125, 23);
            TxtApellidoCliente.TabIndex = 16;
            // 
            // TxtNombreCliente
            // 
            TxtNombreCliente.Location = new Point(73, 109);
            TxtNombreCliente.Name = "TxtNombreCliente";
            TxtNombreCliente.Size = new Size(123, 23);
            TxtNombreCliente.TabIndex = 15;
            // 
            // LblNumTel
            // 
            LblNumTel.AutoSize = true;
            LblNumTel.Location = new Point(495, 82);
            LblNumTel.Name = "LblNumTel";
            LblNumTel.Size = new Size(119, 15);
            LblNumTel.TabIndex = 24;
            LblNumTel.Text = "Numero de Telefono:";
            // 
            // TxtNumTel
            // 
            TxtNumTel.Location = new Point(467, 109);
            TxtNumTel.Name = "TxtNumTel";
            TxtNumTel.Size = new Size(167, 23);
            TxtNumTel.TabIndex = 23;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblNumTel);
            Controls.Add(TxtNumTel);
            Controls.Add(LblModCliente);
            Controls.Add(BtnModificarCliente);
            Controls.Add(BtnAgregarCliente);
            Controls.Add(LblTituloCliente);
            Controls.Add(LblApellidoCliente);
            Controls.Add(LblNombreCliente);
            Controls.Add(TxtApellidoCliente);
            Controls.Add(TxtNombreCliente);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblModCliente;
        private Button BtnModificarCliente;
        private Button BtnAgregarCliente;
        private Label LblTituloCliente;
        private Label LblApellidoCliente;
        private Label LblNombreCliente;
        private TextBox TxtApellidoCliente;
        private TextBox TxtNombreCliente;
        private Label LblNumTel;
        private TextBox TxtNumTel;
    }
}