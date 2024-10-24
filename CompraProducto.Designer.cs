using System;

namespace Presentacion
{
    partial class CompraProducto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblcomprarproducto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lstCompra = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEmitirComprobante = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(778, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblcomprarproducto
            // 
            this.lblcomprarproducto.AutoSize = true;
            this.lblcomprarproducto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcomprarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomprarproducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcomprarproducto.Location = new System.Drawing.Point(303, 29);
            this.lblcomprarproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcomprarproducto.Name = "lblcomprarproducto";
            this.lblcomprarproducto.Size = new System.Drawing.Size(310, 39);
            this.lblcomprarproducto.TabIndex = 1;
            this.lblcomprarproducto.Text = "Comprar Producto";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigo.Location = new System.Drawing.Point(885, 221);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(98, 29);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantidad.Location = new System.Drawing.Point(866, 273);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(117, 29);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecio.Location = new System.Drawing.Point(894, 317);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(89, 29);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(1017, 228);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(309, 22);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigoLeave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(1017, 324);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(309, 22);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(1017, 280);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(309, 22);
            this.txtCantidad.TabIndex = 7;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnComprar.Location = new System.Drawing.Point(943, 400);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(173, 52);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lstCompra
            // 
            this.lstCompra.FormattingEnabled = true;
            this.lstCompra.ItemHeight = 16;
            this.lstCompra.Location = new System.Drawing.Point(13, 414);
            this.lstCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCompra.Name = "lstCompra";
            this.lstCompra.Size = new System.Drawing.Size(553, 228);
            this.lstCompra.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(1175, 400);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 52);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEmitirComprobante
            // 
            this.btnEmitirComprobante.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEmitirComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirComprobante.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmitirComprobante.Location = new System.Drawing.Point(574, 482);
            this.btnEmitirComprobante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmitirComprobante.Name = "btnEmitirComprobante";
            this.btnEmitirComprobante.Size = new System.Drawing.Size(217, 84);
            this.btnEmitirComprobante.TabIndex = 11;
            this.btnEmitirComprobante.Text = "Emitir Comprobante";
            this.btnEmitirComprobante.UseVisualStyleBackColor = false;
            this.btnEmitirComprobante.Click += new System.EventHandler(this.btnEmitirComprobante_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.Location = new System.Drawing.Point(871, 90);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(344, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFactura.Location = new System.Drawing.Point(883, 176);
            this.lblFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(100, 29);
            this.lblFactura.TabIndex = 13;
            this.lblFactura.Text = "Factura";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(1017, 183);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(309, 22);
            this.txtFactura.TabIndex = 14;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::Presentacion.Properties.Resources.flecha_izquierda;
            this.btnVolver.Location = new System.Drawing.Point(13, 36);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(115, 39);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // CompraProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1363, 694);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnEmitirComprobante);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstCompra);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblcomprarproducto);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CompraProducto";
            this.Text = "CompraProducto";
            this.Load += new System.EventHandler(this.CompraProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblcomprarproducto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.ListBox lstCompra;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEmitirComprobante;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Button btnVolver;
    }
}