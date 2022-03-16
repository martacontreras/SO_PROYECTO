using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Parchís
{
    public partial class Iniciarsesión : Form
    {
        Socket server;
        public Iniciarsesión()
        {
            InitializeComponent();
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            Iniciarsesión IC = new Iniciarsesión();
            IC.Close();
            Registro login = new Registro();
            login.ShowDialog();

        }

        private void entrar_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el IP del servidor y puerto del servidor
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9070);

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep); //Intentamos conectar al socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

                if(longitud.Checked)
                {

                }
                //Se terminó el servicio
                //Nos desconectamos
                this.BackColor = Color.Gray;
                server.Shutdown(SocketShutdown.Both);
                server.Close();

            }

           catch(SocketException ex)
            {
                //Si hay excepción imprimimos error y salimos del programa con return
                MessageBox.Show("No he podido conectar con el servidor");
                return;

            }
        }

    }
}
