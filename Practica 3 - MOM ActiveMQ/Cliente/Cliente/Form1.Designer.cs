namespace Cliente
{
    partial class Cliente
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
            this.temp1 = new System.Windows.Forms.TextBox();
            this.hum1 = new System.Windows.Forms.TextBox();
            this.temp2 = new System.Windows.Forms.TextBox();
            this.hum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Humidificador1 = new System.Windows.Forms.TextBox();
            this.vent1 = new System.Windows.Forms.TextBox();
            this.Humidificador2 = new System.Windows.Forms.TextBox();
            this.vent2 = new System.Windows.Forms.TextBox();
            this.ListenInv1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // temp1
            // 
            this.temp1.Location = new System.Drawing.Point(97, 78);
            this.temp1.Name = "temp1";
            this.temp1.ReadOnly = true;
            this.temp1.Size = new System.Drawing.Size(70, 20);
            this.temp1.TabIndex = 0;
            // 
            // hum1
            // 
            this.hum1.Location = new System.Drawing.Point(97, 124);
            this.hum1.Name = "hum1";
            this.hum1.ReadOnly = true;
            this.hum1.Size = new System.Drawing.Size(70, 20);
            this.hum1.TabIndex = 1;
            // 
            // temp2
            // 
            this.temp2.Location = new System.Drawing.Point(188, 78);
            this.temp2.Name = "temp2";
            this.temp2.ReadOnly = true;
            this.temp2.Size = new System.Drawing.Size(70, 20);
            this.temp2.TabIndex = 2;
            // 
            // hum2
            // 
            this.hum2.Location = new System.Drawing.Point(188, 124);
            this.hum2.Name = "hum2";
            this.hum2.ReadOnly = true;
            this.hum2.Size = new System.Drawing.Size(70, 20);
            this.hum2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Humedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Invernadero 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Invernadero 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ventilador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Humidificador";
            // 
            // Humidificador1
            // 
            this.Humidificador1.Location = new System.Drawing.Point(97, 192);
            this.Humidificador1.Name = "Humidificador1";
            this.Humidificador1.ReadOnly = true;
            this.Humidificador1.Size = new System.Drawing.Size(70, 20);
            this.Humidificador1.TabIndex = 11;
            // 
            // vent1
            // 
            this.vent1.Location = new System.Drawing.Point(97, 160);
            this.vent1.Name = "vent1";
            this.vent1.ReadOnly = true;
            this.vent1.Size = new System.Drawing.Size(70, 20);
            this.vent1.TabIndex = 12;
            // 
            // Humidificador2
            // 
            this.Humidificador2.Location = new System.Drawing.Point(188, 192);
            this.Humidificador2.Name = "Humidificador2";
            this.Humidificador2.ReadOnly = true;
            this.Humidificador2.Size = new System.Drawing.Size(70, 20);
            this.Humidificador2.TabIndex = 13;
            // 
            // vent2
            // 
            this.vent2.Location = new System.Drawing.Point(188, 160);
            this.vent2.Name = "vent2";
            this.vent2.ReadOnly = true;
            this.vent2.Size = new System.Drawing.Size(70, 20);
            this.vent2.TabIndex = 14;
            // 
            // ListenInv1
            // 
            this.ListenInv1.Enabled = true;
            this.ListenInv1.Interval = 5000;
            this.ListenInv1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.vent2);
            this.Controls.Add(this.Humidificador2);
            this.Controls.Add(this.vent1);
            this.Controls.Add(this.Humidificador1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hum2);
            this.Controls.Add(this.temp2);
            this.Controls.Add(this.hum1);
            this.Controls.Add(this.temp1);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox temp1;
        private System.Windows.Forms.TextBox hum1;
        private System.Windows.Forms.TextBox temp2;
        private System.Windows.Forms.TextBox hum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Humidificador1;
        private System.Windows.Forms.TextBox vent1;
        private System.Windows.Forms.TextBox Humidificador2;
        private System.Windows.Forms.TextBox vent2;
        private System.Windows.Forms.Timer ListenInv1;
    }
}

