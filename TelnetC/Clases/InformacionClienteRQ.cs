using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC.Clases
{
    class InformacionClienteRQ : Cuerpo
    {
    private String TipoDocumento;
    private String valor;

    public String getTipoDocumento() {
        return TipoDocumento;
    }

    public void setTipoDocumento(String TipoDocumento) {
        this.TipoDocumento = TipoDocumento;
    }

    public String getValor() {
        return valor;
    }

    public void setValor(String valor) {
        char pad = '0';
        this.valor = valor.PadLeft(15, pad);
    }

    
    public String toString() {
        return "InformacionCliente{" + "TipoDocumento=" + TipoDocumento + ", valor=" + valor + '}';
    }

    string Cuerpo.asTexto()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.TipoDocumento);
        sb.Append(this.valor);
        return sb.ToString();
    }
    }
}
