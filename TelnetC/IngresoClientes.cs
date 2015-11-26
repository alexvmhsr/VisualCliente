using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelnetC.Clases;

namespace TelnetC
{
    public partial class IngresoClientes : Form
    {
        public IngresoClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarClienteRQ aurq = new IngresarClienteRQ();
            aurq.setTipoDocumento("CEDUL");
            aurq.setValorDocumento(txtTipoDoc.Text.ToString());
            aurq.setNombre(txtNombre.Text.ToString());
            aurq.setApellido(txtApellido.Text.ToString());
            aurq.setDireccion(txtDirec.Text.ToString());
            aurq.setNumeroTelefono(txtTelefono.Text.ToString());
            aurq.setNumeroMovil(txtcel.Text.ToString());
            aurq.setCorreo(txtCorreo.Text.ToString());
            aurq.setFechaNacimiento(comanio.Text.ToString() + commes.Text.ToString() + comdia.Text.ToString());
            MensajeRQ rq = new MensajeRQ(Originador.getOriginador(Originador.CLIENTE), Mensaje.INSERT_CLIENT);
            rq.setCuerpo(aurq);
            Conexion.flujo(rq.asTexto());

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
