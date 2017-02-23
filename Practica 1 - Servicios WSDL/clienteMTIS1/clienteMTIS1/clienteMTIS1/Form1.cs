using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clienteMTIS1
{
    public partial class Form1 : Form
    {
        private ServiciosP1.serviciosP1 servicios;
        public Form1()
        {
            InitializeComponent();
            servicios = new ServiciosP1.serviciosP1Client();
            ComprobacionDNI.Visible = false;
            comprobacionIBAN.Visible = false;
            textDate.Text = "AAAA-MM-DD";
        }

        public bool comprobarSoapKey(String soapkey)
        {
            if (soapkey.Equals("123456"))
                return true;
            MessageBox.Show("SoapKey Incorrecto");
            return false; 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comprobarSoapKey(SoapKeyText.Text))
            {
                if (textCP.Text != "")
                {
                    ServiciosP1.consultaCPRequest request = new ServiciosP1.consultaCPRequest();
                    request.Body = new ServiciosP1.consultaCPRequestBody();
                    ServiciosP1.consultaCPResponseBody respBody = new ServiciosP1.consultaCPResponseBody();

                    request.Body.codp = textCP.Text;
                    request.Body.SoapKey = SoapKeyText.Text;
                 
                    respBody = servicios.consultaCP(request).Body;

                    if (respBody.poblacion != "No existe en la BBDD!")
                    {
                        resProvincia.Text = respBody.provincia;
                        resLocalidad.Text = respBody.poblacion;
                        resCP.Text = respBody.codPos;
                    }
                    else 
                        MessageBox.Show(respBody.poblacion);
                } 
                else  
                    MessageBox.Show("Introduce un Codigo Postal");
            }

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void buttonDNI_Click(object sender, EventArgs e)
        {
            if (comprobarSoapKey(SoapKeyText.Text))
            {
                if (textDNI.Text != "")
                {
                    ServiciosP1.validarDNIRequest request = new ServiciosP1.validarDNIRequest();
                    ServiciosP1.validarDNIRequestBody body = new ServiciosP1.validarDNIRequestBody();
                    ServiciosP1.validarDNIResponseBody respBody = new ServiciosP1.validarDNIResponseBody();
    
                    body.dni = textDNI.Text;
                    body.SoapKey = SoapKeyText.Text;
                    request.Body = body;

                    respBody = servicios.validarDNI(request).Body;

                    if (respBody.valido)
                    {
                        ComprobacionDNI.Visible = true;
                        ComprobacionDNI.Text = "DNI Valido";
                        ComprobacionDNI.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        ComprobacionDNI.Visible = true;
                        ComprobacionDNI.Text = "DNI No Valido";
                        ComprobacionDNI.ForeColor = System.Drawing.Color.Red;
                    }

                }
                else
                    MessageBox.Show("Introduce DNI");
            }
        }

        private void buttonIBAN_Click(object sender, EventArgs e)
        {
            if (comprobarSoapKey(SoapKeyText.Text))
            {
                if (textIBAN.Text != "")
                {
                    ServiciosP1.validarIBANRequest request = new ServiciosP1.validarIBANRequest();
                    request.Body = new ServiciosP1.validarIBANRequestBody();
                    ServiciosP1.validarIBANResponseBody respBody = new ServiciosP1.validarIBANResponseBody();
                    request.Body.iban = textIBAN.Text;
                    request.Body.SoapKey = SoapKeyText.Text;
                    respBody = servicios.validarIBAN(request).Body;
                    if (respBody.valido)
                    {

                        comprobacionIBAN.Visible = true; 
                        comprobacionIBAN.Text = "IBAN Valido";
                        comprobacionIBAN.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        comprobacionIBAN.Visible = true;
                        comprobacionIBAN.Text = "IBAN No Valido";
                        comprobacionIBAN.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                    MessageBox.Show("Introduce un IBAN");
            }
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            if (comprobarSoapKey(SoapKeyText.Text))
            {
                if (idClienteText.Text != "" && refProdText.Text != "" && cantProdText.Text != "")
                {
                    ServiciosP1.generarPresupuestoRequest request = new ServiciosP1.generarPresupuestoRequest();
                    request.Body = new ServiciosP1.generarPresupuestoRequestBody();
                    ServiciosP1.generarPresupuestoResponseBody respBody = new ServiciosP1.generarPresupuestoResponseBody();

                    request.Body.cantidadProd = Convert.ToInt32(cantProdText.Text);
                    request.Body.fechaPresupuesto = textDate.Text;
                    request.Body.idCliente = Convert.ToInt32(idClienteText.Text);
                    request.Body.referenciaProd = refProdText.Text;
                    request.Body.SoapKey = SoapKeyText.Text;

                    respBody = servicios.generarPresupuesto(request).Body;
                    if (respBody.presupuestoGenerado)
                    {
                        idPresupuestoText.Text = respBody.idPresupuesto.ToString();
                        compPresupuesto.Visible = true;
                        compPresupuesto.Text = "Generado";
                        compPresupuesto.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    { 
                        compPresupuesto.Visible = true;
                        compPresupuesto.Text = "No Generado";
                        compPresupuesto.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                    MessageBox.Show("Falta algún campo");
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textDate_MouseClick(object sender, MouseEventArgs e)
        {
            textDate.Text = "";
        }

        private void buttonSol_Click(object sender, EventArgs e)
        {
            if (comprobarSoapKey(SoapKeyText.Text))
            {
                if (refPiezaText.Text != "" && idProveedorText.Text != "")
                {
                    ServiciosP1.solicitarPresupuestoRequest request = new ServiciosP1.solicitarPresupuestoRequest();
                    request.Body = new ServiciosP1.solicitarPresupuestoRequestBody();
                    ServiciosP1.solicitarPresupuestoResponseBody respBody = new ServiciosP1.solicitarPresupuestoResponseBody();

                    request.Body.idProveedor = Convert.ToInt32(idProveedorText.Text);
                    request.Body.refPieza = refPiezaText.Text;
                    request.Body.SoapKey = SoapKeyText.Text;

                    respBody = servicios.solicitarPresupuesto(request).Body;

                    if (respBody.precioPieza != 0)
                    {
                        if (respBody.dispPieza)
                            DispText.Text = "Disponible";
                        else
                            DispText.Text = "No Disponible";
                        prePiezaText.Text = respBody.precioPieza.ToString() + " €";
                        FechaDispText.Text = respBody.fechaDispPieza.ToString();
                         
                    }
                }
                else
                    MessageBox.Show("Falta algún campo");
            }
        }
    }
}
