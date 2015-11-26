using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelnetC.Clases
{
    class Usuario
    {
       
            private String usuario;
            private String clave;

            public Usuario()
            {
            }

            public Usuario(String usuario, String clave)
            {
                this.usuario = usuario;
                this.clave = clave;
            }

            public String getUsuario()
            {
                return usuario;
            }

            public void setUsuario(String usuario)
            {
                this.usuario = usuario;
            }

            public String getClave()
            {
                return clave;
            }

            public void setClave(String clave)
            {
                this.clave = clave;
            }

        
    }
}
