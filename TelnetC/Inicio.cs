using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using TelnetC.Clases;


namespace TelnetC
{
    public partial class Inicio : Form
    {
        public String IP;
        public int puerto;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Probar_Click(object sender, EventArgs e)
        {
            
            IP = txtIP.Text.ToString();
            puerto = int.Parse(txtPuerto.Text);

            if (Conexion.Conectar(IP, puerto).Equals(true))
            {
                lblOK.Visible=true;
                lblKO.Visible = false;
                btn_Ingresar.Visible = true;

            }
            else
            {
                lblOK.Visible = false;
                lblKO.Visible = true;
                btn_Ingresar.Visible = false;
            }
        }
        

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            
            Autentificacion au = new Autentificacion();          
            au.Show();

         
        }

       
    }
}
