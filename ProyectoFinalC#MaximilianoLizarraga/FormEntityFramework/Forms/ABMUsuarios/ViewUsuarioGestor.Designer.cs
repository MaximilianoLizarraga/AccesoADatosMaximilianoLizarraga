namespace FormEntityFramework.Forms
{
    partial class ViewUsuarioGestor
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
            btnModificar = new Button();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            txtApellido = new TextBox();
            txtPassword = new TextBox();
            txtNombreUsuario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 76);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(112, 296);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(10, 296);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 46);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(214, 296);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(35, 93);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(175, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(35, 188);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(175, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(35, 142);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(175, 23);
            txtNombreUsuario.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 171);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 10;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 124);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 9;
            label4.Text = "Nombre de Usuario";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 234);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 23);
            txtEmail.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 217);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 13;
            label5.Text = "Email";
            // 
            // ViewUsuarioGestor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 338);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(btnCancelar);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(btnModificar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewUsuarioGestor";
            Text = "Gestor de Usuario";
            Load += ViewUsuarioEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtNombre;
        private Button btnCancelar;
        private TextBox txtApellido;
        private TextBox txtPassword;
        private TextBox txtNombreUsuario;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
    }
}