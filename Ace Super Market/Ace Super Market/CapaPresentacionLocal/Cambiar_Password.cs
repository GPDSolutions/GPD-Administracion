using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaPresentacionLocal
{
    public partial class Cambiar_Password : Form
    {

        String nombreUsuario;
        public Cambiar_Password()
        {
            InitializeComponent();
           
        }

        public void setnombreUsuario(String pnombreUsuario)
        {
            nombreUsuario = pnombreUsuario;
            label1.Text = "para el usuario " + nombreUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean verificacion = false;
            CapaLogica.gestor objG = new CapaLogica.gestor();
            String pnombre = nombreUsuario;
            String pcontrasenna = pass1.Text;
            if (String.IsNullOrEmpty(pass1.Text))
            {
                MessageBox.Show("Existen Campos Vacios", "MAMADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                verificacion = objG.modificarContrasenna(pnombre, pcontrasenna);
               
            }
          
            if (verificacion == true)
            {

                CapaPresentacionLocal.Principal principal = new CapaPresentacionLocal.Principal();
                principal.setnombreUsuario(pnombre);
                principal.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("MAMASTE Y NOC POR QUE", "MAMADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
