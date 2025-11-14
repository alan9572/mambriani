namespace cancha
{
    partial class AdministrarCanchas
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
            id_cancha = new DataGridViewTextBoxColumn();
            nom_cancha = new DataGridViewTextBoxColumn();
            deporte = new DataGridViewTextBoxColumn();
            LblAdCanchas = new Label();
            BtnAgregarCa = new Button();
            BtnEditarCa = new Button();
            BtnEliminarCa = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvCancha).BeginInit();
            SuspendLayout();
            // 
            // DgvCancha
            // 
            DgvCancha.AllowUserToAddRows = false;
            DgvCancha.AllowUserToDeleteRows = false;
            DgvCancha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCancha.Columns.AddRange(new DataGridViewColumn[] { id_cancha, nom_cancha, deporte });
            DgvCancha.Location = new Point(33, 64);
            DgvCancha.MultiSelect = false;
            DgvCancha.Name = "DgvCancha";
            DgvCancha.ReadOnly = true;
            DgvCancha.RowHeadersWidth = 51;
            DgvCancha.Size = new Size(303, 317);
            DgvCancha.TabIndex = 0;
            // 
            // id_cancha
            // 
            id_cancha.HeaderText = "id";
            id_cancha.MinimumWidth = 6;
            id_cancha.Name = "id_cancha";
            id_cancha.ReadOnly = true;
            id_cancha.Visible = false;
            id_cancha.Width = 125;
            // 
            // nom_cancha
            // 
            nom_cancha.HeaderText = "Nombre: ";
            nom_cancha.MinimumWidth = 6;
            nom_cancha.Name = "nom_cancha";
            nom_cancha.ReadOnly = true;
            nom_cancha.Width = 125;
            // 
            // deporte
            // 
            deporte.HeaderText = "Deporte: ";
            deporte.MinimumWidth = 6;
            deporte.Name = "deporte";
            deporte.ReadOnly = true;
            deporte.Width = 125;
            // 
            // LblAdCanchas
            // 
            LblAdCanchas.AutoSize = true;
            LblAdCanchas.Location = new Point(324, 26);
            LblAdCanchas.Name = "LblAdCanchas";
            LblAdCanchas.Size = new Size(183, 20);
            LblAdCanchas.TabIndex = 1;
            LblAdCanchas.Text = "Administrador de Canchas";
            // 
            // BtnAgregarCa
            // 
            BtnAgregarCa.Location = new Point(471, 64);
            BtnAgregarCa.Name = "BtnAgregarCa";
            BtnAgregarCa.Size = new Size(172, 72);
            BtnAgregarCa.TabIndex = 2;
            BtnAgregarCa.Text = "Agregar";
            BtnAgregarCa.UseVisualStyleBackColor = true;
            // 
            // BtnEditarCa
            // 
            BtnEditarCa.Location = new Point(471, 189);
            BtnEditarCa.Name = "BtnEditarCa";
            BtnEditarCa.Size = new Size(172, 72);
            BtnEditarCa.TabIndex = 9;
            BtnEditarCa.Text = "Editar";
            BtnEditarCa.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarCa
            // 
            BtnEliminarCa.Location = new Point(471, 309);
            BtnEliminarCa.Name = "BtnEliminarCa";
            BtnEliminarCa.Size = new Size(172, 72);
            BtnEliminarCa.TabIndex = 10;
            BtnEliminarCa.Text = "Eliminar";
            BtnEliminarCa.UseVisualStyleBackColor = true;
            // 
            // AdministrarCanchas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEliminarCa);
            Controls.Add(BtnEditarCa);
            Controls.Add(BtnAgregarCa);
            Controls.Add(LblAdCanchas);
            Controls.Add(DgvCancha);
            Name = "AdministrarCanchas";
            Text = "AdministrarCanchas";
            ((System.ComponentModel.ISupportInitialize)DgvCancha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvCancha;
        private DataGridViewTextBoxColumn id_cancha;
        private DataGridViewTextBoxColumn nom_cancha;
        private DataGridViewTextBoxColumn deporte;
        private Label LblAdCanchas;
        private Button BtnAgregarCa;
        private Button BtnEditarCa;
        private Button BtnEliminarCa;
    }
}