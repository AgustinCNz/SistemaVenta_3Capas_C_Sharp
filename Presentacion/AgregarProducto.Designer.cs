namespace Presentacion
{
    partial class AgregarProducto
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
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtNombreCorto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.lblNombreCorto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtPorcentajeGanancias = new System.Windows.Forms.TextBox();
            this.PorcentajeGanancia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVolverAtras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolverAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(548, 184);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 79;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStock.Location = new System.Drawing.Point(456, 187);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(52, 21);
            this.lblStock.TabIndex = 78;
            this.lblStock.Text = "Stock";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(548, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 50);
            this.btnAgregar.TabIndex = 76;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(428, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 75;
            this.label1.Text = "Agregar Producto";
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(548, 217);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtStockMinimo.TabIndex = 72;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(548, 157);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCosto.TabIndex = 71;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(548, 97);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 70;
            // 
            // txtNombreCorto
            // 
            this.txtNombreCorto.Location = new System.Drawing.Point(548, 126);
            this.txtNombreCorto.Name = "txtNombreCorto";
            this.txtNombreCorto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCorto.TabIndex = 69;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(548, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 68;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCodigo.Location = new System.Drawing.Point(455, 64);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 21);
            this.lblCodigo.TabIndex = 67;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMinimo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStockMinimo.Location = new System.Drawing.Point(403, 217);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(116, 21);
            this.lblStockMinimo.TabIndex = 64;
            this.lblStockMinimo.Text = "Stock Minimo";
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCosto.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrecioCosto.Location = new System.Drawing.Point(411, 155);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(101, 21);
            this.lblPrecioCosto.TabIndex = 63;
            this.lblPrecioCosto.Text = "PrecioCosto";
            // 
            // lblNombreCorto
            // 
            this.lblNombreCorto.AutoSize = true;
            this.lblNombreCorto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCorto.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombreCorto.Location = new System.Drawing.Point(410, 126);
            this.lblNombreCorto.Name = "lblNombreCorto";
            this.lblNombreCorto.Size = new System.Drawing.Size(117, 21);
            this.lblNombreCorto.TabIndex = 62;
            this.lblNombreCorto.Text = "Nombre corto";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombreProducto.Location = new System.Drawing.Point(361, 94);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(175, 21);
            this.lblNombreProducto.TabIndex = 61;
            this.lblNombreProducto.Text = "Nombre del Producto";
            // 
            // txtPorcentajeGanancias
            // 
            this.txtPorcentajeGanancias.Location = new System.Drawing.Point(548, 248);
            this.txtPorcentajeGanancias.Name = "txtPorcentajeGanancias";
            this.txtPorcentajeGanancias.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentajeGanancias.TabIndex = 81;
            // 
            // PorcentajeGanancia
            // 
            this.PorcentajeGanancia.AutoSize = true;
            this.PorcentajeGanancia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PorcentajeGanancia.ForeColor = System.Drawing.SystemColors.Window;
            this.PorcentajeGanancia.Location = new System.Drawing.Point(369, 245);
            this.PorcentajeGanancia.Name = "PorcentajeGanancia";
            this.PorcentajeGanancia.Size = new System.Drawing.Size(166, 21);
            this.PorcentajeGanancia.TabIndex = 80;
            this.PorcentajeGanancia.Text = "Porcentaje ganancia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.new_5585939;
            this.pictureBox1.Location = new System.Drawing.Point(44, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.Image = global::Presentacion.Properties.Resources.left_arrow_10068022;
            this.btnVolverAtras.Location = new System.Drawing.Point(13, 13);
            this.btnVolverAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(44, 37);
            this.btnVolverAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolverAtras.TabIndex = 103;
            this.btnVolverAtras.TabStop = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(804, 411);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPorcentajeGanancias);
            this.Controls.Add(this.PorcentajeGanancia);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStockMinimo);
            this.Controls.Add(this.txtPrecioCosto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtNombreCorto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblStockMinimo);
            this.Controls.Add(this.lblPrecioCosto);
            this.Controls.Add(this.lblNombreCorto);
            this.Controls.Add(this.lblNombreProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolverAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtNombreCorto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.Label lblNombreCorto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtPorcentajeGanancias;
        private System.Windows.Forms.Label PorcentajeGanancia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnVolverAtras;
    }
}