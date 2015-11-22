using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC.Clases
{
    class validaClienteRQ: Cuerpo
    {
        private String valorDocumento;

    public validaClienteRQ(String valorDocumento) {
        char pad = '0';
        this.valorDocumento = valorDocumento.PadLeft(15, pad);
    }

    public String toString() {
        return "validaClienteRQ{" + "valorDocumento=" + valorDocumento + '}';
    }

    public String getValorDocumento() {
        return valorDocumento;
    }

    public void setValorDocumento(String valorDocumento) {
        char pad = '0';
        this.valorDocumento = valorDocumento.PadLeft(15, pad);
    }
    
        string Cuerpo.asTexto()
        {
 	        return this.valorDocumento;
        }
}
}
