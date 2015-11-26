using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using TelnetC.Clases;
using System.Net;
using System.Timers;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TelnetC.Clases
{
    class Conexion
    {
        public static TcpClient socketForServer;

        public static Boolean Conectar(String IP, int puerto)
        {


            try
            {
                //Creamos un TcpCliente y le pasamos 
                //el server y el puerto.
                socketForServer = new TcpClient();
                socketForServer.Connect(IPAddress.Parse(IP), puerto);

                return (true);
            }
            catch
            {
                Console.WriteLine(
                "No se pudo conectar a {0}:9898", IP);
                return (false);
            }
        }

        public static void flujo(String mens)
        {
            try
            {
                NetworkStream netstream = socketForServer.GetStream();
                StreamWriter escribir = new StreamWriter(netstream);
                escribir.WriteLine(mens);
                escribir.Flush();
            }
            catch (Exception) { }
        }
        public static Boolean flujoRS()
        {
            try
            {
                NetworkStream netstream = socketForServer.GetStream();
                StreamReader leer = new StreamReader(netstream);
                String trama = leer.ReadLine();
                MessageBox.Show("Mensaje Serv:  "+trama, "Respuesta",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (Mensaje.validaHash(trama))
                {
                    if ("OK".Equals(trama.Substring(85)))
                    {

                        MessageBox.Show("Ingreso correcto", "Respuesta",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        return true;
                    }
                }
                
            }

            catch (Exception) { 
                MessageBox.Show("Error al Ingresar", "Respuesta",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false; 
            }
            return false;
        }
        public static String[] flujoRSc()
        {
        try {
            NetworkStream netstream = socketForServer.GetStream();
            StreamReader leer = new StreamReader(netstream);                
            String trama=leer.ReadLine();

            
            if(Mensaje.validaHash(trama)){
         
               //if("OKO".equals(trama.substring(85,88))){
                   String [] arr1=Regex.Split(trama,"OKO_");
                   String [] arr2=arr1[1].Split('-');
                   
            
            return arr2;
               //} 
           }   
        }catch (IOException) {
            return null;
        }
        return null;
    }
        public static String[] flujoRSp()
        {
        try {
             NetworkStream netstream = socketForServer.GetStream();
            StreamReader leer = new StreamReader(netstream);          
            String trama=leer.ReadLine();
           
                   String [] arr1=Regex.Split(trama,"OKO_");
                   String [] arr2=arr1[1].Split('-');
                   
                   
            return arr2;
               //} 
           //}   
        }catch (IOException) {
           return null;
        }
    }
    }
}
