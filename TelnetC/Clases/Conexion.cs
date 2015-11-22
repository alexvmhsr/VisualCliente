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

        public static void escribir(TcpClient cliente, String mens)
        {
            try
            {
                NetworkStream netstream = cliente.GetStream();
                StreamWriter escribir = new StreamWriter(netstream);
                escribir.WriteLine(mens);
                escribir.Flush();
            }
            catch (Exception) { }        
        }
        public static String leer(TcpClient cliente)
        {
            try
            {
                NetworkStream netstream = cliente.GetStream();
                StreamReader leer = new StreamReader(netstream);

                return leer.ReadLine();
            }
                
            catch (Exception) { return ""; }
        }
    }
}
