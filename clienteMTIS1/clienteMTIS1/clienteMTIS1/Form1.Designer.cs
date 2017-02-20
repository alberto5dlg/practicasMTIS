namespace clienteMTIS1
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
            this.textDNI = new System.Windows.Forms.TextBox();
            this.ComprobarDNI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComprobacionDNI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textIBAN = new System.Windows.Forms.TextBox();
            this.comprobacionIBAN = new System.Windows.Forms.Label();
            this.textCP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resProvincia = new System.Windows.Forms.TextBox();
            this.resLocalidad = new System.Windows.Forms.TextBox();
            this.resCP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cantProdText = new System.Windows.Forms.TextBox();
            this.refProdText = new System.Windows.Forms.TextBox();
            this.idClienteText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.idPresupuestoText = new System.Windows.Forms.TextBox();
            this.compPresupuesto = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.idProveedorText = new System.Windows.Forms.TextBox();
            this.refPiezaText = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.FechaDispText = new System.Windows.Forms.TextBox();
            this.DispText = new System.Windows.Forms.TextBox();
            this.prePiezaText = new System.Windows.Forms.TextBox();
            this.buttonDNI = new System.Windows.Forms.Button();
            this.buttonIBAN = new System.Windows.Forms.Button();
            this.buttonCP = new System.Windows.Forms.Button();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonSol = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.SoapKeyText = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(131, 77);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(100, 20);
            this.textDNI.TabIndex = 0;
            this.textDNI.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ComprobarDNI
            // 
            this.ComprobarDNI.AutoSize = true;
            this.ComprobarDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprobarDNI.Location = new System.Drawing.Point(12, 45);
            this.ComprobarDNI.Name = "ComprobarDNI";
            this.ComprobarDNI.Size = new System.Drawing.Size(147, 22);
            this.ComprobarDNI.TabIndex = 2;
            this.ComprobarDNI.Text = "Comprobar DNI";
            this.ComprobarDNI.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduce DNI:";
            // 
            // ComprobacionDNI
            // 
            this.ComprobacionDNI.AutoSize = true;
            this.ComprobacionDNI.ForeColor = System.Drawing.Color.Green;
            this.ComprobacionDNI.Location = new System.Drawing.Point(375, 80);
            this.ComprobacionDNI.Name = "ComprobacionDNI";
            this.ComprobacionDNI.Size = new System.Drawing.Size(74, 13);
            this.ComprobacionDNI.TabIndex = 4;
            this.ComprobacionDNI.Text = "comprobacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Comprobar IBAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Solicitar Presupuesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Generar Presupuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Comprobar Codigo Postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Introduce IBAN:";
            // 
            // textIBAN
            // 
            this.textIBAN.Location = new System.Drawing.Point(131, 160);
            this.textIBAN.Name = "textIBAN";
            this.textIBAN.Size = new System.Drawing.Size(100, 20);
            this.textIBAN.TabIndex = 10;
            // 
            // comprobacionIBAN
            // 
            this.comprobacionIBAN.AutoSize = true;
            this.comprobacionIBAN.Location = new System.Drawing.Point(375, 163);
            this.comprobacionIBAN.Name = "comprobacionIBAN";
            this.comprobacionIBAN.Size = new System.Drawing.Size(74, 13);
            this.comprobacionIBAN.TabIndex = 11;
            this.comprobacionIBAN.Text = "comprobacion";
            // 
            // textCP
            // 
            this.textCP.Location = new System.Drawing.Point(131, 243);
            this.textCP.Name = "textCP";
            this.textCP.Size = new System.Drawing.Size(100, 20);
            this.textCP.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Codigo Postal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pertenece :";
            // 
            // resProvincia
            // 
            this.resProvincia.Location = new System.Drawing.Point(131, 282);
            this.resProvincia.Name = "resProvincia";
            this.resProvincia.ReadOnly = true;
            this.resProvincia.Size = new System.Drawing.Size(100, 20);
            this.resProvincia.TabIndex = 15;
            // 
            // resLocalidad
            // 
            this.resLocalidad.Location = new System.Drawing.Point(255, 282);
            this.resLocalidad.Name = "resLocalidad";
            this.resLocalidad.ReadOnly = true;
            this.resLocalidad.Size = new System.Drawing.Size(100, 20);
            this.resLocalidad.TabIndex = 16;
            // 
            // resCP
            // 
            this.resCP.Location = new System.Drawing.Point(378, 282);
            this.resCP.Name = "resCP";
            this.resCP.ReadOnly = true;
            this.resCP.Size = new System.Drawing.Size(100, 20);
            this.resCP.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cantidad: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ref. Producto: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "ID Cliente:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Fecha Presupuesto:";
            // 
            // cantProdText
            // 
            this.cantProdText.Location = new System.Drawing.Point(131, 430);
            this.cantProdText.Name = "cantProdText";
            this.cantProdText.Size = new System.Drawing.Size(100, 20);
            this.cantProdText.TabIndex = 22;
            // 
            // refProdText
            // 
            this.refProdText.Location = new System.Drawing.Point(131, 402);
            this.refProdText.Name = "refProdText";
            this.refProdText.Size = new System.Drawing.Size(100, 20);
            this.refProdText.TabIndex = 23;
            // 
            // idClienteText
            // 
            this.idClienteText.Location = new System.Drawing.Point(131, 376);
            this.idClienteText.Name = "idClienteText";
            this.idClienteText.Size = new System.Drawing.Size(100, 20);
            this.idClienteText.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(375, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Id Presupuesto";
            // 
            // idPresupuestoText
            // 
            this.idPresupuestoText.Location = new System.Drawing.Point(474, 373);
            this.idPresupuestoText.Name = "idPresupuestoText";
            this.idPresupuestoText.ReadOnly = true;
            this.idPresupuestoText.Size = new System.Drawing.Size(100, 20);
            this.idPresupuestoText.TabIndex = 27;
            // 
            // compPresupuesto
            // 
            this.compPresupuesto.AutoSize = true;
            this.compPresupuesto.Location = new System.Drawing.Point(471, 409);
            this.compPresupuesto.Name = "compPresupuesto";
            this.compPresupuesto.Size = new System.Drawing.Size(74, 13);
            this.compPresupuesto.TabIndex = 28;
            this.compPresupuesto.Text = "comprobacion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 517);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "ID Proveedor:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 486);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Ref. Pieza: ";
            // 
            // idProveedorText
            // 
            this.idProveedorText.Location = new System.Drawing.Point(131, 514);
            this.idProveedorText.Name = "idProveedorText";
            this.idProveedorText.Size = new System.Drawing.Size(100, 20);
            this.idProveedorText.TabIndex = 31;
            // 
            // refPiezaText
            // 
            this.refPiezaText.Location = new System.Drawing.Point(131, 483);
            this.refPiezaText.Name = "refPiezaText";
            this.refPiezaText.Size = new System.Drawing.Size(100, 20);
            this.refPiezaText.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(375, 546);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Fecha Disponible: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(375, 514);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Disponible: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(375, 483);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Precio Pieza: ";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // FechaDispText
            // 
            this.FechaDispText.Location = new System.Drawing.Point(474, 543);
            this.FechaDispText.Name = "FechaDispText";
            this.FechaDispText.ReadOnly = true;
            this.FechaDispText.Size = new System.Drawing.Size(100, 20);
            this.FechaDispText.TabIndex = 36;
            // 
            // DispText
            // 
            this.DispText.Location = new System.Drawing.Point(474, 511);
            this.DispText.Name = "DispText";
            this.DispText.ReadOnly = true;
            this.DispText.Size = new System.Drawing.Size(100, 20);
            this.DispText.TabIndex = 37;
            // 
            // prePiezaText
            // 
            this.prePiezaText.Location = new System.Drawing.Point(474, 480);
            this.prePiezaText.Name = "prePiezaText";
            this.prePiezaText.ReadOnly = true;
            this.prePiezaText.Size = new System.Drawing.Size(100, 20);
            this.prePiezaText.TabIndex = 38;
            // 
            // buttonDNI
            // 
            this.buttonDNI.Location = new System.Drawing.Point(255, 74);
            this.buttonDNI.Name = "buttonDNI";
            this.buttonDNI.Size = new System.Drawing.Size(75, 23);
            this.buttonDNI.TabIndex = 39;
            this.buttonDNI.Text = "Comprobar";
            this.buttonDNI.UseVisualStyleBackColor = true;
            this.buttonDNI.Click += new System.EventHandler(this.buttonDNI_Click);
            // 
            // buttonIBAN
            // 
            this.buttonIBAN.Location = new System.Drawing.Point(255, 160);
            this.buttonIBAN.Name = "buttonIBAN";
            this.buttonIBAN.Size = new System.Drawing.Size(75, 23);
            this.buttonIBAN.TabIndex = 40;
            this.buttonIBAN.Text = "Comprobar";
            this.buttonIBAN.UseVisualStyleBackColor = true;
            this.buttonIBAN.Click += new System.EventHandler(this.buttonIBAN_Click);
            // 
            // buttonCP
            // 
            this.buttonCP.Location = new System.Drawing.Point(255, 241);
            this.buttonCP.Name = "buttonCP";
            this.buttonCP.Size = new System.Drawing.Size(75, 23);
            this.buttonCP.TabIndex = 41;
            this.buttonCP.Text = "Consultar";
            this.buttonCP.UseVisualStyleBackColor = true;
            this.buttonCP.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(255, 395);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(75, 23);
            this.buttonGen.TabIndex = 42;
            this.buttonGen.Text = "Generar";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // buttonSol
            // 
            this.buttonSol.Location = new System.Drawing.Point(255, 495);
            this.buttonSol.Name = "buttonSol";
            this.buttonSol.Size = new System.Drawing.Size(75, 23);
            this.buttonSol.TabIndex = 43;
            this.buttonSol.Text = "Solicitar";
            this.buttonSol.UseVisualStyleBackColor = true;
            this.buttonSol.Click += new System.EventHandler(this.buttonSol_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(331, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "SoapKey: ";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // SoapKeyText
            // 
            this.SoapKeyText.Location = new System.Drawing.Point(429, 19);
            this.SoapKeyText.Name = "SoapKeyText";
            this.SoapKeyText.PasswordChar = '*';
            this.SoapKeyText.Size = new System.Drawing.Size(100, 20);
            this.SoapKeyText.TabIndex = 45;
            // 
            // textDate
            // 
            this.textDate.AccessibleDescription = "";
            this.textDate.Location = new System.Drawing.Point(131, 348);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(100, 20);
            this.textDate.TabIndex = 46;
            this.textDate.Text = "AAAA-MM-DD";
            this.textDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textDate_MouseClick);
            this.textDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 595);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.SoapKeyText);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.buttonSol);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.buttonCP);
            this.Controls.Add(this.buttonIBAN);
            this.Controls.Add(this.buttonDNI);
            this.Controls.Add(this.prePiezaText);
            this.Controls.Add(this.DispText);
            this.Controls.Add(this.FechaDispText);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.refPiezaText);
            this.Controls.Add(this.idProveedorText);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.compPresupuesto);
            this.Controls.Add(this.idPresupuestoText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.idClienteText);
            this.Controls.Add(this.refProdText);
            this.Controls.Add(this.cantProdText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resCP);
            this.Controls.Add(this.resLocalidad);
            this.Controls.Add(this.resProvincia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCP);
            this.Controls.Add(this.comprobacionIBAN);
            this.Controls.Add(this.textIBAN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComprobacionDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComprobarDNI);
            this.Controls.Add(this.textDNI);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label ComprobarDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ComprobacionDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textIBAN;
        private System.Windows.Forms.Label comprobacionIBAN;
        private System.Windows.Forms.TextBox textCP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox resProvincia;
        private System.Windows.Forms.TextBox resLocalidad;
        private System.Windows.Forms.TextBox resCP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cantProdText;
        private System.Windows.Forms.TextBox refProdText;
        private System.Windows.Forms.TextBox idClienteText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox idPresupuestoText;
        private System.Windows.Forms.Label compPresupuesto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox idProveedorText;
        private System.Windows.Forms.TextBox refPiezaText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox FechaDispText;
        private System.Windows.Forms.TextBox DispText;
        private System.Windows.Forms.TextBox prePiezaText;
        private System.Windows.Forms.Button buttonDNI;
        private System.Windows.Forms.Button buttonIBAN;
        private System.Windows.Forms.Button buttonCP;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Button buttonSol;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox SoapKeyText;
        private System.Windows.Forms.TextBox textDate;
    }
}

