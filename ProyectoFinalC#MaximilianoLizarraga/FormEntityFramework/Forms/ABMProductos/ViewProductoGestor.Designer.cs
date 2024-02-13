namespace FormEntityFramework.Forms.ABMProductos
{
    partial class ViewProductoGestor
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
            txtIdUsuario = new TextBox();
            label5 = new Label();
            txtStock = new TextBox();
            txtPrecioVenta = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCosto = new TextBox();
            btnCancelar = new Button();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            label2 = new Label();
            btnModificar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(39, 232);
            txtIdUsuario.Margin = new Padding(3, 2, 3, 2);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(175, 23);
            txtIdUsuario.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 214);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 39;
            label5.Text = "ID Usuario";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(39, 186);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(175, 23);
            txtStock.TabIndex = 4;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(39, 140);
            txtPrecioVenta.Margin = new Padding(3, 2, 3, 2);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(175, 23);
            txtPrecioVenta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 169);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 36;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 122);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 35;
            label4.Text = "Precio de Venta";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(39, 91);
            txtCosto.Margin = new Padding(3, 2, 3, 2);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(175, 23);
            txtCosto.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(218, 294);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(39, 44);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(175, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 294);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 74);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 30;
            label2.Text = "Costo";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(116, 294);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 27);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 28;
            label1.Text = "Descripcion";
            // 
            // ViewProductoGestor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 338);
            Controls.Add(txtIdUsuario);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtCosto);
            Controls.Add(btnCancelar);
            Controls.Add(txtDescripcion);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(btnModificar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewProductoGestor";
            Text = "Producto Gestor";
            Load += ViewProductoGestor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdUsuario;
        private Label label5;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private Label label3;
        private Label label4;
        private TextBox txtCosto;
        private Button btnCancelar;
        private TextBox txtDescripcion;
        private Button btnAgregar;
        private Label label2;
        private Button btnModificar;
        private Label label1;
    }
}