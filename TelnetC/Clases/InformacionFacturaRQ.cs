using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC.Clases
{
    class InformacionFacturaRQ : Cuerpo

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
        return this.valor;
    }
    }
}
