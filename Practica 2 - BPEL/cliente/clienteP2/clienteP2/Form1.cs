using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clienteP2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            efectuado.Visible = false; 
        }

        private void comprar_Click(object sender, EventArgs e)
        {
            efectuado.Text = "";
            procesoCompra.procesoCompraRequest request = new procesoCompra.procesoCompraRequest();
            procesoCompra.procesoCompraResponse response = new procesoCompra.procesoCompraResponse();
            procesoCompra.procesoCompraClient cliente = new procesoCompra.procesoCompraClient();

            if (refProd.Text != "" && cantidad.Text != "")
            {
                request.refProducto = refProd.Text.ToString();
                request.cantidad = Convert.ToInt32(cantidad.Text.ToString());
                response = cliente.process(request);

                if (response.pedidoEfectuado == true)
                {
                    efectuado.Visible = true;
                    efectuado.Text = "Compra realizada con Exito";
                    efectuado.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    efectuado.Visible = true;
                    efectuado.Text = "La compra no se ha podido efectuar";
                    efectuado.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
                MessageBox.Show("Rellena Campos");

            
        }
    }
}
