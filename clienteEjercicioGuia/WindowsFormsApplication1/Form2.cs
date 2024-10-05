using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        int nForm;
        Socket server;

        public Form2(int nForm, Socket server)
        {
            InitializeComponent();
            this.nForm = nForm;
            this.server = server;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Longitud.Checked)
            {
                string mensaje = "1/" + nForm + "/" + nombre.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            else if (Bonito.Checked)
            {
                string mensaje = "2/" + nForm + "/" + nombre.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            else if (palindromo.Checked) // Cambiado a palindromo
            {
                string mensaje = "4/" + nForm + "/" + nombre.Text; // Código 4 para palíndromo
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            else if (mayusculas.Checked) // Nuevo bloque para mayúsculas
            {
                string mensaje = "5/" + nForm + "/" + nombre.Text.ToUpper(); // Código 5 para mayúsculas
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            else
            {
                string mensaje = "3/" + nForm + "/" + nombre.Text + "/" + alturaBox.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numForm.Text = nForm.ToString();
        }

        public void TomaRespuesta1(string mensaje)
        {
            MessageBox.Show("Longitud: " + mensaje);
        }

        public void TomaRespuesta2(string mensaje)
        {
            if (mensaje == "SI")
                MessageBox.Show("Tu nombre es bonito");
            else
                MessageBox.Show("Tu nombre No es bonito. Lo siento");
        }

        public void TomaRespuesta3(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void TomaRespuesta4(string mensaje)
        {
            if (mensaje == "SI")
                MessageBox.Show("Tu nombre es un palíndromo");
            else
                MessageBox.Show("Tu nombre no es un palíndromo");
        }

        public void TomaRespuesta5(string mensaje)
        {
            MessageBox.Show("Nombre en mayúsculas: " + mensaje);
        }
    }
}
