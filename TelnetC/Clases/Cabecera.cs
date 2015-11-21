using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC
{
    class Cabecera
    {
    private String tipoMensaje;
    private String originador;
    private String fecha;
    private String idMensaje;
    private String longitudCuerpo;
    private String verificacion;

    public Cabecera(String tipoMensaje, String originador, String idMensaje) {
        this.tipoMensaje = tipoMensaje;
        this.originador = originador;
        this.idMensaje = idMensaje;     
        this.fecha = DateTime.Now.ToString("yyyyMMdd");
       
    }

    public String getTipoMensaje() {
        return tipoMensaje;
    }

    public void setTipoMensaje(String tipoMensaje) {
        this.tipoMensaje = tipoMensaje;
    }

    public String getOriginador() {
        return originador;
    }

    public void setOriginador(String originador) {
        char pad = '.';
        this.originador = originador.PadLeft(20, pad);
    }

    public String getFecha() {
        return fecha;
    }

    public void setFecha(String fecha) {
        this.fecha = fecha;
    }

    public String getIdMensaje() {
        return idMensaje;
    }

    public void setIdMensaje(String idMensaje) {
        this.idMensaje = idMensaje;
    }

    public String getLongitudCuerpo() {
        return longitudCuerpo;
    }

    public void setLongitudCuerpo(String longitudCuerpo) {
        char pad = '.';
        this.longitudCuerpo = longitudCuerpo.PadLeft(4, pad);
    }

    public String getVerificacion() {
        return verificacion;
    }

    public void setVerificacion(String verificacion) {
        //System.out.println(verificacion);
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        byte[] dataHash = md5.ComputeHash(Encoding.UTF8.GetBytes(verificacion));
        this.verificacion = dataHash.ToString();
    }

    
    public String toString() {
        return "Cabecera{" + "tipoMensaje=" + tipoMensaje + ", originador=" + originador + ", fecha=" + fecha + ", idMensaje=" + idMensaje + ", longitudCuerpo=" + longitudCuerpo + ", verificacion=" + verificacion + '}';
    }

    public String asTexto() {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.tipoMensaje);
        setOriginador(this.originador);
        sb.Append(this.originador);
        sb.Append(this.fecha);
        this.setIdMensaje(idMensaje);
        sb.Append(this.idMensaje);
        sb.Append(this.getLongitudCuerpo());
        sb.Append(this.getVerificacion());
        return sb.ToString();

    }
    }
}
