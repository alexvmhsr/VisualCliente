using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC.Clases
{
    class IngresarClienteRQ : Cuerpo
    {
        private int codigo;
    private String tipoDocumento;
    private String valorDocumento;
    private String nombre;
    private String apellido;
    private String direccion;
    private String numeroTelefono;
    private String numeroMovil;
    private String correo;
    private String fechaNacimiento;

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getTipoDocumento() {
        return tipoDocumento;
    }

    public void setTipoDocumento(String tipoDocumento) {
        this.tipoDocumento = tipoDocumento;
    }

    public String getValorDocumento() {
        return valorDocumento;
    }

    public void setValorDocumento(String valorDocumento) {
        this.valorDocumento = valorDocumento;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public String getNumeroTelefono() {
        return numeroTelefono;
    }

    public void setNumeroTelefono(String numeroTelefono) {
        this.numeroTelefono = numeroTelefono;
    }

    public String getNumeroMovil() {
        return numeroMovil;
    }

    public void setNumeroMovil(String numeroMovil) {
        this.numeroMovil = numeroMovil;
    }

    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public String getFechaNacimiento() {
        return fechaNacimiento;
    }

    public void setFechaNacimiento(String fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
    }

    public String toString() {
        return "IngresarClienteRQ{" + "codigo=" + codigo + ", tipoDocumento=" + tipoDocumento + ", valorDocumento=" + valorDocumento + ", nombre=" + nombre + ", apellido=" + apellido + ", direccion=" + direccion + ", numeroTelefono=" + numeroTelefono + ", numeroMovil=" + numeroMovil + ", correo=" + correo + ", fechaNacimiento=" + fechaNacimiento + '}';
    }
  
        string Cuerpo.asTexto()
        {
 	        StringBuilder sb = new StringBuilder();
             sb.Append(this.codigo);
             sb.Append("_").Append(this.tipoDocumento);
             sb.Append("-").Append(this.valorDocumento);
             sb.Append("-").Append(this.nombre);
             sb.Append("-").Append(this.apellido);
             sb.Append("-").Append(this.direccion);
             sb.Append("-").Append(this.numeroTelefono);
             sb.Append("-").Append(this.numeroMovil);
             sb.Append("-").Append(this.correo);
             sb.Append("-").Append(this.fechaNacimiento);        
             return sb.ToString();
}
}
}
