﻿namespace FormEntityFramework.Forms.ABMVentas
{
    partial class ViewVentaGestor
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
            btnCancelar = new Button();
            txtComentario = new TextBox();
            btnAgregar = new Button();
            label2 = new Label();
            btnModificar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(50, 164);
            txtIdUsuario.Margin = new Padding(3, 2, 3, 2);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(175, 23);
            txtIdUsuario.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(218, 292);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(50, 118);
            txtComentario.Margin = new Padding(3, 2, 3, 2);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(175, 23);
            txtComentario.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 292);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 147);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 43;
            label2.Text = "ID Usuario";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(116, 292);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 100);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 41;
            label1.Text = "Comentario";
            // 
            // ViewVentaGestor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 338);
            Controls.Add(txtIdUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(txtComentario);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(btnModificar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewVentaGestor";
            Text = "Gestor Venta";
            Load += ViewVentaGestor_Load;
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
        private TextBox txtComentario;
        private Button btnAgregar;
        private Label label2;
        private Button btnModificar;
        private Label label1;
    }
}