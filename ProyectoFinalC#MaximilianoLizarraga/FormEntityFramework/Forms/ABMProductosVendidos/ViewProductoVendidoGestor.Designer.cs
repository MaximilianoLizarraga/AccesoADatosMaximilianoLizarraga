namespace FormEntityFramework.Forms.ABMProductosVendidos
{
    partial class ViewProductoVendidoGestor
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
            txtIdProducto = new TextBox();
            btnCancelar = new Button();
            txtStock = new TextBox();
            btnAgregar = new Button();
            label2 = new Label();
            btnModificar = new Button();
            label1 = new Label();
            label4 = new Label();
            txtIdVenta = new TextBox();
            SuspendLayout();
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(54, 134);
            txtIdProducto.Margin = new Padding(3, 2, 3, 2);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(175, 23);
            txtIdProducto.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(218, 292);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(54, 87);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(175, 23);
            txtStock.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 292);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 116);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 43;
            label2.Text = "Id Producto";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(116, 292);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 70);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 41;
            label1.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 165);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 48;
            label4.Text = "Id Venta";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(54, 182);
            txtIdVenta.Margin = new Padding(3, 2, 3, 2);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(175, 23);
            txtIdVenta.TabIndex = 3;
            // 
            // ViewProductoVendidoGestor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 338);
            Controls.Add(txtIdVenta);
            Controls.Add(label4);
            Controls.Add(txtIdProducto);
            Controls.Add(btnCancelar);
            Controls.Add(txtStock);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(btnModificar);
            Controls.Add(label1);
            Name = "ViewProductoVendidoGestor";
            Text = "Gestor Producto Vendido";
            Load += ViewProductoVendidoGestor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProducto;
        private Button btnCancelar;
        private TextBox txtStock;
        private Button btnAgregar;
        private Label label2;
        private Button btnModificar;
        private Label label1;
        private Label label4;
        private TextBox txtIdVenta;
    }
}