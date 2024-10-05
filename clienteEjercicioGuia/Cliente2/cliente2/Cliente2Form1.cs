using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace cliente2
{
    public partial class Cliente2Form1 : Form
    {
        Socket server;
        Thread atender;

        public Cliente2Form1()
        {
            InitializeComponent();
        }

        private void AtenderServidor()
        {
            while (true)
            {
                try
                {
                    byte[] msg = new byte[512];
                    int bytesRecibidos = server.Receive(msg);
                    if (bytesRecibidos > 0)
                    {
                        string respuesta = Encoding.ASCII.GetString(msg, 0, bytesRecibidos);
                        MessageBox.Show(respuesta);  // Mostrar la respuesta en un MessageBox
                    }
                }
                catch (SocketException)
                {
                    MessageBox.Show("Se ha perdido la conexión con el servidor.");
                    break;
                }
            }
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9050);

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

                atender = new Thread(AtenderServidor);
                atender.Start();
            }
            catch (SocketException)
            {
                MessageBox.Show("No he podido conectar con el servidor.");
            }
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            if (server != null && server.Connected)
            {
                server.Shutdown(SocketShutdown.Both);
                server.Close();
            }
            atender?.Abort();
            this.BackColor = Color.Gray;
            MessageBox.Show("Desconectado");
        }

        private void buttonAbrirFormulario_Click(object sender, EventArgs e)
        {
            Cliente2Form2 f = new Cliente2Form2(server);
            f.Show();  // Permitir abrir múltiples instancias de conversión
        }
    }
}
