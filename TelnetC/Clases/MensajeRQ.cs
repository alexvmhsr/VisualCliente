using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC
{
    class MensajeRQ
    {
    private static String TIPO_MENSAJE = "RQ";

    private Cabecera cabecera;
    private Cuerpo cuerpo;

    public MensajeRQ(String originador, String idMensaje) {
        this.cabecera = new Cabecera(MensajeRQ.TIPO_MENSAJE, originador, idMensaje);
    }

    public Cabecera getCabecera() {
        return cabecera;
    }

    public void setCabecera(Cabecera cabecera) {
        this.cabecera = cabecera;
    }

    public Cuerpo getCuerpo() {
        return cuerpo;
    }

    public void setCuerpo(Cuerpo cuerpo) {
        this.cuerpo = cuerpo;
    }

    public String asTexto() {
        int longitud = this.cuerpo.asTexto().Length;
        this.cabecera.setLongitudCuerpo(longitud.ToString());
        this.cabecera.setVerificacion(this.cuerpo.asTexto());
        return this.cabecera.asTexto() + this.cuerpo.asTexto();
    }
    }
}
