namespace clienteP2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.refProd = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comprar = new System.Windows.Forms.Button();
            this.efectuado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // refProd
            // 
            this.refProd.Location = new System.Drawing.Point(12, 88);
            this.refProd.Name = "refProd";
            this.refProd.Size = new System.Drawing.Size(100, 20);
            this.refProd.TabIndex = 0;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(118, 88);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(100, 20);
            this.cantidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // comprar
            // 
            this.comprar.Location = new System.Drawing.Point(78, 129);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(75, 23);
            this.comprar.TabIndex = 4;
            this.comprar.Text = "Comprar";
            this.comprar.UseVisualStyleBackColor = true;
            this.comprar.Click += new System.EventHandler(this.comprar_Click);
            // 
            // efectuado
            // 
            this.efectuado.AutoSize = true;
            this.efectuado.Location = new System.Drawing.Point(15, 188);
            this.efectuado.Name = "efectuado";
            this.efectuado.Size = new System.Drawing.Size(49, 13);
            this.efectuado.TabIndex = 5;
            this.efectuado.Text = "Compra: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente MTIS 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 225);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.efectuado);
            this.Controls.Add(this.comprar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.refProd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox refProd;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button comprar;
        private System.Windows.Forms.Label efectuado;
        private System.Windows.Forms.Label label4;
    }
}

