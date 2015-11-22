using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC
{
    class Mensaje
    {
    public static readonly String AUTENTIC_USER = "AUTENTIAPP";
    public static readonly String INFO_CLIENT = "INFOCLIENT";
    public static readonly String INSERT_CLIENT = "INSERTCLIE";
    public static readonly String INFO_PRODUCT = "INFOPRODUC";
    public static readonly String INSERT_PRODUCT = "INSERTPROD";
    public static readonly String INFO_FACT = "INFOFACTUR";
    public static readonly String INSERT_FACT = "INSERTFACT";
    public static readonly String VALIDA_CLIENT = "VALICLIENT";
    
    public static Boolean validaHash (String trama){        
        String cuerpo = trama.Substring(85, trama.Length);
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        byte[] dataHash = md5.ComputeHash(Encoding.UTF8.GetBytes(cuerpo));
        String md5HashN = dataHash.ToString();       
        String md5Hash = trama.Substring(53, 85);
//        if(md5Hash.equals(md5HashN))
//            System.out.println("correctooooo");
        return md5Hash.Equals(md5HashN);
    }
    }
}
