using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace cliente2
{
    public partial class Cliente2Form2 : Form
    {
        Socket server;

        public Cliente2Form2(Socket serverSocket)
        {
            InitializeComponent();
            server = serverSocket;
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            string tipoConversion = radioButtonFtoC.Checked ? "FtoC" : "CtoF";
            string mensaje = tipoConversion + "/" + textBoxTemperatura.Text;

            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }
    }
}
