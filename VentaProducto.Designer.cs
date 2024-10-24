namespace Presentacion
{
    partial class VentaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaProducto));
            this.label6 = new System.Windows.Forms.Label();
            this.listFacturaVenta = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnVolverAtras = new System.Windows.Forms.PictureBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolverAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(267, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 46);
            this.label6.TabIndex = 115;
            this.label6.Text = "Venta Producto";
            // 
            // listFacturaVenta
            // 
            this.listFacturaVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFacturaVenta.FormattingEnabled = true;
            this.listFacturaVenta.ItemHeight = 28;
            this.listFacturaVenta.Location = new System.Drawing.Point(25, 379);
            this.listFacturaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.listFacturaVenta.Name = "listFacturaVenta";
            this.listFacturaVenta.Size = new System.Drawing.Size(719, 200);
            this.listFacturaVenta.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(308, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 46);
            this.label5.TabIndex = 112;
            this.label5.Text = "Factura";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(965, 237);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(294, 34);
            this.txtCantidad.TabIndex = 111;
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(965, 195);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(294, 34);
            this.txtProducto.TabIndex = 110;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(965, 139);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(294, 34);
            this.txtDescuento.TabIndex = 109;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(965, 97);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(294, 34);
            this.txtCliente.TabIndex = 108;
            this.txtCliente.Leave += new System.EventHandler(this.txtClienteLeave);
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenta.Location = new System.Drawing.Point(25, 94);
            this.dataGridViewVenta.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.RowHeadersWidth = 51;
            this.dataGridViewVenta.Size = new System.Drawing.Size(719, 231);
            this.dataGridViewVenta.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(826, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 106;
            this.label4.Text = "Cantidad";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.lblProducto.Location = new System.Drawing.Point(824, 198);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(98, 28);
            this.lblProducto.TabIndex = 105;
            this.lblProducto.Text = "Producto";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDescuento.Location = new System.Drawing.Point(824, 138);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(112, 28);
            this.lblDescuento.TabIndex = 104;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCliente.Location = new System.Drawing.Point(824, 100);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(78, 28);
            this.lblCliente.TabIndex = 103;
            this.lblCliente.Text = "Cliente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(775, 22);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(484, 38);
            this.dateTimePicker1.TabIndex = 102;
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.BackColor = System.Drawing.Color.GhostWhite;
            this.btnVolverAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverAtras.ErrorImage = global::Presentacion.Properties.Resources.flecha_izquierda;
            this.btnVolverAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverAtras.Image")));
            this.btnVolverAtras.InitialImage = global::Presentacion.Properties.Resources.flecha_izquierda;
            this.btnVolverAtras.Location = new System.Drawing.Point(25, 17);
            this.btnVolverAtras.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(121, 38);
            this.btnVolverAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolverAtras.TabIndex = 101;
            this.btnVolverAtras.TabStop = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalizar.Location = new System.Drawing.Point(831, 449);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(198, 53);
            this.btnFinalizar.TabIndex = 116;
            this.btnFinalizar.Text = "Finalizar Venta\r\n";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(1076, 449);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 53);
            this.btnEliminar.TabIndex = 117;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAñadir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAñadir.Location = new System.Drawing.Point(831, 307);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(428, 52);
            this.btnAñadir.TabIndex = 118;
            this.btnAñadir.Text = "AÑADIR";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // VentaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1337, 608);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listFacturaVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dataGridViewVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnVolverAtras);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentaProducto";
            this.Text = "VentaProducto";
            this.Load += new System.EventHandler(this.VentaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolverAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listFacturaVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dataGridViewVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox btnVolverAtras;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAñadir;
    }
}