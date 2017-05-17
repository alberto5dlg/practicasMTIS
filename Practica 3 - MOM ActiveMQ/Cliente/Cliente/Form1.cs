using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apache.NMS.ActiveMQ;
using Apache.NMS;

namespace Cliente
{
    public partial class Cliente : Form
    {
        public string url = "tcp://localhost:61616";

        public Cliente()
        {
            InitializeComponent();
        }

        public void listenData(string subject)
        {
            try
            {
                IConnectionFactory connectionFactory = new ConnectionFactory(url);
                IConnection _connection = connectionFactory.CreateConnection();
                _connection.Start();
                ISession _session = _connection.CreateSession();
                IDestination dest = _session.GetDestination(subject);
                using (IMessageConsumer consumer = _session.CreateConsumer(dest))
                {
                    IMessage message = consumer.Receive();
                    if (message != null)
                    {
                        ITextMessage textMessage = message as ITextMessage;
                        if (!string.IsNullOrEmpty(textMessage.Text))
                        {
                            string[] result = textMessage.Text.Split(',');
                            string[] temp = result[0].Split(':');
                            string[] hum = result[1].Split(':');
                            if (subject.Equals("EstadoInvernadero1"))
                            {
                                temp1.Text = temp[1];
                                hum1.Text = hum[1];
                            }
                            else
                            {
                                temp2.Text = temp[1];
                                hum2.Text = hum[1];
                            }
                        }
                    }
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Invernadero 1: " + ex.Message);
            }  
        }

        public void comprobarDatos()
        {
            string activar1 = "";
            string activar2 = "";
            if (Convert.ToInt32(temp1.Text) >= 20)
            {
                activar1 += "ventilador1;";
                vent1.Text = "Activado";
            }
            else { vent1.Text = "Desactivado"; activar1 += "nada;"; }

            if (Convert.ToInt32(temp2.Text) >= 20)
            {
                activar2 += "ventilador2;";
                vent2.Text = "Activado";
            }
            else { vent2.Text = "Desactivado"; activar2 += "nada;"; }

            if (Convert.ToInt32(hum1.Text) >= 70)
            {
                activar1 += "humidificador1;";
                Humidificador1.Text = "Activado";
            }
            else { Humidificador1.Text = "Desactivado"; activar1 += "nada"; }

            if (Convert.ToInt32(hum2.Text) >= 70)
            {
                activar2 += "humidificador2;";
                Humidificador2.Text = "Activado";
            }
            else { Humidificador2.Text = "Desactivado"; activar2 += "nada"; }

            activarActuadores(activar1,"Actuadores1");
            activarActuadores(activar2,"Actuadores2");
        }

        public string activarActuadores(string message, string actuador){
            string result = string.Empty;
            IConnectionFactory connectionFactory = new ConnectionFactory("activemq:tcp://localhost:61616");
            IConnection _connection = connectionFactory.CreateConnection();
            _connection.Start();
            ISession _session = _connection.CreateSession();

            try
            {
                IDestination destination = _session.GetDestination(actuador);
                using (IMessageProducer producer = _session.CreateProducer(destination))
                {
                    var textMessage = producer.CreateTextMessage(message);
                    producer.Send(textMessage);
                }
                result = "Mensaje Envidado correctamente";
            }
            catch (Exception ex)
            {
                result = ex.Message;
                MessageBox.Show(result);
                Console.WriteLine(ex.ToString());
            }
            _connection.Close();
            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListenInv1.Stop();
            listenData("EstadoInvernadero1");
            listenData("EstadoInvernadero2");
            comprobarDatos();
            ListenInv1.Start();
        }

    }

    
}
