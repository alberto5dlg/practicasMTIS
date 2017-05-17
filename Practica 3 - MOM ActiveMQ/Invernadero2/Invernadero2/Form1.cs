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

namespace Invernadero2
{
    public partial class Invernadero2 : Form
    {
        private string subject = "EstadoInvernadero2";
        public const string URI = "activemq:tcp://localhost:61616";



        public Invernadero2()
        {
            InitializeComponent();
            generarDatos();
            ventBox.Text = "Desactivado";
            humidBox.Text = "Desactivado";

        }

        public string SendMessage()
        {
            string result = string.Empty;
            IConnectionFactory connectionFactory = new ConnectionFactory(URI);
            IConnection _connection = connectionFactory.CreateConnection();
            _connection.Start();
            ISession _session = _connection.CreateSession();

            try
            {
                IDestination destination = _session.GetDestination(subject);
                using (IMessageProducer producer = _session.CreateProducer(destination))
                {
                    var textMessage = producer.CreateTextMessage("Temperatura:" + tempBox.Text.ToString() + ",Humedad:" + humBox.Text.ToString());
                    producer.Send(textMessage);
                }
                result = "Mensaje Enviado Correctamente";
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

        public void listenData()
        {
            try
            {
                IConnectionFactory connectionFactory = new ConnectionFactory("tcp://localhost:61616");
                IConnection _connection = connectionFactory.CreateConnection();
                _connection.Start();
                ISession _session = _connection.CreateSession();
                IDestination dest = _session.GetDestination("Actuadores2");
                using (IMessageConsumer consumer = _session.CreateConsumer(dest))
                {
                    IMessage message = consumer.Receive();
                    if (message != null)
                    {
                        ITextMessage textMessage = message as ITextMessage;
                        if (!string.IsNullOrEmpty(textMessage.Text))
                        {
                            
                            string[] actuadores = textMessage.Text.Split(';');
                            if (actuadores[0].Equals("ventilador2"))
                            {
                                ventBox.Text = "Activado";
                                tempBox.Text = "15";
                            }
                            else
                                ventBox.Text = "Desactivado";
                            if (actuadores[1].Equals("humidificador2"))
                            {
                                humidBox.Text = "Activado";
                                humBox.Text = "45";
                            }
                            else 
                                humidBox.Text = "Desactivado";
                        }
                    }
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Recbir Inv 2");
                Console.WriteLine(ex);
            }
        }

        public void generarDatos()
        {
            Random rnd = new Random();
            tempBox.Text = Convert.ToString(rnd.Next(10, 51));
            humBox.Text = Convert.ToString(rnd.Next(50, 101));
            ventBox.Text = "Desactivado";
            humidBox.Text = "Desactivado";
        }


        private void EnviarMensajes_Tick_1(object sender, EventArgs e)
        {
            EnviarMensajes.Stop();
            SendMessage();
            EnviarMensajes.Start();
        }

        private void ActualizarDatos_Tick(object sender, EventArgs e)
        {
            ActualizarDatos.Stop();
            generarDatos();
            ActualizarDatos.Start();
        }

        private void RecibirDatos_Tick(object sender, EventArgs e)
        {
            RecibirDatos.Stop();
            listenData();
            RecibirDatos.Start();
        }
    }
}
