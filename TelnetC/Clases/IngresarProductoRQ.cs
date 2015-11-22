using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC.Clases
{
    class IngresarProductoRQ : Cuerpo
    {
    private int codigo;
    private String nombre;
    private double costoUnitario;
    private String descripcion;

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getCostoUnitario() {
        return costoUnitario;
    }

    public void setCostoUnitario(double costoUnitario) {
        this.costoUnitario = costoUnitario;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String toString() {
        return "IngresarProductoRQ{" + "codigo=" + codigo + ", nombre=" + nombre + ", costoUnitario=" + costoUnitario + ", descripcion=" + descripcion + '}';
    }

        string Cuerpo.asTexto()
        {
 	    StringBuilder sb = new StringBuilder();
        sb.Append("_").Append(this.codigo);
        sb.Append("-").Append(this.nombre);
        sb.Append("-").Append(this.costoUnitario);
        sb.Append("-").Append(this.descripcion);
        return sb.ToString();
        }
    }
}
