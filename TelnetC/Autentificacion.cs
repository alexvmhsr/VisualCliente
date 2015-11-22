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
using TelnetC.Clases;

namespace TelnetC
{
    public partial class Autentificacion : Form
    {
        
        public Autentificacion()
        {
            InitializeComponent();
            //tmrEscuchar.Tick += new EventHandler();
                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usu= txt_Usuario.Text.ToString();
            String clave = txt_Password.Text.ToString();
             Timer tmrEscuchar = new Timer();
             AutenticacionRQ aurq = new AutenticacionRQ();
             aurq.setUsuario(usu);
             aurq.setClave(clave);
             MensajeRQ maurq = new MensajeRQ(Originador.CLIENTE, Mensaje.AUTENTIC_USER);
             maurq.setCuerpo(aurq);
            
                 Conexion.escribir(Conexion.socketForServer, maurq.asTexto());
             
             
     
             
            
        }
        private void Autentificacion_Load(object sender, EventArgs e)
        {

        }
    }
}
