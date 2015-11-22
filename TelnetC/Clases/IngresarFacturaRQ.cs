using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC.Clases
{
    class IngresarFacturaRQ : Cuerpo
    {
        private String codigoCLiente;
    private int codigoFactura;
    private String fechaEmision;
    private double totalFactura;
    private String cuerpo;

    public IngresarFacturaRQ(int codigoFactura, String codigoCLiente, String fechaEmision, double totalFactura, String cuerpo) {
        this.codigoFactura = codigoFactura;
        this.codigoCLiente = codigoCLiente;
        this.fechaEmision = fechaEmision;
        this.totalFactura = totalFactura;
        this.cuerpo = cuerpo;
    }
    
    public int getCodigoFactura() {
        return codigoFactura;
    }

    public void setCodigoFactura(int codigoFactura) {
        this.codigoFactura = codigoFactura;
    }

    public String getCodigoCLiente() {
        return codigoCLiente;
    }

    public void setCodigoCLiente(String codigoCLiente) {
        this.codigoCLiente = codigoCLiente;
    }

    public String getFechaEmision() {
        return fechaEmision;
    }

    public void setFechaEmision(String fechaEmision) {
        this.fechaEmision = fechaEmision;
    }

    public double getTotalFactura() {
        return totalFactura;
    }

    public void setTotalFactura(double totalFactura) {
        this.totalFactura = totalFactura;
    }

    public String getCuerpo() {
        return cuerpo;
    }

    public void setCuerpo(String cuerpo) {
        this.cuerpo = cuerpo;
    }
    
        string Cuerpo.asTexto()
        {
 	    StringBuilder sb = new StringBuilder();
        sb.Append("_").Append(this.codigoCLiente);
        sb.Append("-").Append(this.codigoFactura);
        sb.Append("-").Append(this.fechaEmision);
        sb.Append("-").Append(this.totalFactura);
        sb.Append("_").Append(this.cuerpo);        
        return sb.ToString();
        }
}
}
