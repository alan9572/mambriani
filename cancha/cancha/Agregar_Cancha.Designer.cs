namespace cancha
{
    partial class Agregar_Cancha
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
            LblCancha = new Label();
            LblDeporte = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // LblCancha
            // 
            LblCancha.AutoSize = true;
            LblCancha.Location = new Point(92, 99);
            LblCancha.Name = "LblCancha";
            LblCancha.Size = new Size(134, 20);
            LblCancha.TabIndex = 0;
            LblCancha.Text = "agrega una cancha";
            // 
            // LblDeporte
            // 
            LblDeporte.AutoSize = true;
            LblDeporte.Location = new Point(472, 99);
            LblDeporte.Name = "LblDeporte";
            LblDeporte.Size = new Size(133, 20);
            LblDeporte.TabIndex = 1;
            LblDeporte.Text = "agrega un deporte";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(472, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 27);
            textBox2.TabIndex = 3;
            // 
            // Agregar_Cancha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LblDeporte);
            Controls.Add(LblCancha);
            Name = "Agregar_Cancha";
            Text = "Agregar_Cancha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCancha;
        private Label LblDeporte;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}