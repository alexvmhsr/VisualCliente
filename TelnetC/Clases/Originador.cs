using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

namespace TelnetC.Clases
{
    class Originador
    {
    public static readonly  String CLIENTE = "C";
    public static readonly  String SRV_APLICACION = "A";
    public static readonly  String BASE_DATOS = "B";

    public static String getOriginador(String c) {
        
        IPHostEntry host;
        String localIP = "";
        host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (IPAddress ip in host.AddressList)
        {
            if (ip.AddressFamily.ToString() == "InterNetwork")
            {
                localIP = ip.ToString();
            }
        }
        char pad = '0';
        localIP = localIP + "@" + c;
        localIP = localIP.PadRight(20, pad);
        return localIP;
    }
    }
}
