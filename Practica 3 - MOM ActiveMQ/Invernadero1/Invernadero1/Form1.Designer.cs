namespace Invernadero1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tempBox = new System.Windows.Forms.TextBox();
            this.humBox = new System.Windows.Forms.TextBox();
            this.humidBox = new System.Windows.Forms.TextBox();
            this.ventBox = new System.Windows.Forms.TextBox();
            this.ActualizarDatos = new System.Windows.Forms.Timer(this.components);
            this.EnviarMensajes = new System.Windows.Forms.Timer(this.components);
            this.RecibirDatos = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Humedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ventilador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Humidificador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Invernadero 1";
            // 
            // tempBox
            // 
            this.tempBox.Location = new System.Drawing.Point(108, 63);
            this.tempBox.Name = "tempBox";
            this.tempBox.ReadOnly = true;
            this.tempBox.Size = new System.Drawing.Size(100, 20);
            this.tempBox.TabIndex = 5;
            // 
            // humBox
            // 
            this.humBox.Location = new System.Drawing.Point(108, 100);
            this.humBox.Name = "humBox";
            this.humBox.ReadOnly = true;
            this.humBox.Size = new System.Drawing.Size(100, 20);
            this.humBox.TabIndex = 6;
            // 
            // humidBox
            // 
            this.humidBox.ForeColor = System.Drawing.Color.Red;
            this.humidBox.Location = new System.Drawing.Point(108, 176);
            this.humidBox.Name = "humidBox";
            this.humidBox.ReadOnly = true;
            this.humidBox.Size = new System.Drawing.Size(100, 20);
            this.humidBox.TabIndex = 7;
            // 
            // ventBox
            // 
            this.ventBox.ForeColor = System.Drawing.Color.Red;
            this.ventBox.Location = new System.Drawing.Point(108, 133);
            this.ventBox.Name = "ventBox";
            this.ventBox.ReadOnly = true;
            this.ventBox.Size = new System.Drawing.Size(100, 20);
            this.ventBox.TabIndex = 8;
            // 
            // ActualizarDatos
            // 
            this.ActualizarDatos.Enabled = true;
            this.ActualizarDatos.Interval = 35000;
            this.ActualizarDatos.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // EnviarMensajes
            // 
            this.EnviarMensajes.Enabled = true;
            this.EnviarMensajes.Interval = 5000;
            this.EnviarMensajes.Tick += new System.EventHandler(this.EnviarMensajes_Tick);
            // 
            // RecibirDatos
            // 
            this.RecibirDatos.Enabled = true;
            this.RecibirDatos.Interval = 6000;
            this.RecibirDatos.Tick += new System.EventHandler(this.RecibirDatos_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 210);
            this.Controls.Add(this.ventBox);
            this.Controls.Add(this.humidBox);
            this.Controls.Add(this.humBox);
            this.Controls.Add(this.tempBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tempBox;
        private System.Windows.Forms.TextBox humBox;
        private System.Windows.Forms.TextBox humidBox;
        private System.Windows.Forms.TextBox ventBox;
        private System.Windows.Forms.Timer ActualizarDatos;
        private System.Windows.Forms.Timer EnviarMensajes;
        private System.Windows.Forms.Timer RecibirDatos;
    }
}

