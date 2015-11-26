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
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresoClientes ing = new IngresoClientes();
            ing.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InformacionClienteRQ inf = new InformacionClienteRQ();
            inf.setValor(txtBuscarClientes.Text.ToString());
            MensajeRQ rq = new MensajeRQ(Originador.getOriginador(Originador.CLIENTE), Mensaje.INFO_CLIENT);
            rq.setCuerpo(inf);
            Conexion.flujo(rq.asTexto());
            Object[] arr2 = Conexion.flujoRSc();
            //modelo.addRow(arr2);
        }
    }
}
