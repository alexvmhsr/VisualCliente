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
using System.IO;

namespace TelnetC
{
    public partial class Autentificacion : Form
    {
        public Autentificacion()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Inicio inicio = new Inicio();
            
            NetworkStream Stm = null;
            byte[] bufferEscritura = null;

            TcpClient tcpClnt = new TcpClient();

            // Conecto el socket al servidor.
            tcpClnt.Connect("127.0.0.1",4420);
            Stm = tcpClnt.GetStream();

            if (Stm.CanWrite)
            {
                String usu = txt_Usuario.Text.ToString();
                String clave = txt_Password.ToString();
                bufferEscritura = Encoding.ASCII.GetBytes(usu+"_"+clave);

                if ((Stm != null))
                {
                    //Envio los datos al Servidor
                    Stm.Write(bufferEscritura, 0, bufferEscritura.Length);
                }
            }
            tcpClnt.Close();
        }
    }
}
