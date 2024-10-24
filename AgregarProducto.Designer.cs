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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(798, 302);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(185, 22);
            this.txtStock.TabIndex = 79;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStock.Location = new System.Drawing.Point(713, 300);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(56, 24);
            this.lblStock.TabIndex = 78;
            this.lblStock.Text = "Stock";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Image = global::Presentacion.Properties.Resources.flecha_izquierda;
            this.btnVolver.Location = new System.Drawing.Point(34, 10);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(111, 49);
            this.btnVolver.TabIndex = 77;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(798, 489);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(185, 50);
            this.btnAgregar.TabIndex = 76;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(700, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 39);
            this.label1.TabIndex = 75;
            this.label1.Text = "Agregar Producto";
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(798, 358);
            this.txtStockMinimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(185, 22);
            this.txtStockMinimo.TabIndex = 72;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(798, 253);
            this.txtPrecioCosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(185, 22);
            this.txtPrecioCosto.TabIndex = 71;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(798, 150);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(185, 22);
            this.txtNombreProducto.TabIndex = 70;
            // 
            // txtNombreCorto
            // 
            this.txtNombreCorto.Location = new System.Drawing.Point(798, 200);
            this.txtNombreCorto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCorto.Name = "txtNombreCorto";
            this.txtNombreCorto.Size = new System.Drawing.Size(185, 22);
            this.txtNombreCorto.TabIndex = 69;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(798, 90);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(185, 22);
            this.txtCodigo.TabIndex = 68;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigo.Location = new System.Drawing.Point(702, 88);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 24);
            this.lblCodigo.TabIndex = 67;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMinimo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStockMinimo.Location = new System.Drawing.Point(650, 356);
            this.lblStockMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(123, 24);
            this.lblStockMinimo.TabIndex = 64;
            this.lblStockMinimo.Text = "Stock Minimo";
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCosto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioCosto.Location = new System.Drawing.Point(657, 250);
            this.lblPrecioCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(112, 24);
            this.lblPrecioCosto.TabIndex = 63;
            this.lblPrecioCosto.Text = "PrecioCosto";
            // 
            // lblNombreCorto
            // 
            this.lblNombreCorto.AutoSize = true;
            this.lblNombreCorto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCorto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreCorto.Location = new System.Drawing.Point(647, 200);
            this.lblNombreCorto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCorto.Name = "lblNombreCorto";
            this.lblNombreCorto.Size = new System.Drawing.Size(126, 24);
            this.lblNombreCorto.TabIndex = 62;
            this.lblNombreCorto.Text = "Nombre corto";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreProducto.Location = new System.Drawing.Point(582, 147);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(191, 24);
            this.lblNombreProducto.TabIndex = 61;
            this.lblNombreProducto.Text = "Nombre del Producto";
            // 
            // txtPorcentajeGanancias
            // 
            this.txtPorcentajeGanancias.Location = new System.Drawing.Point(798, 407);
            this.txtPorcentajeGanancias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPorcentajeGanancias.Name = "txtPorcentajeGanancias";
            this.txtPorcentajeGanancias.Size = new System.Drawing.Size(185, 22);
            this.txtPorcentajeGanancias.TabIndex = 81;
            // 
            // PorcentajeGanancia
            // 
            this.PorcentajeGanancia.AutoSize = true;
            this.PorcentajeGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PorcentajeGanancia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PorcentajeGanancia.Location = new System.Drawing.Point(591, 404);
            this.PorcentajeGanancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PorcentajeGanancia.Name = "PorcentajeGanancia";
            this.PorcentajeGanancia.Size = new System.Drawing.Size(182, 24);
            this.PorcentajeGanancia.TabIndex = 80;
            this.PorcentajeGanancia.Text = "Porcentaje ganancia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1081, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPorcentajeGanancias);
            this.Controls.Add(this.PorcentajeGanancia);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnVolver);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnVolver;
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
    }
}