using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC.Clases
{
    class EnvioRQ
    {
        public String construirMs(Usuario usu)
        {
            AutenticacionRQ aurq = new AutenticacionRQ();
            aurq.setUsuario(usu.getUsuario());
            aurq.setClave(usu.getClave());
            MensajeRQ rq = new MensajeRQ(Originador.getOriginador(Originador.CLIENTE), Mensaje.AUTENTIC_USER);
            rq.setCuerpo(aurq);
            return rq.asTexto();
        }
        public String construirMsC(Cliente cli)
        {
            IngresarClienteRQ aurq = new IngresarClienteRQ();
            aurq.setTipoDocumento(cli.getTipo());
            aurq.setValorDocumento(cli.getDoc());
            aurq.setNombre(cli.getNombre());
            aurq.setApellido(cli.getApellido());
            aurq.setDireccion(cli.getDireccion());
            aurq.setNumeroTelefono(cli.getTelefono());
            aurq.setNumeroMovil(cli.getCelular());
            aurq.setCorreo(cli.getCorreo());
            aurq.setFechaNacimiento(cli.getNacimiento());
            MensajeRQ rq = new MensajeRQ(Originador.getOriginador(Originador.CLIENTE), Mensaje.AUTENTIC_USER);
            rq.setCuerpo(aurq);

            return rq.asTexto();
        }
    }
}
