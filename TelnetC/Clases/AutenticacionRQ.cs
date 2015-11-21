using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC.Clases
{
    class AutenticacionRQ
    {
    private String usuario;
	private String clave;
	
	
	public String getUsuario() {
		return usuario;
	}
	public void setUsuario(String usuario) {
		this.usuario = usuario.PadRight(10);
	}
	public String getClave() {
		return clave;
	}
	public void setClave(String clave) {
		this.clave = clave.PadRight(10);
	}
	

	public String asTexto() {
		// TODO Auto-generated method stub
		return this.usuario + this.clave;
	}
    }
}
