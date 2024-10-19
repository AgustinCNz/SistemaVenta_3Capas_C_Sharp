namespace Presentacion
{
    partial class MenuUsuario
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(250, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 29);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMovimientos.Location = new System.Drawing.Point(17, 179);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(240, 45);
            this.btnMovimientos.TabIndex = 10;
            this.btnMovimientos.Text = "Movimientos y Productos";
            this.btnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimientos.UseVisualStyleBackColor = false;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompra.Location = new System.Drawing.Point(17, 59);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(240, 45);
            this.btnCompra.TabIndex = 9;
            this.btnCompra.Text = "Compra De Producto";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVenta.Location = new System.Drawing.Point(17, 119);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(240, 45);
            this.btnVenta.TabIndex = 8;
            this.btnVenta.Text = "Venta De Producto";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.UseVisualStyleBackColor = false;
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdministrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdministrar.Location = new System.Drawing.Point(12, 241);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(245, 45);
            this.btnAdministrar.TabIndex = 7;
            this.btnAdministrar.Text = "Administrar Empleados";
            this.btnAdministrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrar.UseVisualStyleBackColor = false;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "label";
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 318);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMovimientos);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnAdministrar);
            this.Controls.Add(this.label1);
            this.Name = "MenuUsuario";
            this.Text = "MenuUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Label label1;
    }
}