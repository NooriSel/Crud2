namespace Crud2
{
    partial class CervezaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            txtEstilo = new TextBox();
            txtAlcohol = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 86);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 0;
            label2.Text = "Estilo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 133);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 0;
            label3.Text = "Alcohol";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(190, 196);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(83, 24);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 196);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 24);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(152, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtEstilo
            // 
            txtEstilo.Location = new Point(152, 78);
            txtEstilo.Name = "txtEstilo";
            txtEstilo.Size = new Size(100, 23);
            txtEstilo.TabIndex = 2;
            // 
            // txtAlcohol
            // 
            txtAlcohol.Location = new Point(152, 130);
            txtAlcohol.Name = "txtAlcohol";
            txtAlcohol.Size = new Size(100, 23);
            txtAlcohol.TabIndex = 2;
            // 
            // CervezaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 257);
            Controls.Add(txtAlcohol);
            Controls.Add(txtEstilo);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CervezaForm";
            Text = "CervezaForm";
            Load += CervezaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtNombre;
        private TextBox txtEstilo;
        private TextBox txtAlcohol;
    }
}