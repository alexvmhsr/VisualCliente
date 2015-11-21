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
    public partial class Inicio : Form
    {
        public String IP;
        public int puerto;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Probar_Click(object sender, EventArgs e)
        {

            IP = txtIP.Text.ToString();
            puerto = int.Parse(txtPuerto.Text);

            if(Conectar(IP,puerto).Equals(true))
            {
                lblOK.Visible=true;
                lblKO.Visible = false;
                btn_Ingresar.Visible = true;

            }
            else
            {
                lblOK.Visible = false;
                lblKO.Visible = true;
                btn_Ingresar.Visible = false;
            }
        }
        public static Boolean Conectar(String IP,int puerto)
        {

            Socket Distri = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // paso 2 - creamos el socket
            IPEndPoint miDireccion = new IPEndPoint(IPAddress.Parse(IP), puerto);
            //paso 3 - Acá debemos poner la Ip del servidor, y el puerto de escucha del servidor
            //Yo puse esa porque corrí las dos aplicaciones en la misma pc
            try
            {
                Distri.Connect(miDireccion); // Conectamos               
                Console.WriteLine("Conectado con exito");
                return(true);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
                return (false);
            }
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            IP = txtIP.Text.ToString();
            int puerto = int.Parse(txtPuerto.Text);
        
            NetworkStream Stm = null;
            byte[] bufferEscritura = null;

            TcpClient tcpClnt = new TcpClient();

            // Conecto el socket al servidor.
            tcpClnt.Connect(IP, puerto);
            Stm = tcpClnt.GetStream();

            if (Stm.CanWrite)
            {
                bufferEscritura = Encoding.ASCII.GetBytes("Vr ya envia");

                if ((Stm != null))
                {
                    //Envio los datos al Servidor
                    Stm.Write(bufferEscritura, 0, bufferEscritura.Length);
                }
            }
            tcpClnt.Close();
            Autentificacion au = new Autentificacion();
          
            au.Show();

         
        }

       
    }
}
