namespace Presentacion
{
    partial class ConsultarMovimientos
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
            this.dataGridViewComprobantesEmitidos = new System.Windows.Forms.DataGridView();
            this.btnVolverAtras = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprobantesEmitidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolverAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComprobantesEmitidos
            // 
            this.dataGridViewComprobantesEmitidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComprobantesEmitidos.Location = new System.Drawing.Point(13, 119);
            this.dataGridViewComprobantesEmitidos.Name = "dataGridViewComprobantesEmitidos";
            this.dataGridViewComprobantesEmitidos.Size = new System.Drawing.Size(776, 185);
            this.dataGridViewComprobantesEmitidos.TabIndex = 0;
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.Image = global::Presentacion.Properties.Resources.left_arrow_10068022;
            this.btnVolverAtras.Location = new System.Drawing.Point(13, 9);
            this.btnVolverAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(44, 37);
            this.btnVolverAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolverAtras.TabIndex = 87;
            this.btnVolverAtras.TabStop = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Presentacion.Properties.Resources.delete_10023765;
            this.btnSalir.Location = new System.Drawing.Point(759, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(29, 24);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 100;
            this.btnSalir.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(162, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 37);
            this.label1.TabIndex = 101;
            this.label1.Text = "Movimientos de Comprobantes Emitidos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(310, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 30);
            this.label2.TabIndex = 102;
            this.label2.Text = "Compra / Venta ";
            // 
            // ConsultarMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.dataGridViewComprobantesEmitidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarMovimientos";
            this.Text = "ConsultarMovimientos";
            this.Load += new System.EventHandler(this.ConsultarMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprobantesEmitidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolverAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewComprobantesEmitidos;
        private System.Windows.Forms.PictureBox btnVolverAtras;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}