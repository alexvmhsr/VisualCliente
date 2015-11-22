using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC.Clases
{
    class InformacionProductoRQ : Cuerpo
    {
        private String valor;
    
    public String getValor() {
        return valor;
    }

    public void setValor(String valor) {
        this.valor = valor.PadLeft(10);
    }

   
    
    string Cuerpo.asTexto()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.valor);
        return sb.ToString();
    }
    }
}
